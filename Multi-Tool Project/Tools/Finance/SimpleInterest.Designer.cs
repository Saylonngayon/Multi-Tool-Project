namespace Multi_Tool_Project.Tools.Finance
{
    partial class SimpleInterest
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
            btnExit = new Button();
            btnReturn = new Button();
            buttonCalculate = new Button();
            radioButtonMonthly = new RadioButton();
            radioButtonYearly = new RadioButton();
            radioButtonDaily = new RadioButton();
            textBoxRate = new TextBox();
            textBoxDeposit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelOutput = new Label();
            label4 = new Label();
            textBoxDays = new TextBox();
            textBoxMonths = new TextBox();
            textBoxYears = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 41);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(77, 397);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 41);
            btnReturn.TabIndex = 12;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(189, 59);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 14;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += btnConvert_Click;
            // 
            // radioButtonMonthly
            // 
            radioButtonMonthly.AutoSize = true;
            radioButtonMonthly.Location = new Point(132, 127);
            radioButtonMonthly.Name = "radioButtonMonthly";
            radioButtonMonthly.Size = new Size(70, 19);
            radioButtonMonthly.TabIndex = 15;
            radioButtonMonthly.TabStop = true;
            radioButtonMonthly.Text = "Monthly\r\n";
            radioButtonMonthly.UseVisualStyleBackColor = true;
            // 
            // radioButtonYearly
            // 
            radioButtonYearly.AutoSize = true;
            radioButtonYearly.Location = new Point(208, 127);
            radioButtonYearly.Name = "radioButtonYearly";
            radioButtonYearly.Size = new Size(56, 19);
            radioButtonYearly.TabIndex = 16;
            radioButtonYearly.TabStop = true;
            radioButtonYearly.Text = "Yearly";
            radioButtonYearly.UseVisualStyleBackColor = true;
            // 
            // radioButtonDaily
            // 
            radioButtonDaily.AutoSize = true;
            radioButtonDaily.Location = new Point(75, 127);
            radioButtonDaily.Name = "radioButtonDaily";
            radioButtonDaily.Size = new Size(51, 19);
            radioButtonDaily.TabIndex = 17;
            radioButtonDaily.TabStop = true;
            radioButtonDaily.Text = "Daily";
            radioButtonDaily.UseVisualStyleBackColor = true;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(132, 152);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(100, 23);
            textBoxRate.TabIndex = 18;
            // 
            // textBoxDeposit
            // 
            textBoxDeposit.Location = new Point(132, 181);
            textBoxDeposit.Name = "textBoxDeposit";
            textBoxDeposit.Size = new Size(100, 23);
            textBoxDeposit.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 152);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "Rate(%):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 181);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 21;
            label2.Text = "Deposit Amount:";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(440, 349);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(35, 15);
            labelOutput.TabIndex = 22;
            labelOutput.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 109);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 26;
            label4.Text = "Interest Calculation Type";
            // 
            // textBoxDays
            // 
            textBoxDays.Location = new Point(132, 220);
            textBoxDays.Name = "textBoxDays";
            textBoxDays.Size = new Size(100, 23);
            textBoxDays.TabIndex = 31;
            // 
            // textBoxMonths
            // 
            textBoxMonths.Location = new Point(132, 260);
            textBoxMonths.Name = "textBoxMonths";
            textBoxMonths.Size = new Size(100, 23);
            textBoxMonths.TabIndex = 32;
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(132, 296);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.Size = new Size(100, 23);
            textBoxYears.TabIndex = 33;
            // 
            // SimpleInterest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxYears);
            Controls.Add(textBoxMonths);
            Controls.Add(textBoxDays);
            Controls.Add(label4);
            Controls.Add(labelOutput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDeposit);
            Controls.Add(textBoxRate);
            Controls.Add(radioButtonDaily);
            Controls.Add(radioButtonYearly);
            Controls.Add(radioButtonMonthly);
            Controls.Add(buttonCalculate);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Name = "SimpleInterest";
            Text = "SimpleInterest";
            Load += SimpleInterest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnReturn;
        private Button buttonCalculate;
        private RadioButton radioButtonMonthly;
        private RadioButton radioButtonYearly;
        private RadioButton radioButtonDaily;
        private TextBox textBoxRate;
        private TextBox textBoxDeposit;
        private Label label1;
        private Label label2;
        private Label labelOutput;
        private Label label4;
        private TextBox textBoxDays;
        private TextBox textBoxMonths;
        private TextBox textBoxYears;
    }
}