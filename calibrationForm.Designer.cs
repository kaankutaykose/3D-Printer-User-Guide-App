namespace Teira3D
{
    partial class calibrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calibrationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLinkLabel1 = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1186, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.Red;
            this.dungeonLabel1.Location = new System.Drawing.Point(12, 374);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(101, 31);
            this.dungeonLabel1.TabIndex = 1;
            this.dungeonLabel1.Text = "İletişim :";
            // 
            // dungeonLinkLabel1
            // 
            this.dungeonLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.dungeonLinkLabel1.AutoSize = true;
            this.dungeonLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dungeonLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.dungeonLinkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.dungeonLinkLabel1.Location = new System.Drawing.Point(110, 380);
            this.dungeonLinkLabel1.Name = "dungeonLinkLabel1";
            this.dungeonLinkLabel1.Size = new System.Drawing.Size(165, 25);
            this.dungeonLinkLabel1.TabIndex = 3;
            this.dungeonLinkLabel1.TabStop = true;
            this.dungeonLinkLabel1.Text = "+90 552 424 11 08";
            this.dungeonLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dungeonLabel2.ForeColor = System.Drawing.Color.Red;
            this.dungeonLabel2.Location = new System.Drawing.Point(12, 443);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(86, 31);
            this.dungeonLabel2.TabIndex = 4;
            this.dungeonLabel2.Text = "Adres :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(104, 445);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(879, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Bilişim Vadisi, Muallimköy Mh. Deniz Cad. No:143/5 B1 Blok Kristal Bina Kat:3 Geb" +
    "ze/KOCAELİ.";
            // 
            // calibrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1186, 671);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dungeonLabel2);
            this.Controls.Add(this.dungeonLinkLabel1);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calibrationForm";
            this.Text = "calibrationForm";
            this.Load += new System.EventHandler(this.calibrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLinkLabel dungeonLinkLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}