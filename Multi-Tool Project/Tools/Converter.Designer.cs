namespace Multi_Tool_Project.Tools
{
    partial class Converter
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
            convertButton = new Button();
            comboBoxUnitTo = new ComboBox();
            comboBoxUnitFrom = new ComboBox();
            textBoxInput = new TextBox();
            comboBoxUnitType = new ComboBox();
            textBoxOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // convertButton
            // 
            convertButton.Location = new Point(164, 36);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(121, 23);
            convertButton.TabIndex = 0;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // comboBoxUnitTo
            // 
            comboBoxUnitTo.FormattingEnabled = true;
            comboBoxUnitTo.Location = new Point(164, 88);
            comboBoxUnitTo.Name = "comboBoxUnitTo";
            comboBoxUnitTo.Size = new Size(121, 23);
            comboBoxUnitTo.TabIndex = 1;
            // 
            // comboBoxUnitFrom
            // 
            comboBoxUnitFrom.FormattingEnabled = true;
            comboBoxUnitFrom.Location = new Point(12, 88);
            comboBoxUnitFrom.Name = "comboBoxUnitFrom";
            comboBoxUnitFrom.Size = new Size(121, 23);
            comboBoxUnitFrom.TabIndex = 2;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 140);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(121, 23);
            textBoxInput.TabIndex = 3;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // comboBoxUnitType
            // 
            comboBoxUnitType.FormattingEnabled = true;
            comboBoxUnitType.Location = new Point(12, 36);
            comboBoxUnitType.Name = "comboBoxUnitType";
            comboBoxUnitType.Size = new Size(121, 23);
            comboBoxUnitType.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(164, 140);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(121, 23);
            textBoxOutput.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Select Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 70);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 9;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 122);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 10;
            label4.Text = "Output:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 122);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "Input:";
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxOutput);
            Controls.Add(comboBoxUnitType);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxUnitFrom);
            Controls.Add(comboBoxUnitTo);
            Controls.Add(convertButton);
            Name = "Converter";
            Text = "Converter";
            Load += Converter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertButton;
        private ComboBox comboBoxUnitTo;
        private ComboBox comboBoxUnitFrom;
        private TextBox textBoxInput;
        private ComboBox comboBoxUnitType;
        private TextBox textBoxOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}