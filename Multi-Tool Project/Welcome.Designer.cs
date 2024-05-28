namespace Multi_Tool_Project
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProceed = new Button();
            label1 = new Label();
            btnCredits = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.LightGray;
            btnProceed.FlatAppearance.BorderSize = 0;
            btnProceed.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(261, 287);
            btnProceed.Margin = new Padding(4, 4, 4, 4);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(190, 76);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(134, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(686, 114);
            label1.TabIndex = 1;
            label1.Text = "TOOLGETHER";
            label1.Click += label1_Click;
            // 
            // btnCredits
            // 
            btnCredits.BackColor = Color.LightGray;
            btnCredits.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCredits.Location = new Point(549, 287);
            btnCredits.Margin = new Padding(4, 4, 4, 4);
            btnCredits.Name = "btnCredits";
            btnCredits.Size = new Size(190, 76);
            btnCredits.TabIndex = 2;
            btnCredits.Text = "Credits";
            btnCredits.UseVisualStyleBackColor = false;
            btnCredits.Click += btnCredits_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightGray;
            btnExit.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(407, 408);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 76);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(4, 4, 4);
            BackgroundImage = Properties.Resources._01552de72f63684976759deb3a7770bb;
            ClientSize = new Size(982, 653);
            Controls.Add(btnExit);
            Controls.Add(btnCredits);
            Controls.Add(label1);
            Controls.Add(btnProceed);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TOOLGETHER";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProceed;
        private Label label1;
        private Button btnCredits;
        private Button btnExit;
    }
}
