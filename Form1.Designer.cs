namespace Currency_Converter
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.INTLCurrencyConverter = new System.Windows.Forms.Label();
            this.FromCurrencyBox = new System.Windows.Forms.ComboBox();
            this.lblFromCurrency = new System.Windows.Forms.Label();
            this.lblToCurrency = new System.Windows.Forms.Label();
            this.ToCurrencyBox = new System.Windows.Forms.ComboBox();
            this.lblAmountToConvert = new System.Windows.Forms.Label();
            this.RateDisplay = new System.Windows.Forms.Label();
            this.ConvertedAmountDisplay = new System.Windows.Forms.Label();
            this.AmountToConvertToBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(261, 332);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(265, 54);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "CONVERT";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // INTLCurrencyConverter
            // 
            this.INTLCurrencyConverter.AutoSize = true;
            this.INTLCurrencyConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTLCurrencyConverter.ForeColor = System.Drawing.Color.DarkRed;
            this.INTLCurrencyConverter.Location = new System.Drawing.Point(219, 20);
            this.INTLCurrencyConverter.Name = "INTLCurrencyConverter";
            this.INTLCurrencyConverter.Size = new System.Drawing.Size(389, 29);
            this.INTLCurrencyConverter.TabIndex = 1;
            this.INTLCurrencyConverter.Text = "International Currency Converter";
            // 
            // FromCurrencyBox
            // 
            this.FromCurrencyBox.FormattingEnabled = true;
            this.FromCurrencyBox.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "JPY",
            "LAK",
            "THB"});
            this.FromCurrencyBox.Location = new System.Drawing.Point(301, 242);
            this.FromCurrencyBox.Name = "FromCurrencyBox";
            this.FromCurrencyBox.Size = new System.Drawing.Size(201, 24);
            this.FromCurrencyBox.TabIndex = 2;
            // 
            // lblFromCurrency
            // 
            this.lblFromCurrency.AutoSize = true;
            this.lblFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromCurrency.Location = new System.Drawing.Point(328, 221);
            this.lblFromCurrency.Name = "lblFromCurrency";
            this.lblFromCurrency.Size = new System.Drawing.Size(134, 20);
            this.lblFromCurrency.TabIndex = 3;
            this.lblFromCurrency.Text = "From Currency";
            // 
            // lblToCurrency
            // 
            this.lblToCurrency.AutoSize = true;
            this.lblToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCurrency.Location = new System.Drawing.Point(335, 270);
            this.lblToCurrency.Name = "lblToCurrency";
            this.lblToCurrency.Size = new System.Drawing.Size(112, 20);
            this.lblToCurrency.TabIndex = 5;
            this.lblToCurrency.Text = "To Currency";
            // 
            // ToCurrencyBox
            // 
            this.ToCurrencyBox.FormattingEnabled = true;
            this.ToCurrencyBox.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "JPY",
            "LAK",
            "THB"});
            this.ToCurrencyBox.Location = new System.Drawing.Point(301, 291);
            this.ToCurrencyBox.Name = "ToCurrencyBox";
            this.ToCurrencyBox.Size = new System.Drawing.Size(201, 24);
            this.ToCurrencyBox.TabIndex = 4;
            // 
            // lblAmountToConvert
            // 
            this.lblAmountToConvert.AutoSize = true;
            this.lblAmountToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToConvert.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAmountToConvert.Location = new System.Drawing.Point(290, 151);
            this.lblAmountToConvert.Name = "lblAmountToConvert";
            this.lblAmountToConvert.Size = new System.Drawing.Size(212, 20);
            this.lblAmountToConvert.TabIndex = 7;
            this.lblAmountToConvert.Text = "AMOUNT TO CONVERT";
            // 
            // RateDisplay
            // 
            this.RateDisplay.AutoSize = true;
            this.RateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateDisplay.Location = new System.Drawing.Point(246, 64);
            this.RateDisplay.Name = "RateDisplay";
            this.RateDisplay.Size = new System.Drawing.Size(271, 20);
            this.RateDisplay.TabIndex = 8;
            this.RateDisplay.Text = "Conversion Rate: 1 UNIT = ___";
            // 
            // ConvertedAmountDisplay
            // 
            this.ConvertedAmountDisplay.AutoSize = true;
            this.ConvertedAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertedAmountDisplay.Location = new System.Drawing.Point(277, 100);
            this.ConvertedAmountDisplay.Name = "ConvertedAmountDisplay";
            this.ConvertedAmountDisplay.Size = new System.Drawing.Size(205, 20);
            this.ConvertedAmountDisplay.TabIndex = 9;
            this.ConvertedAmountDisplay.Text = "Converted Amount: ___";
            // 
            // AmountToConvertToBox
            // 
            this.AmountToConvertToBox.Location = new System.Drawing.Point(301, 174);
            this.AmountToConvertToBox.Name = "AmountToConvertToBox";
            this.AmountToConvertToBox.Size = new System.Drawing.Size(201, 22);
            this.AmountToConvertToBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AmountToConvertToBox);
            this.Controls.Add(this.ConvertedAmountDisplay);
            this.Controls.Add(this.RateDisplay);
            this.Controls.Add(this.lblAmountToConvert);
            this.Controls.Add(this.lblToCurrency);
            this.Controls.Add(this.ToCurrencyBox);
            this.Controls.Add(this.lblFromCurrency);
            this.Controls.Add(this.FromCurrencyBox);
            this.Controls.Add(this.INTLCurrencyConverter);
            this.Controls.Add(this.btn_Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label INTLCurrencyConverter;
        private System.Windows.Forms.ComboBox FromCurrencyBox;
        private System.Windows.Forms.Label lblFromCurrency;
        private System.Windows.Forms.Label lblToCurrency;
        private System.Windows.Forms.ComboBox ToCurrencyBox;
        private System.Windows.Forms.Label lblAmountToConvert;
        private System.Windows.Forms.Label RateDisplay;
        private System.Windows.Forms.Label ConvertedAmountDisplay;
        private System.Windows.Forms.TextBox AmountToConvertToBox;
    }
}

