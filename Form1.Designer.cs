using System.Drawing;
using System.Runtime.CompilerServices;

namespace Teira3D
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.subMenu1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.subMenu2 = new System.Windows.Forms.Button();
            this.pnGuide = new System.Windows.Forms.Panel();
            this.buttonUserGuide = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.pnContact = new System.Windows.Forms.Panel();
            this.buttonContact = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCleaning = new System.Windows.Forms.Button();
            this.pnErrors = new System.Windows.Forms.Panel();
            this.buttonErrors = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnGuarantee = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnGuide.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnContact.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnErrors.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnHam
            // 
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(0, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(53, 50);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1016, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnGuide);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Controls.Add(this.pnContact);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.pnErrors);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 50);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(238, 547);
            this.sidebar.TabIndex = 1;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(219, 53);
            this.menuContainer.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 53);
            this.panel2.TabIndex = 3;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(-27, -12);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.menu.Size = new System.Drawing.Size(278, 91);
            this.menu.TabIndex = 2;
            this.menu.Text = "               Yazıcı Hakkında";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.subMenu1);
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 53);
            this.panel3.TabIndex = 4;
            // 
            // subMenu1
            // 
            this.subMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.subMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subMenu1.ForeColor = System.Drawing.Color.White;
            this.subMenu1.Image = ((System.Drawing.Image)(resources.GetObject("subMenu1.Image")));
            this.subMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenu1.Location = new System.Drawing.Point(-27, -12);
            this.subMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.subMenu1.Name = "subMenu1";
            this.subMenu1.Padding = new System.Windows.Forms.Padding(37, 0, 0, 17);
            this.subMenu1.Size = new System.Drawing.Size(278, 91);
            this.subMenu1.TabIndex = 2;
            this.subMenu1.Text = "             Yazıcı Özellikleri";
            this.subMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenu1.UseVisualStyleBackColor = false;
            this.subMenu1.Click += new System.EventHandler(this.subMenu1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.subMenu2);
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 53);
            this.panel4.TabIndex = 5;
            // 
            // subMenu2
            // 
            this.subMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.subMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenu2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subMenu2.ForeColor = System.Drawing.Color.White;
            this.subMenu2.Image = ((System.Drawing.Image)(resources.GetObject("subMenu2.Image")));
            this.subMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenu2.Location = new System.Drawing.Point(-27, -12);
            this.subMenu2.Margin = new System.Windows.Forms.Padding(0);
            this.subMenu2.Name = "subMenu2";
            this.subMenu2.Padding = new System.Windows.Forms.Padding(37, 0, 0, 17);
            this.subMenu2.Size = new System.Drawing.Size(278, 91);
            this.subMenu2.TabIndex = 2;
            this.subMenu2.Text = "             Güvenlik ve Uyarılar";
            this.subMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenu2.UseVisualStyleBackColor = false;
            this.subMenu2.Click += new System.EventHandler(this.subMenu2_Click);
            // 
            // pnGuide
            // 
            this.pnGuide.BackColor = System.Drawing.Color.White;
            this.pnGuide.Controls.Add(this.buttonUserGuide);
            this.pnGuide.Location = new System.Drawing.Point(0, 53);
            this.pnGuide.Margin = new System.Windows.Forms.Padding(0);
            this.pnGuide.Name = "pnGuide";
            this.pnGuide.Size = new System.Drawing.Size(219, 53);
            this.pnGuide.TabIndex = 10;
            // 
            // buttonUserGuide
            // 
            this.buttonUserGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonUserGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserGuide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonUserGuide.FlatAppearance.BorderSize = 0;
            this.buttonUserGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserGuide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUserGuide.ForeColor = System.Drawing.Color.White;
            this.buttonUserGuide.Image = ((System.Drawing.Image)(resources.GetObject("buttonUserGuide.Image")));
            this.buttonUserGuide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserGuide.Location = new System.Drawing.Point(-27, -12);
            this.buttonUserGuide.Name = "buttonUserGuide";
            this.buttonUserGuide.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.buttonUserGuide.Size = new System.Drawing.Size(274, 91);
            this.buttonUserGuide.TabIndex = 2;
            this.buttonUserGuide.Text = "               Ambalaj ve Başlangıç";
            this.buttonUserGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserGuide.UseVisualStyleBackColor = false;
            this.buttonUserGuide.Click += new System.EventHandler(this.buttonUserGuide_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.pnAbout.Controls.Add(this.buttonInfo);
            this.pnAbout.Location = new System.Drawing.Point(0, 106);
            this.pnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(219, 53);
            this.pnAbout.TabIndex = 6;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.Location = new System.Drawing.Point(-27, -12);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.buttonInfo.Size = new System.Drawing.Size(278, 91);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "               Kullanım Kılavuzu";
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // pnContact
            // 
            this.pnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.pnContact.Controls.Add(this.buttonContact);
            this.pnContact.Location = new System.Drawing.Point(0, 159);
            this.pnContact.Margin = new System.Windows.Forms.Padding(0);
            this.pnContact.Name = "pnContact";
            this.pnContact.Size = new System.Drawing.Size(219, 53);
            this.pnContact.TabIndex = 8;
            // 
            // buttonContact
            // 
            this.buttonContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonContact.FlatAppearance.BorderSize = 0;
            this.buttonContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonContact.ForeColor = System.Drawing.Color.White;
            this.buttonContact.Image = ((System.Drawing.Image)(resources.GetObject("buttonContact.Image")));
            this.buttonContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContact.Location = new System.Drawing.Point(-27, -9);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.buttonContact.Size = new System.Drawing.Size(274, 91);
            this.buttonContact.TabIndex = 2;
            this.buttonContact.Text = "               Kalibrasyon";
            this.buttonContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContact.UseVisualStyleBackColor = false;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.panel6.Controls.Add(this.btnCleaning);
            this.panel6.Location = new System.Drawing.Point(0, 212);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(219, 53);
            this.panel6.TabIndex = 11;
            // 
            // btnCleaning
            // 
            this.btnCleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btnCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleaning.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btnCleaning.FlatAppearance.BorderSize = 0;
            this.btnCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleaning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCleaning.ForeColor = System.Drawing.Color.White;
            this.btnCleaning.Image = ((System.Drawing.Image)(resources.GetObject("btnCleaning.Image")));
            this.btnCleaning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCleaning.Location = new System.Drawing.Point(-27, -9);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.btnCleaning.Size = new System.Drawing.Size(274, 91);
            this.btnCleaning.TabIndex = 2;
            this.btnCleaning.Text = "               Bakım ve Temizlik";
            this.btnCleaning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCleaning.UseVisualStyleBackColor = false;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // pnErrors
            // 
            this.pnErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.pnErrors.Controls.Add(this.buttonErrors);
            this.pnErrors.Location = new System.Drawing.Point(0, 265);
            this.pnErrors.Margin = new System.Windows.Forms.Padding(0);
            this.pnErrors.Name = "pnErrors";
            this.pnErrors.Size = new System.Drawing.Size(219, 53);
            this.pnErrors.TabIndex = 9;
            // 
            // buttonErrors
            // 
            this.buttonErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonErrors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonErrors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonErrors.FlatAppearance.BorderSize = 0;
            this.buttonErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonErrors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonErrors.ForeColor = System.Drawing.Color.White;
            this.buttonErrors.Image = ((System.Drawing.Image)(resources.GetObject("buttonErrors.Image")));
            this.buttonErrors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonErrors.Location = new System.Drawing.Point(-27, -12);
            this.buttonErrors.Name = "buttonErrors";
            this.buttonErrors.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.buttonErrors.Size = new System.Drawing.Size(274, 91);
            this.buttonErrors.TabIndex = 2;
            this.buttonErrors.Text = "               Hata Kodları";
            this.buttonErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonErrors.UseVisualStyleBackColor = false;
            this.buttonErrors.Click += new System.EventHandler(this.buttonErrors_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.panel7.Controls.Add(this.btnGuarantee);
            this.panel7.Location = new System.Drawing.Point(0, 318);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 53);
            this.panel7.TabIndex = 11;
            // 
            // btnGuarantee
            // 
            this.btnGuarantee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btnGuarantee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuarantee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btnGuarantee.FlatAppearance.BorderSize = 0;
            this.btnGuarantee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuarantee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuarantee.ForeColor = System.Drawing.Color.White;
            this.btnGuarantee.Image = ((System.Drawing.Image)(resources.GetObject("btnGuarantee.Image")));
            this.btnGuarantee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuarantee.Location = new System.Drawing.Point(-27, -9);
            this.btnGuarantee.Name = "btnGuarantee";
            this.btnGuarantee.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.btnGuarantee.Size = new System.Drawing.Size(274, 91);
            this.btnGuarantee.TabIndex = 2;
            this.btnGuarantee.Text = "               Garanti";
            this.btnGuarantee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuarantee.UseVisualStyleBackColor = false;
            this.btnGuarantee.Click += new System.EventHandler(this.btnGuarantee_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.panel8.Controls.Add(this.btnDictionary);
            this.panel8.Location = new System.Drawing.Point(0, 371);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(219, 53);
            this.panel8.TabIndex = 11;
            // 
            // btnDictionary
            // 
            this.btnDictionary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btnDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDictionary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btnDictionary.FlatAppearance.BorderSize = 0;
            this.btnDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDictionary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDictionary.ForeColor = System.Drawing.Color.White;
            this.btnDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnDictionary.Image")));
            this.btnDictionary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDictionary.Location = new System.Drawing.Point(-27, -9);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.btnDictionary.Size = new System.Drawing.Size(274, 91);
            this.btnDictionary.TabIndex = 2;
            this.btnDictionary.Text = "               Sözlük";
            this.btnDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDictionary.UseVisualStyleBackColor = false;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.panel5.Controls.Add(this.buttonCalibration);
            this.panel5.Location = new System.Drawing.Point(0, 424);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 53);
            this.panel5.TabIndex = 10;
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonCalibration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalibration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.buttonCalibration.FlatAppearance.BorderSize = 0;
            this.buttonCalibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalibration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCalibration.ForeColor = System.Drawing.Color.White;
            this.buttonCalibration.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalibration.Image")));
            this.buttonCalibration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalibration.Location = new System.Drawing.Point(-27, -9);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Padding = new System.Windows.Forms.Padding(25, 0, 0, 17);
            this.buttonCalibration.Size = new System.Drawing.Size(274, 91);
            this.buttonCalibration.TabIndex = 2;
            this.buttonCalibration.Text = "               İletişim";
            this.buttonCalibration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalibration.UseVisualStyleBackColor = false;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1155, 597);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnGuide.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnContact.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnErrors.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button subMenu1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button subMenu2;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel pnContact;
        private System.Windows.Forms.Button buttonContact;
        private System.Windows.Forms.Panel pnErrors;
        private System.Windows.Forms.Button buttonErrors;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnGuide;
        private System.Windows.Forms.Button buttonUserGuide;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonCalibration;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCleaning;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnGuarantee;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDictionary;
    }
}

