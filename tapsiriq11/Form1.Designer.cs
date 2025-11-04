namespace tapsiriq11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnYeniOyun = new Button();
            btnPanelYarat = new Button();
            lblPanelSay = new Label();
            txtPanelSay = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.BackColor = Color.FromArgb(0, 192, 192);
            btnYeniOyun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYeniOyun.ImageAlign = ContentAlignment.MiddleRight;
            btnYeniOyun.Location = new Point(28, 362);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(118, 45);
            btnYeniOyun.TabIndex = 1;
            btnYeniOyun.Text = "Yeni oyun";
            btnYeniOyun.UseVisualStyleBackColor = false;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // btnPanelYarat
            // 
            btnPanelYarat.BackColor = Color.Teal;
            btnPanelYarat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPanelYarat.ImageAlign = ContentAlignment.MiddleRight;
            btnPanelYarat.Location = new Point(208, 362);
            btnPanelYarat.Name = "btnPanelYarat";
            btnPanelYarat.Size = new Size(118, 45);
            btnPanelYarat.TabIndex = 2;
            btnPanelYarat.Text = "Panel yarat";
            btnPanelYarat.UseVisualStyleBackColor = false;
            btnPanelYarat.Click += btnPanelYarat_Click;
            // 
            // lblPanelSay
            // 
            lblPanelSay.AutoSize = true;
            lblPanelSay.Location = new Point(453, 374);
            lblPanelSay.Name = "lblPanelSay";
            lblPanelSay.Size = new Size(73, 20);
            lblPanelSay.TabIndex = 3;
            lblPanelSay.Text = "Panel sayi";
            // 
            // txtPanelSay
            // 
            txtPanelSay.Location = new Point(543, 372);
            txtPanelSay.Name = "txtPanelSay";
            txtPanelSay.Size = new Size(125, 27);
            txtPanelSay.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(707, 478);
            Controls.Add(txtPanelSay);
            Controls.Add(lblPanelSay);
            Controls.Add(btnPanelYarat);
            Controls.Add(btnYeniOyun);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            PreviewKeyDown += Form1_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnYeniOyun;
        private Button btnPanelYarat;
        private Label lblPanelSay;
        private TextBox txtPanelSay;
    }
}
