using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwoomTrading
{
    public partial class Form1 : Form
    {
        List<ConditionObject> conditionObjectList;
        List<stockBalance> stockBalanceList;
        public Form1()
        {

            InitializeComponent();

            axKHOpenAPI1.OnEventConnect += onEventConnect;
            axKHOpenAPI1.OnReceiveConditionVer += onReceiveConditionVer;
            conditionDataGridView.SelectionChanged += conditionSearch;
            axKHOpenAPI1.OnReceiveTrCondition += onReceiveTrCondition;
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
            search_button.Click += conditionSearch;

            axKHOpenAPI1.CommConnect();
            
        }
        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "조건검색종목")
            {
                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);


                int conditionObjectIndex = -1;

                if (conditionDataGridView.SelectedCells.Count > 0)
                {
                    int conditionIndex = conditionDataGridView.SelectedCells[0].RowIndex;
                    string selectedConditionName = conditionDataGridView["조건식_조건식이름", conditionIndex].Value.ToString();
                    conditionObjectIndex = conditionObjectList.FindIndex(o => o.conditionName == selectedConditionName);
                }

                conditionObjectList[conditionObjectIndex].stockItemList.Clear();
                stockDataGridView.Rows.Clear();
                for (int i = 0; i < count; i++)
                {
                    string stockCode = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    string stockName = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    long currentPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Replace("-", ""));
                    double upDownRate = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "등락율"));
                    int netChange = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "전일대비"));
                    long volume = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "거래량"));

                    stockDataGridView.Rows.Add();
                    stockDataGridView["조건검색_종목코드", i].Value = stockCode;
                    stockDataGridView["조건검색_종목명", i].Value = stockName;
                    stockDataGridView["조건검색_현재가", i].Value = String.Format("{0:#,###}", currentPrice);
                    stockDataGridView["조건검색_전일대비", i].Value = netChange;
                    stockDataGridView["조건검색_등락율", i].Value = upDownRate;
                    stockDataGridView["조건검색_거래량", i].Value = String.Format("{0:#,###}", volume);

                    if (conditionObjectIndex > -1)
                    {
                        conditionObjectList[conditionObjectIndex].stockItemList.Add(new StockItem(stockCode, stockName, currentPrice, upDownRate, netChange, volume));
                    }
                }
            } else if(e.sRQName == "계좌평가현황요청")
            {
                
                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                stockBalanceList = new List<stockBalance>();

                balanceDataGridView.Rows.Clear();
                for (int i = 0; i < count; i++)
                {
                    string stockCode = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").TrimStart('0');
                    string stockName = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    long number = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                    long buyingMoney = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입금액"));
                    long currentPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Replace("-", ""));
                    long estimatedProfit = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익금액"));
                    double estimatedProfitRate = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익율"));

                    balanceDataGridView.Rows.Add();
                    balanceDataGridView["잔고_종목코드", i].Value = stockCode;
                    balanceDataGridView["잔고_종목명", i].Value = stockName;
                    balanceDataGridView["잔고_보유수량", i].Value = number;
                    balanceDataGridView["잔고_매입금액", i].Value = buyingMoney;
                    balanceDataGridView["잔고_현재가", i].Value = currentPrice;
                    balanceDataGridView["잔고_손익금액", i].Value = estimatedProfit;
                    balanceDataGridView["잔고_손익율", i].Value = estimatedProfitRate;

                    stockBalanceList.Add(new stockBalance(stockCode, stockName, number, String.Format("{0:#,###}", buyingMoney), String.Format("{0:#,###}", currentPrice), estimatedProfit, String.Format("{0:f2}", estimatedProfitRate)));
                }
            }
        }
        public void onReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            // 분당 1회 제한
            if (e.strCodeList.Length > 0)
            {
                string stockCodeList = e.strCodeList.Remove(e.strCodeList.Length - 1);
                int stockCount = stockCodeList.Split(';').Length;

                if (stockCount <= 100)
                {
                    axKHOpenAPI1.CommKwRqData(stockCodeList, 0, stockCount, 0, "조건검색종목", "5100");
                }
            }
            else if (e.strCodeList.Length == 0)
            {
                MessageBox.Show("검색된 종목이 없습니다.");
            }
        }
        public void conditionSearch(object sender, EventArgs e)
        {
            try
            {
                if (conditionDataGridView.SelectedCells.Count > 0)
                {
                    int rowIndex = conditionDataGridView.SelectedCells[0].RowIndex;
                    string conditionName = conditionDataGridView["조건식_조건식이름", rowIndex].Value.ToString();
                    int conditionIndex = int.Parse(conditionDataGridView["조건식_조건식번호", rowIndex].Value.ToString());
                    axKHOpenAPI1.SendCondition("0156", conditionName, conditionIndex, 1);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
        }
        public void onReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            conditionObjectList = new List<ConditionObject>();
            if (e.lRet == 1)
            {
                string conditionList = axKHOpenAPI1.GetConditionNameList().TrimEnd(';');
                string[] conditionArray = conditionList.Split(';');

                for (int i = 0; i < conditionArray.Length; i++)
                {
                    string[] condition = conditionArray[i].Split('^');
                    conditionDataGridView.Rows.Add();
                    conditionDataGridView["조건식_조건식번호", i].Value = condition[0];
                    conditionDataGridView["조건식_조건식이름", i].Value = condition[1];

                    conditionObjectList.Add(new ConditionObject(condition[0], condition[1]));

                }
            }
        }
        public void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                axKHOpenAPI1.GetConditionLoad();
            }
        }

        private void AxKHOpenAPI1_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

        }

        private void Balance_button_Click(object sender, EventArgs e)
        {
            string accountNumber = ""; // 계좌번호
            string password = "";// 계좌비밀번호

            axKHOpenAPI1.SetInputValue("계좌번호", accountNumber);
            axKHOpenAPI1.SetInputValue("비밀번호", password);
            axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.CommRqData("계좌평가현황요청", "opw00004", 0, "0004");
        }
    }
    class ConditionObject
    {
        public string conditionIndex;
        public string conditionName;
        public List<StockItem> stockItemList;
        public ConditionObject(string conditionIndex, string conditionName)
        {
            this.conditionIndex = conditionIndex;
            this.conditionName = conditionName;
            stockItemList = new List<StockItem>();
        }
    }
    class StockItem
    {
        public string stockCode;
        public string stockName;
        public long currentPrice;
        public double upDownRate;
        public int netChange;
        public long volume;
        public StockItem(string stockCode, string stockName, long currentPrice, double upDownRate, int netChange, long volume)
        {
            this.stockCode = stockCode;
            this.stockName = stockName;
            this.currentPrice = currentPrice;
            this.upDownRate = upDownRate;
            this.netChange = netChange;
            this.volume = volume;
        }
    }

    class stockBalance
    {
        public string 종목코드 { get; set; }
        public string 종목명 { get; set; }
        public long 수량 { get; set; }
        public string 매수금 { get; set; }
        public string 현재가 { get; set; }
        public long 평가손익 { get; set; }
        public string 수익률 { get; set; }

        public stockBalance() { }

        public stockBalance(string 종목번호, string 종목명, long 수량, string 매수금, string 현재가, long 평가손익, string 수익률)
        {
            this.종목코드 = 종목번호;
            this.종목명 = 종목명;
            this.수량 = 수량;
            this.매수금 = 매수금;
            this.현재가 = 현재가;
            this.평가손익 = 평가손익;
            this.수익률 = 수익률;
        }
    }
}
