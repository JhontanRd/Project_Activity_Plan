namespace ActivityPlan
{
    partial class FStartScreen
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
            PtbDocument = new PictureBox();
            BtnSign = new Button();
            BtnGetStarted = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PtbDocument).BeginInit();
            SuspendLayout();
            // 
            // PtbDocument
            // 
            PtbDocument.BorderStyle = BorderStyle.FixedSingle;
            PtbDocument.Image = Properties.Resources.Documento;
            PtbDocument.Location = new Point(179, 59);
            PtbDocument.Name = "PtbDocument";
            PtbDocument.Size = new Size(80, 67);
            PtbDocument.SizeMode = PictureBoxSizeMode.StretchImage;
            PtbDocument.TabIndex = 0;
            PtbDocument.TabStop = false;
            // 
            // BtnSign
            // 
            BtnSign.BackColor = SystemColors.Info;
            BtnSign.FlatStyle = FlatStyle.Popup;
            BtnSign.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnSign.Location = new Point(173, 174);
            BtnSign.Name = "BtnSign";
            BtnSign.Size = new Size(89, 29);
            BtnSign.TabIndex = 1;
            BtnSign.Text = "Sign In";
            BtnSign.UseVisualStyleBackColor = false;
            // 
            // BtnGetStarted
            // 
            BtnGetStarted.BackColor = SystemColors.Info;
            BtnGetStarted.FlatStyle = FlatStyle.Popup;
            BtnGetStarted.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnGetStarted.Location = new Point(159, 208);
            BtnGetStarted.Name = "BtnGetStarted";
            BtnGetStarted.Size = new Size(116, 29);
            BtnGetStarted.TabIndex = 2;
            BtnGetStarted.Text = "Get Started";
            BtnGetStarted.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9F, FontStyle.Italic);
            label1.Location = new Point(380, 307);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 3;
            label1.Text = "V 0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            label2.Location = new Point(139, 24);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 4;
            label2.Text = "Activity Plan System";
            // 
            // FStartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(434, 331);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGetStarted);
            Controls.Add(BtnSign);
            Controls.Add(PtbDocument);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(450, 370);
            MinimumSize = new Size(450, 370);
            Name = "FStartScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Activity Plan";
            ((System.ComponentModel.ISupportInitialize)PtbDocument).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PtbDocument;
        private Button BtnSign;
        private Button BtnGetStarted;
        private Label label1;
        private Label label2;
    }
}
