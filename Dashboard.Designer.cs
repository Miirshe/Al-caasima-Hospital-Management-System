
namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrintUser = new System.Windows.Forms.Label();
            this.lblPrintName = new System.Windows.Forms.Label();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.Logout = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnPharmacy = new Guna.UI2.WinForms.Guna2Button();
            this.btnResultDiagnosis = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiagnosis = new Guna.UI2.WinForms.Guna2Button();
            this.btnDocAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnReception = new Guna.UI2.WinForms.Guna2Button();
            this.btnNurse = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.printAll1 = new WindowsFormsApp1.PrintAll();
            this.home1 = new WindowsFormsApp1.Home();
            this.pharmacy1 = new WindowsFormsApp1.Pharmacy();
            this.re_diagnosis1 = new WindowsFormsApp1.Re_diagnosis();
            this.diagnosis1 = new WindowsFormsApp1.Diagnosis();
            this.docApp1 = new WindowsFormsApp1.DocApp();
            this.appointment1 = new WindowsFormsApp1.Appointment();
            this.patient1 = new WindowsFormsApp1.Patient();
            this.reception1 = new WindowsFormsApp1.Reception();
            this.nurse1 = new WindowsFormsApp1.Nurse();
            this.doctor1 = new WindowsFormsApp1.Doctor();
            this.admin1 = new WindowsFormsApp1.Admin();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.Controls.Add(this.button2);
            this.guna2Panel2.Controls.Add(this.button1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1386, 80);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.lblPrintUser);
            this.panel1.Controls.Add(this.lblPrintName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-24, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 80);
            this.panel1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeProfileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 30);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // changeProfileToolStripMenuItem
            // 
            this.changeProfileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.changeProfileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeProfileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeProfileToolStripMenuItem.Name = "changeProfileToolStripMenuItem";
            this.changeProfileToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.changeProfileToolStripMenuItem.Text = "Change Profile";
            this.changeProfileToolStripMenuItem.Click += new System.EventHandler(this.changeProfileToolStripMenuItem_Click);
            // 
            // lblPrintUser
            // 
            this.lblPrintUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrintUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.lblPrintUser.Location = new System.Drawing.Point(127, 36);
            this.lblPrintUser.Name = "lblPrintUser";
            this.lblPrintUser.Size = new System.Drawing.Size(100, 24);
            this.lblPrintUser.TabIndex = 4;
            this.lblPrintUser.Text = "TYpe";
            this.lblPrintUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrintName
            // 
            this.lblPrintName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrintName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintName.ForeColor = System.Drawing.Color.White;
            this.lblPrintName.Location = new System.Drawing.Point(127, 12);
            this.lblPrintName.Name = "lblPrintName";
            this.lblPrintName.Size = new System.Drawing.Size(100, 24);
            this.lblPrintName.TabIndex = 3;
            this.lblPrintName.Text = "username";
            this.lblPrintName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox1.ShadowDecoration.Parent = this.pictureBox1;
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(454, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "AL ASSIMA HOSPITAL MANAGMENT SYSTEM";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(57, -55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(550, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.macos_minimize_32px;
            this.button2.Location = new System.Drawing.Point(1245, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 38);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(1306, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.SideBar.Controls.Add(this.Logout);
            this.SideBar.Controls.Add(this.btnReport);
            this.SideBar.Controls.Add(this.btnPharmacy);
            this.SideBar.Controls.Add(this.btnResultDiagnosis);
            this.SideBar.Controls.Add(this.btnDiagnosis);
            this.SideBar.Controls.Add(this.btnDocAppointment);
            this.SideBar.Controls.Add(this.btnAppointment);
            this.SideBar.Controls.Add(this.btnPatient);
            this.SideBar.Controls.Add(this.btnReception);
            this.SideBar.Controls.Add(this.btnNurse);
            this.SideBar.Controls.Add(this.btnDoctor);
            this.SideBar.Controls.Add(this.btnAdmin);
            this.SideBar.Controls.Add(this.btnHome);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.SideBar.Location = new System.Drawing.Point(0, 80);
            this.SideBar.Name = "SideBar";
            this.SideBar.ShadowDecoration.Parent = this.SideBar;
            this.SideBar.Size = new System.Drawing.Size(212, 708);
            this.SideBar.TabIndex = 13;
            // 
            // Logout
            // 
            this.Logout.BorderRadius = 8;
            this.Logout.CheckedState.Parent = this.Logout;
            this.Logout.CustomImages.Parent = this.Logout;
            this.Logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.Logout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Logout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Logout.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.logOut;
            this.Logout.HoverState.Parent = this.Logout;
            this.Logout.Image = global::WindowsFormsApp1.Properties.Resources.Logout_Rounded_32px;
            this.Logout.ImageOffset = new System.Drawing.Point(-15, 0);
            this.Logout.ImageSize = new System.Drawing.Size(40, 40);
            this.Logout.Location = new System.Drawing.Point(12, 633);
            this.Logout.Name = "Logout";
            this.Logout.ShadowDecoration.Parent = this.Logout;
            this.Logout.Size = new System.Drawing.Size(191, 46);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "LOGOUT";
            this.Logout.TextOffset = new System.Drawing.Point(-10, 0);
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnReport
            // 
            this.btnReport.BorderRadius = 10;
            this.btnReport.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnReport.CheckedState.Parent = this.btnReport;
            this.btnReport.CustomImages.Parent = this.btnReport;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReport.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReport.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.report;
            this.btnReport.HoverState.Parent = this.btnReport;
            this.btnReport.Image = global::WindowsFormsApp1.Properties.Resources.report_file_32px;
            this.btnReport.ImageOffset = new System.Drawing.Point(-13, 0);
            this.btnReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReport.Location = new System.Drawing.Point(0, 495);
            this.btnReport.Name = "btnReport";
            this.btnReport.ShadowDecoration.Parent = this.btnReport;
            this.btnReport.Size = new System.Drawing.Size(212, 45);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "P_Report";
            this.btnReport.TextOffset = new System.Drawing.Point(-6, 0);
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPharmacy
            // 
            this.btnPharmacy.BorderRadius = 10;
            this.btnPharmacy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnPharmacy.CheckedState.Parent = this.btnPharmacy;
            this.btnPharmacy.CustomImages.Parent = this.btnPharmacy;
            this.btnPharmacy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPharmacy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnPharmacy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacy.ForeColor = System.Drawing.Color.White;
            this.btnPharmacy.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPharmacy.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPharmacy.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.pharmacy;
            this.btnPharmacy.HoverState.Parent = this.btnPharmacy;
            this.btnPharmacy.Image = global::WindowsFormsApp1.Properties.Resources.pharmacy_shop_32px;
            this.btnPharmacy.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnPharmacy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPharmacy.Location = new System.Drawing.Point(0, 450);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.ShadowDecoration.Parent = this.btnPharmacy;
            this.btnPharmacy.Size = new System.Drawing.Size(212, 45);
            this.btnPharmacy.TabIndex = 13;
            this.btnPharmacy.Text = "Pharmacy";
            this.btnPharmacy.TextOffset = new System.Drawing.Point(-4, 0);
            this.btnPharmacy.Click += new System.EventHandler(this.btnPharmacy_Click_1);
            // 
            // btnResultDiagnosis
            // 
            this.btnResultDiagnosis.BorderRadius = 10;
            this.btnResultDiagnosis.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnResultDiagnosis.CheckedState.Parent = this.btnResultDiagnosis;
            this.btnResultDiagnosis.CustomImages.Parent = this.btnResultDiagnosis;
            this.btnResultDiagnosis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResultDiagnosis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnResultDiagnosis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnResultDiagnosis.HoverState.FillColor = System.Drawing.Color.White;
            this.btnResultDiagnosis.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnResultDiagnosis.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.lab1;
            this.btnResultDiagnosis.HoverState.Parent = this.btnResultDiagnosis;
            this.btnResultDiagnosis.Image = global::WindowsFormsApp1.Properties.Resources.system_diagnostic_32px2;
            this.btnResultDiagnosis.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnResultDiagnosis.ImageSize = new System.Drawing.Size(30, 30);
            this.btnResultDiagnosis.Location = new System.Drawing.Point(0, 405);
            this.btnResultDiagnosis.Name = "btnResultDiagnosis";
            this.btnResultDiagnosis.ShadowDecoration.Parent = this.btnResultDiagnosis;
            this.btnResultDiagnosis.Size = new System.Drawing.Size(212, 45);
            this.btnResultDiagnosis.TabIndex = 12;
            this.btnResultDiagnosis.Text = "Re_Diagnosis";
            this.btnResultDiagnosis.TextOffset = new System.Drawing.Point(2, 0);
            this.btnResultDiagnosis.Click += new System.EventHandler(this.btnResultDiagnosis_Click_1);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BorderRadius = 10;
            this.btnDiagnosis.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnDiagnosis.CheckedState.Parent = this.btnDiagnosis;
            this.btnDiagnosis.CustomImages.Parent = this.btnDiagnosis;
            this.btnDiagnosis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnosis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnDiagnosis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDiagnosis.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDiagnosis.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.lab;
            this.btnDiagnosis.HoverState.Parent = this.btnDiagnosis;
            this.btnDiagnosis.Image = global::WindowsFormsApp1.Properties.Resources.system_diagnostic_32px1;
            this.btnDiagnosis.ImageOffset = new System.Drawing.Point(-11, 0);
            this.btnDiagnosis.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDiagnosis.Location = new System.Drawing.Point(0, 360);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.ShadowDecoration.Parent = this.btnDiagnosis;
            this.btnDiagnosis.Size = new System.Drawing.Size(212, 45);
            this.btnDiagnosis.TabIndex = 11;
            this.btnDiagnosis.Text = "Diagnosis";
            this.btnDiagnosis.TextOffset = new System.Drawing.Point(-6, 0);
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click_1);
            // 
            // btnDocAppointment
            // 
            this.btnDocAppointment.BorderRadius = 10;
            this.btnDocAppointment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnDocAppointment.CheckedState.Parent = this.btnDocAppointment;
            this.btnDocAppointment.CustomImages.Parent = this.btnDocAppointment;
            this.btnDocAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnDocAppointment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocAppointment.ForeColor = System.Drawing.Color.White;
            this.btnDocAppointment.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDocAppointment.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDocAppointment.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.docApp;
            this.btnDocAppointment.HoverState.Parent = this.btnDocAppointment;
            this.btnDocAppointment.Image = global::WindowsFormsApp1.Properties.Resources.clock_checked_32px;
            this.btnDocAppointment.ImageOffset = new System.Drawing.Point(-12, 0);
            this.btnDocAppointment.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDocAppointment.Location = new System.Drawing.Point(0, 315);
            this.btnDocAppointment.Name = "btnDocAppointment";
            this.btnDocAppointment.ShadowDecoration.Parent = this.btnDocAppointment;
            this.btnDocAppointment.Size = new System.Drawing.Size(212, 45);
            this.btnDocAppointment.TabIndex = 10;
            this.btnDocAppointment.Text = "Doc_App";
            this.btnDocAppointment.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnDocAppointment.Click += new System.EventHandler(this.btnDocAppointment_Click_1);
            // 
            // btnAppointment
            // 
            this.btnAppointment.BorderRadius = 10;
            this.btnAppointment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnAppointment.CheckedState.Parent = this.btnAppointment;
            this.btnAppointment.CustomImages.Parent = this.btnAppointment;
            this.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnAppointment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAppointment.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAppointment.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.appointment;
            this.btnAppointment.HoverState.Parent = this.btnAppointment;
            this.btnAppointment.Image = global::WindowsFormsApp1.Properties.Resources.timetable_32px;
            this.btnAppointment.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnAppointment.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAppointment.Location = new System.Drawing.Point(0, 270);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.ShadowDecoration.Parent = this.btnAppointment;
            this.btnAppointment.Size = new System.Drawing.Size(212, 45);
            this.btnAppointment.TabIndex = 9;
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click_1);
            // 
            // btnPatient
            // 
            this.btnPatient.BorderRadius = 10;
            this.btnPatient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnPatient.CheckedState.Parent = this.btnPatient;
            this.btnPatient.CustomImages.Parent = this.btnPatient;
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPatient.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPatient.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.patient;
            this.btnPatient.HoverState.Parent = this.btnPatient;
            this.btnPatient.Image = global::WindowsFormsApp1.Properties.Resources.sick_32px;
            this.btnPatient.ImageOffset = new System.Drawing.Point(-17, 0);
            this.btnPatient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPatient.Location = new System.Drawing.Point(0, 225);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.ShadowDecoration.Parent = this.btnPatient;
            this.btnPatient.Size = new System.Drawing.Size(212, 45);
            this.btnPatient.TabIndex = 8;
            this.btnPatient.Text = "Patient";
            this.btnPatient.TextOffset = new System.Drawing.Point(-13, 0);
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click_1);
            // 
            // btnReception
            // 
            this.btnReception.BorderRadius = 10;
            this.btnReception.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnReception.CheckedState.Parent = this.btnReception;
            this.btnReception.CustomImages.Parent = this.btnReception;
            this.btnReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReception.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnReception.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.ForeColor = System.Drawing.Color.White;
            this.btnReception.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReception.HoverState.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnReception.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReception.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.reception;
            this.btnReception.HoverState.Parent = this.btnReception;
            this.btnReception.Image = global::WindowsFormsApp1.Properties.Resources.front_desk_32px;
            this.btnReception.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnReception.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReception.Location = new System.Drawing.Point(0, 180);
            this.btnReception.Name = "btnReception";
            this.btnReception.ShadowDecoration.Parent = this.btnReception;
            this.btnReception.Size = new System.Drawing.Size(212, 45);
            this.btnReception.TabIndex = 7;
            this.btnReception.Text = "Reception";
            this.btnReception.TextOffset = new System.Drawing.Point(-7, 0);
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click_1);
            // 
            // btnNurse
            // 
            this.btnNurse.BorderRadius = 10;
            this.btnNurse.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnNurse.CheckedState.Parent = this.btnNurse;
            this.btnNurse.CustomImages.Parent = this.btnNurse;
            this.btnNurse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNurse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnNurse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurse.ForeColor = System.Drawing.Color.White;
            this.btnNurse.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNurse.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNurse.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.nurse;
            this.btnNurse.HoverState.Parent = this.btnNurse;
            this.btnNurse.Image = global::WindowsFormsApp1.Properties.Resources.nurse_32px;
            this.btnNurse.ImageOffset = new System.Drawing.Point(-16, 0);
            this.btnNurse.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNurse.Location = new System.Drawing.Point(0, 135);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.ShadowDecoration.Parent = this.btnNurse;
            this.btnNurse.Size = new System.Drawing.Size(212, 45);
            this.btnNurse.TabIndex = 6;
            this.btnNurse.Text = "Nurse";
            this.btnNurse.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnNurse.Click += new System.EventHandler(this.btnNurse_Click_1);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BorderRadius = 10;
            this.btnDoctor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnDoctor.CheckedState.Parent = this.btnDoctor;
            this.btnDoctor.CustomImages.Parent = this.btnDoctor;
            this.btnDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnDoctor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDoctor.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDoctor.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDoctor.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.doctor;
            this.btnDoctor.HoverState.Parent = this.btnDoctor;
            this.btnDoctor.Image = global::WindowsFormsApp1.Properties.Resources.doctor_giving_advice_32px;
            this.btnDoctor.ImageOffset = new System.Drawing.Point(-16, 0);
            this.btnDoctor.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDoctor.Location = new System.Drawing.Point(0, 90);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.ShadowDecoration.Parent = this.btnDoctor;
            this.btnDoctor.Size = new System.Drawing.Size(212, 45);
            this.btnDoctor.TabIndex = 5;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.TextOffset = new System.Drawing.Point(-12, 0);
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BorderRadius = 10;
            this.btnAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnAdmin.CheckedState.Parent = this.btnAdmin;
            this.btnAdmin.CustomImages.Parent = this.btnAdmin;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdmin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.admin;
            this.btnAdmin.HoverState.Parent = this.btnAdmin;
            this.btnAdmin.Image = global::WindowsFormsApp1.Properties.Resources.manager_32px;
            this.btnAdmin.ImageOffset = new System.Drawing.Point(-17, 0);
            this.btnAdmin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdmin.Location = new System.Drawing.Point(0, 45);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.ShadowDecoration.Parent = this.btnAdmin;
            this.btnAdmin.Size = new System.Drawing.Size(212, 45);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextOffset = new System.Drawing.Point(-13, 0);
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 10;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(12)))), ((int)(((byte)(104)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::WindowsFormsApp1.Properties.Resources.home_32px1;
            this.btnHome.ImageOffset = new System.Drawing.Point(-17, 0);
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(212, 45);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextOffset = new System.Drawing.Point(-13, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // printAll1
            // 
            this.printAll1.BackColor = System.Drawing.Color.White;
            this.printAll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printAll1.Location = new System.Drawing.Point(212, 80);
            this.printAll1.Name = "printAll1";
            this.printAll1.Size = new System.Drawing.Size(1174, 708);
            this.printAll1.TabIndex = 14;
            this.printAll1.Load += new System.EventHandler(this.printAll1_Load);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 80);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1386, 708);
            this.home1.TabIndex = 12;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // pharmacy1
            // 
            this.pharmacy1.BackColor = System.Drawing.Color.White;
            this.pharmacy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacy1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacy1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.pharmacy1.Location = new System.Drawing.Point(0, 80);
            this.pharmacy1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pharmacy1.Name = "pharmacy1";
            this.pharmacy1.Size = new System.Drawing.Size(1386, 708);
            this.pharmacy1.TabIndex = 11;
            // 
            // re_diagnosis1
            // 
            this.re_diagnosis1.BackColor = System.Drawing.Color.White;
            this.re_diagnosis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.re_diagnosis1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_diagnosis1.ForeColor = System.Drawing.Color.Black;
            this.re_diagnosis1.Location = new System.Drawing.Point(0, 80);
            this.re_diagnosis1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.re_diagnosis1.Name = "re_diagnosis1";
            this.re_diagnosis1.Size = new System.Drawing.Size(1386, 708);
            this.re_diagnosis1.TabIndex = 10;
            // 
            // diagnosis1
            // 
            this.diagnosis1.BackColor = System.Drawing.Color.White;
            this.diagnosis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnosis1.Location = new System.Drawing.Point(0, 80);
            this.diagnosis1.Name = "diagnosis1";
            this.diagnosis1.Size = new System.Drawing.Size(1386, 708);
            this.diagnosis1.TabIndex = 9;
            // 
            // docApp1
            // 
            this.docApp1.BackColor = System.Drawing.Color.White;
            this.docApp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docApp1.Location = new System.Drawing.Point(0, 80);
            this.docApp1.Name = "docApp1";
            this.docApp1.Size = new System.Drawing.Size(1386, 708);
            this.docApp1.TabIndex = 8;
            // 
            // appointment1
            // 
            this.appointment1.BackColor = System.Drawing.Color.White;
            this.appointment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointment1.Location = new System.Drawing.Point(0, 80);
            this.appointment1.Name = "appointment1";
            this.appointment1.Size = new System.Drawing.Size(1386, 708);
            this.appointment1.TabIndex = 7;
            // 
            // patient1
            // 
            this.patient1.BackColor = System.Drawing.Color.White;
            this.patient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patient1.Location = new System.Drawing.Point(0, 80);
            this.patient1.Name = "patient1";
            this.patient1.Size = new System.Drawing.Size(1386, 708);
            this.patient1.TabIndex = 6;
            // 
            // reception1
            // 
            this.reception1.BackColor = System.Drawing.Color.White;
            this.reception1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reception1.ForeColor = System.Drawing.Color.Black;
            this.reception1.Location = new System.Drawing.Point(0, 80);
            this.reception1.Name = "reception1";
            this.reception1.Size = new System.Drawing.Size(1386, 708);
            this.reception1.TabIndex = 5;
            // 
            // nurse1
            // 
            this.nurse1.BackColor = System.Drawing.Color.White;
            this.nurse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurse1.Location = new System.Drawing.Point(0, 80);
            this.nurse1.Name = "nurse1";
            this.nurse1.Size = new System.Drawing.Size(1386, 708);
            this.nurse1.TabIndex = 4;
            // 
            // doctor1
            // 
            this.doctor1.BackColor = System.Drawing.Color.White;
            this.doctor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.doctor1.Location = new System.Drawing.Point(0, 80);
            this.doctor1.Name = "doctor1";
            this.doctor1.Size = new System.Drawing.Size(1386, 708);
            this.doctor1.TabIndex = 3;
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.Color.White;
            this.admin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin1.Location = new System.Drawing.Point(0, 80);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(1386, 708);
            this.admin1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.printAll1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.pharmacy1);
            this.Controls.Add(this.re_diagnosis1);
            this.Controls.Add(this.diagnosis1);
            this.Controls.Add(this.docApp1);
            this.Controls.Add(this.appointment1);
            this.Controls.Add(this.patient1);
            this.Controls.Add(this.reception1);
            this.Controls.Add(this.nurse1);
            this.Controls.Add(this.doctor1);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Admin admin1;
        private Doctor doctor1;
        private Nurse nurse1;
        private Reception reception1;
        private Patient patient1;
        private Appointment appointment1;
        private DocApp docApp1;
        private Diagnosis diagnosis1;
        private Re_diagnosis re_diagnosis1;
        private Pharmacy pharmacy1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel SideBar;
        public Guna.UI2.WinForms.Guna2Button btnPharmacy;
        public Guna.UI2.WinForms.Guna2Button btnResultDiagnosis;
        public Guna.UI2.WinForms.Guna2Button btnDiagnosis;
        public Guna.UI2.WinForms.Guna2Button btnDocAppointment;
        public Guna.UI2.WinForms.Guna2Button btnAppointment;
        public Guna.UI2.WinForms.Guna2Button btnPatient;
        public Guna.UI2.WinForms.Guna2Button btnReception;
        public Guna.UI2.WinForms.Guna2Button btnNurse;
        public Guna.UI2.WinForms.Guna2Button btnDoctor;
        public Guna.UI2.WinForms.Guna2Button btnAdmin;
        public Guna.UI2.WinForms.Guna2Button btnHome;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
        public System.Windows.Forms.Label lblPrintUser;
        public System.Windows.Forms.Label lblPrintName;
        public Home home1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Guna.UI2.WinForms.Guna2Button btnReport;
        private PrintAll printAll1;
        private Guna.UI2.WinForms.Guna2Button Logout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeProfileToolStripMenuItem;
    }
}