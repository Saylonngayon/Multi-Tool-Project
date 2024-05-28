namespace Multi_Tool_Project.Tools.Sec
{
    partial class Cryptography
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
            textBoxInput = new TextBox();
            textBoxKey = new TextBox();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            textBoxOutput = new TextBox();
            labelInput = new Label();
            labelKey = new Label();
            labelOutput = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 25);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(360, 80);
            textBoxInput.TabIndex = 0;
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(12, 130);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(360, 23);
            textBoxKey.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(12, 170);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(75, 23);
            buttonEncrypt.TabIndex = 2;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(297, 170);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(75, 23);
            buttonDecrypt.TabIndex = 3;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(12, 210);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(360, 80);
            textBoxOutput.TabIndex = 4;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(12, 9);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(38, 15);
            labelInput.TabIndex = 5;
            labelInput.Text = "Input:";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new Point(12, 114);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(29, 15);
            labelKey.TabIndex = 6;
            labelKey.Text = "Key:";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(12, 194);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(48, 15);
            labelOutput.TabIndex = 7;
            labelOutput.Text = "Output:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(196, 176);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 28);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(196, 146);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 28);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // Cryptography
            // 
            ClientSize = new Size(384, 311);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(labelOutput);
            Controls.Add(labelKey);
            Controls.Add(labelInput);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonEncrypt);
            Controls.Add(textBoxKey);
            Controls.Add(textBoxInput);
            Name = "Cryptography";
            Text = "Cryptography App";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelOutput;
        private Button btnExit;
        private Button btnReturn;
    }
}