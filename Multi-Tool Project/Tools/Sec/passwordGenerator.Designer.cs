namespace Multi_Tool_Project.Tools.Sec
{
    partial class passwordGenerator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelLength = new Label();
            numericUpDownLength = new NumericUpDown();
            checkBoxIncludeSymbols = new CheckBox();
            buttonGenerate = new Button();
            textBoxPassword = new TextBox();
            btnExit = new Button();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            SuspendLayout();
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(12, 15);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(100, 15);
            labelLength.TabIndex = 0;
            labelLength.Text = "Password Length:";
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.Location = new Point(97, 13);
            numericUpDownLength.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(55, 23);
            numericUpDownLength.TabIndex = 1;
            numericUpDownLength.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // checkBoxIncludeSymbols
            // 
            checkBoxIncludeSymbols.AutoSize = true;
            checkBoxIncludeSymbols.Location = new Point(15, 48);
            checkBoxIncludeSymbols.Name = "checkBoxIncludeSymbols";
            checkBoxIncludeSymbols.Size = new Size(113, 19);
            checkBoxIncludeSymbols.TabIndex = 2;
            checkBoxIncludeSymbols.Text = "Include Symbols";
            checkBoxIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(15, 81);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(137, 23);
            buttonGenerate.TabIndex = 3;
            buttonGenerate.Text = "Generate Password";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(15, 118);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.ReadOnly = true;
            textBoxPassword.Size = new Size(230, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(193, 42);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 28);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(193, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 28);
            btnReturn.TabIndex = 12;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // passwordGenerator
            // 
            ClientSize = new Size(264, 161);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonGenerate);
            Controls.Add(checkBoxIncludeSymbols);
            Controls.Add(numericUpDownLength);
            Controls.Add(labelLength);
            Name = "passwordGenerator";
            Text = "Password Generator";
            Load += passwordGenerator_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.CheckBox checkBoxIncludeSymbols;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private Button btnExit;
        private Button btnReturn;
    }
}