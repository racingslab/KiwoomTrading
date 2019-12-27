namespace KiwoomTrading
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.conditionDataGridView = new System.Windows.Forms.DataGridView();
            this.조건식_조건식번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건식_조건식이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.조건검색_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건검색_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건검색_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건검색_전일대비 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건검색_등락율 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건검색_거래량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.search_button = new System.Windows.Forms.Button();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.balance_button = new System.Windows.Forms.Button();
            this.잔고_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_보유수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_매입금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_손익금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_손익율 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionDataGridView
            // 
            this.conditionDataGridView.AllowUserToAddRows = false;
            this.conditionDataGridView.AllowUserToDeleteRows = false;
            this.conditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conditionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.조건식_조건식번호,
            this.조건식_조건식이름});
            this.conditionDataGridView.Location = new System.Drawing.Point(12, 12);
            this.conditionDataGridView.Name = "conditionDataGridView";
            this.conditionDataGridView.RowHeadersVisible = false;
            this.conditionDataGridView.RowHeadersWidth = 51;
            this.conditionDataGridView.RowTemplate.Height = 27;
            this.conditionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conditionDataGridView.Size = new System.Drawing.Size(228, 274);
            this.conditionDataGridView.TabIndex = 0;
            // 
            // 조건식_조건식번호
            // 
            this.조건식_조건식번호.HeaderText = "조건식번호";
            this.조건식_조건식번호.MinimumWidth = 6;
            this.조건식_조건식번호.Name = "조건식_조건식번호";
            this.조건식_조건식번호.Width = 110;
            // 
            // 조건식_조건식이름
            // 
            this.조건식_조건식이름.HeaderText = "조건식이름";
            this.조건식_조건식이름.MinimumWidth = 6;
            this.조건식_조건식이름.Name = "조건식_조건식이름";
            this.조건식_조건식이름.Width = 110;
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.조건검색_종목코드,
            this.조건검색_종목명,
            this.조건검색_현재가,
            this.조건검색_전일대비,
            this.조건검색_등락율,
            this.조건검색_거래량});
            this.stockDataGridView.Location = new System.Drawing.Point(246, 12);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.RowHeadersWidth = 51;
            this.stockDataGridView.RowTemplate.Height = 27;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(695, 274);
            this.stockDataGridView.TabIndex = 1;
            // 
            // 조건검색_종목코드
            // 
            this.조건검색_종목코드.HeaderText = "종목코드";
            this.조건검색_종목코드.MinimumWidth = 6;
            this.조건검색_종목코드.Name = "조건검색_종목코드";
            this.조건검색_종목코드.Width = 125;
            // 
            // 조건검색_종목명
            // 
            this.조건검색_종목명.HeaderText = "종목명";
            this.조건검색_종목명.MinimumWidth = 6;
            this.조건검색_종목명.Name = "조건검색_종목명";
            this.조건검색_종목명.Width = 125;
            // 
            // 조건검색_현재가
            // 
            this.조건검색_현재가.HeaderText = "현재가";
            this.조건검색_현재가.MinimumWidth = 6;
            this.조건검색_현재가.Name = "조건검색_현재가";
            this.조건검색_현재가.Width = 125;
            // 
            // 조건검색_전일대비
            // 
            this.조건검색_전일대비.HeaderText = "전일대비";
            this.조건검색_전일대비.MinimumWidth = 6;
            this.조건검색_전일대비.Name = "조건검색_전일대비";
            this.조건검색_전일대비.Width = 125;
            // 
            // 조건검색_등락율
            // 
            this.조건검색_등락율.HeaderText = "등락율";
            this.조건검색_등락율.MinimumWidth = 6;
            this.조건검색_등락율.Name = "조건검색_등락율";
            this.조건검색_등락율.Width = 125;
            // 
            // 조건검색_거래량
            // 
            this.조건검색_거래량.HeaderText = "거래량";
            this.조건검색_거래량.MinimumWidth = 6;
            this.조건검색_거래량.Name = "조건검색_거래량";
            this.조건검색_거래량.Width = 125;
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(12, 472);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 2;
            this.axKHOpenAPI1.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.AxKHOpenAPI1_OnReceiveTrData);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(12, 304);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "검색";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.AllowUserToAddRows = false;
            this.balanceDataGridView.AllowUserToDeleteRows = false;
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.잔고_종목코드,
            this.잔고_종목명,
            this.잔고_보유수량,
            this.잔고_매입금액,
            this.잔고_현재가,
            this.잔고_손익금액,
            this.잔고_손익율});
            this.balanceDataGridView.Location = new System.Drawing.Point(246, 304);
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.RowHeadersVisible = false;
            this.balanceDataGridView.RowHeadersWidth = 51;
            this.balanceDataGridView.RowTemplate.Height = 27;
            this.balanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.balanceDataGridView.Size = new System.Drawing.Size(691, 218);
            this.balanceDataGridView.TabIndex = 4;
            // 
            // balance_button
            // 
            this.balance_button.Location = new System.Drawing.Point(128, 304);
            this.balance_button.Name = "balance_button";
            this.balance_button.Size = new System.Drawing.Size(75, 23);
            this.balance_button.TabIndex = 5;
            this.balance_button.Text = "잔고조회";
            this.balance_button.UseVisualStyleBackColor = true;
            this.balance_button.Click += new System.EventHandler(this.Balance_button_Click);
            // 
            // 잔고_종목코드
            // 
            this.잔고_종목코드.HeaderText = "종목코드";
            this.잔고_종목코드.MinimumWidth = 6;
            this.잔고_종목코드.Name = "잔고_종목코드";
            this.잔고_종목코드.Width = 125;
            // 
            // 잔고_종목명
            // 
            this.잔고_종목명.HeaderText = "종목명";
            this.잔고_종목명.MinimumWidth = 6;
            this.잔고_종목명.Name = "잔고_종목명";
            this.잔고_종목명.Width = 125;
            // 
            // 잔고_보유수량
            // 
            this.잔고_보유수량.HeaderText = "보유수량";
            this.잔고_보유수량.MinimumWidth = 6;
            this.잔고_보유수량.Name = "잔고_보유수량";
            this.잔고_보유수량.Width = 125;
            // 
            // 잔고_매입금액
            // 
            this.잔고_매입금액.HeaderText = "매입금액";
            this.잔고_매입금액.MinimumWidth = 6;
            this.잔고_매입금액.Name = "잔고_매입금액";
            this.잔고_매입금액.Width = 125;
            // 
            // 잔고_현재가
            // 
            this.잔고_현재가.HeaderText = "현재가";
            this.잔고_현재가.MinimumWidth = 6;
            this.잔고_현재가.Name = "잔고_현재가";
            this.잔고_현재가.Width = 125;
            // 
            // 잔고_손익금액
            // 
            this.잔고_손익금액.HeaderText = "손익금액";
            this.잔고_손익금액.MinimumWidth = 6;
            this.잔고_손익금액.Name = "잔고_손익금액";
            this.잔고_손익금액.Width = 125;
            // 
            // 잔고_손익율
            // 
            this.잔고_손익율.HeaderText = "손익율";
            this.잔고_손익율.MinimumWidth = 6;
            this.잔고_손익율.Name = "잔고_손익율";
            this.잔고_손익율.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 534);
            this.Controls.Add(this.balance_button);
            this.Controls.Add(this.balanceDataGridView);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.conditionDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView conditionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건식_조건식번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건식_조건식이름;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건검색_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건검색_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건검색_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건검색_전일대비;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건검색_등락율;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건검색_거래량;
        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.Button balance_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_보유수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_매입금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_손익금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_손익율;
    }
}

