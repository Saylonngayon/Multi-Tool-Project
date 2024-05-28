namespace Multi_Tool_Project.Tools.Finance
{
    partial class currencyExchange
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
            btnConvert = new Button();
            cmbTargetCurrency = new ComboBox();
            cmbBaseCurrency = new ComboBox();
            txtAmount = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(79, 12);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // cmbTargetCurrency
            // 
            cmbTargetCurrency.FormattingEnabled = true;
            cmbTargetCurrency.Location = new Point(592, 277);
            cmbTargetCurrency.Name = "cmbTargetCurrency";
            cmbTargetCurrency.Size = new Size(121, 28);
            cmbTargetCurrency.TabIndex = 1;
            // 
            // cmbBaseCurrency
            // 
            cmbBaseCurrency.FormattingEnabled = true;
            cmbBaseCurrency.Location = new Point(156, 164);
            cmbBaseCurrency.Name = "cmbBaseCurrency";
            cmbBaseCurrency.Size = new Size(121, 28);
            cmbBaseCurrency.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(368, 68);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(175, 27);
            txtAmount.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(59, 254);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(45, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 146);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 259);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 6;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 50);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Amount";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(359, 241);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 41);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(424, 241);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 41);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // currencyExchange
            // 
            ClientSize = new Size(982, 653);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(txtAmount);
            Controls.Add(cmbBaseCurrency);
            Controls.Add(cmbTargetCurrency);
            Controls.Add(btnConvert);
            Name = "currencyExchange";
            Load += currencyExchange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private ComboBox cmbTargetCurrency;
        private ComboBox cmbBaseCurrency;
        private TextBox txtAmount;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExit;
        private Button btnReturn;
    }
}