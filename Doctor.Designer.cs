
namespace WindowsFormsApp1
{
    partial class Doctor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBrowser = new Guna.UI2.WinForms.Guna2Button();
            this.DocExp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboSpec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DocPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DocSecAns = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DocSecQue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DocPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DocUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DocName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DocSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DoctorDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.CheckedState.Parent = this.btnBrowser;
            this.btnBrowser.CustomImages.Parent = this.btnBrowser;
            this.btnBrowser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBrowser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.ForeColor = System.Drawing.Color.Black;
            this.btnBrowser.HoverState.Parent = this.btnBrowser;
            this.btnBrowser.Location = new System.Drawing.Point(932, 250);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.ShadowDecoration.Parent = this.btnBrowser;
            this.btnBrowser.Size = new System.Drawing.Size(175, 45);
            this.btnBrowser.TabIndex = 38;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // DocExp
            // 
            this.DocExp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocExp.BorderRadius = 8;
            this.DocExp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocExp.DefaultText = "";
            this.DocExp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocExp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocExp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocExp.DisabledState.Parent = this.DocExp;
            this.DocExp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocExp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocExp.FocusedState.Parent = this.DocExp;
            this.DocExp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocExp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocExp.HoverState.Parent = this.DocExp;
            this.DocExp.Location = new System.Drawing.Point(421, 242);
            this.DocExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocExp.Name = "DocExp";
            this.DocExp.PasswordChar = '\0';
            this.DocExp.PlaceholderText = "";
            this.DocExp.SelectedText = "";
            this.DocExp.ShadowDecoration.Parent = this.DocExp;
            this.DocExp.Size = new System.Drawing.Size(210, 36);
            this.DocExp.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(417, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Doc_Exp";
            // 
            // comboSpec
            // 
            this.comboSpec.BackColor = System.Drawing.Color.Transparent;
            this.comboSpec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.comboSpec.BorderRadius = 8;
            this.comboSpec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpec.FocusedColor = System.Drawing.Color.Empty;
            this.comboSpec.FocusedState.Parent = this.comboSpec;
            this.comboSpec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSpec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboSpec.FormattingEnabled = true;
            this.comboSpec.HoverState.Parent = this.comboSpec;
            this.comboSpec.ItemHeight = 30;
            this.comboSpec.Items.AddRange(new object[] {
            "1.Doctorka Taranka",
            "2.Doctorka  Indhaha",
            "3.Doctorka Maqaarka",
            "4.Doctorka Wadnaha",
            "5.Doctorka Ilkaha",
            "6.Doctorka  dhalaanka",
            "7.Doctorka Maskaxda",
            "8.Doctorka Caloosha"});
            this.comboSpec.ItemsAppearance.Parent = this.comboSpec;
            this.comboSpec.Location = new System.Drawing.Point(173, 242);
            this.comboSpec.Name = "comboSpec";
            this.comboSpec.ShadowDecoration.Parent = this.comboSpec;
            this.comboSpec.Size = new System.Drawing.Size(210, 36);
            this.comboSpec.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(169, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Doc_Spec";
            // 
            // DocPhone
            // 
            this.DocPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocPhone.BorderRadius = 8;
            this.DocPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocPhone.DefaultText = "";
            this.DocPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocPhone.DisabledState.Parent = this.DocPhone;
            this.DocPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocPhone.FocusedState.Parent = this.DocPhone;
            this.DocPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocPhone.HoverState.Parent = this.DocPhone;
            this.DocPhone.Location = new System.Drawing.Point(661, 179);
            this.DocPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocPhone.Name = "DocPhone";
            this.DocPhone.PasswordChar = '\0';
            this.DocPhone.PlaceholderText = "";
            this.DocPhone.SelectedText = "";
            this.DocPhone.ShadowDecoration.Parent = this.DocPhone;
            this.DocPhone.Size = new System.Drawing.Size(210, 36);
            this.DocPhone.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(657, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Doc_phone";
            // 
            // DocSecAns
            // 
            this.DocSecAns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocSecAns.BorderRadius = 8;
            this.DocSecAns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocSecAns.DefaultText = "";
            this.DocSecAns.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocSecAns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocSecAns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocSecAns.DisabledState.Parent = this.DocSecAns;
            this.DocSecAns.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocSecAns.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocSecAns.FocusedState.Parent = this.DocSecAns;
            this.DocSecAns.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSecAns.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocSecAns.HoverState.Parent = this.DocSecAns;
            this.DocSecAns.Location = new System.Drawing.Point(421, 179);
            this.DocSecAns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocSecAns.Name = "DocSecAns";
            this.DocSecAns.PasswordChar = '\0';
            this.DocSecAns.PlaceholderText = "";
            this.DocSecAns.SelectedText = "";
            this.DocSecAns.ShadowDecoration.Parent = this.DocSecAns;
            this.DocSecAns.Size = new System.Drawing.Size(210, 36);
            this.DocSecAns.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(417, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Doc_sec_Ans";
            // 
            // DocSecQue
            // 
            this.DocSecQue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocSecQue.BorderRadius = 8;
            this.DocSecQue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocSecQue.DefaultText = "";
            this.DocSecQue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocSecQue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocSecQue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocSecQue.DisabledState.Parent = this.DocSecQue;
            this.DocSecQue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocSecQue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocSecQue.FocusedState.Parent = this.DocSecQue;
            this.DocSecQue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSecQue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocSecQue.HoverState.Parent = this.DocSecQue;
            this.DocSecQue.Location = new System.Drawing.Point(173, 179);
            this.DocSecQue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocSecQue.Name = "DocSecQue";
            this.DocSecQue.PasswordChar = '\0';
            this.DocSecQue.PlaceholderText = "";
            this.DocSecQue.SelectedText = "";
            this.DocSecQue.ShadowDecoration.Parent = this.DocSecQue;
            this.DocSecQue.Size = new System.Drawing.Size(210, 36);
            this.DocSecQue.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(169, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Doc_sec_Que";
            // 
            // DocPassword
            // 
            this.DocPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocPassword.BorderRadius = 8;
            this.DocPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocPassword.DefaultText = "";
            this.DocPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocPassword.DisabledState.Parent = this.DocPassword;
            this.DocPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocPassword.FocusedState.Parent = this.DocPassword;
            this.DocPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocPassword.HoverState.Parent = this.DocPassword;
            this.DocPassword.Location = new System.Drawing.Point(661, 115);
            this.DocPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocPassword.Name = "DocPassword";
            this.DocPassword.PasswordChar = '\0';
            this.DocPassword.PlaceholderText = "";
            this.DocPassword.SelectedText = "";
            this.DocPassword.ShadowDecoration.Parent = this.DocPassword;
            this.DocPassword.Size = new System.Drawing.Size(210, 36);
            this.DocPassword.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(657, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Doc_Paasword";
            // 
            // DocUser
            // 
            this.DocUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocUser.BorderRadius = 8;
            this.DocUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocUser.DefaultText = "";
            this.DocUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocUser.DisabledState.Parent = this.DocUser;
            this.DocUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocUser.FocusedState.Parent = this.DocUser;
            this.DocUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocUser.HoverState.Parent = this.DocUser;
            this.DocUser.Location = new System.Drawing.Point(421, 115);
            this.DocUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocUser.Name = "DocUser";
            this.DocUser.PasswordChar = '\0';
            this.DocUser.PlaceholderText = "";
            this.DocUser.SelectedText = "";
            this.DocUser.ShadowDecoration.Parent = this.DocUser;
            this.DocUser.Size = new System.Drawing.Size(210, 36);
            this.DocUser.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(417, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Doc_Username";
            // 
            // DocName
            // 
            this.DocName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocName.BorderRadius = 8;
            this.DocName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocName.DefaultText = "";
            this.DocName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocName.DisabledState.Parent = this.DocName;
            this.DocName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocName.FocusedState.Parent = this.DocName;
            this.DocName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocName.HoverState.Parent = this.DocName;
            this.DocName.Location = new System.Drawing.Point(173, 115);
            this.DocName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocName.Name = "DocName";
            this.DocName.PasswordChar = '\0';
            this.DocName.PlaceholderText = "";
            this.DocName.SelectedText = "";
            this.DocName.ShadowDecoration.Parent = this.DocName;
            this.DocName.Size = new System.Drawing.Size(210, 36);
            this.DocName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(169, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Doc_Name";
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.Transparent;
            this.comboGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.comboGender.BorderRadius = 8;
            this.comboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FocusedColor = System.Drawing.Color.Empty;
            this.comboGender.FocusedState.Parent = this.comboGender;
            this.comboGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.HoverState.Parent = this.comboGender;
            this.comboGender.ItemHeight = 30;
            this.comboGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboGender.ItemsAppearance.Parent = this.comboGender;
            this.comboGender.Location = new System.Drawing.Point(661, 242);
            this.comboGender.Name = "comboGender";
            this.comboGender.ShadowDecoration.Parent = this.comboGender;
            this.comboGender.Size = new System.Drawing.Size(210, 36);
            this.comboGender.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(657, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Doc_Gender";
            // 
            // DocSalary
            // 
            this.DocSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.DocSalary.BorderRadius = 8;
            this.DocSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocSalary.DefaultText = "";
            this.DocSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DocSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DocSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocSalary.DisabledState.Parent = this.DocSalary;
            this.DocSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DocSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocSalary.FocusedState.Parent = this.DocSalary;
            this.DocSalary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocSalary.HoverState.Parent = this.DocSalary;
            this.DocSalary.Location = new System.Drawing.Point(173, 306);
            this.DocSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocSalary.Name = "DocSalary";
            this.DocSalary.PasswordChar = '\0';
            this.DocSalary.PlaceholderText = "";
            this.DocSalary.SelectedText = "";
            this.DocSalary.ShadowDecoration.Parent = this.DocSalary;
            this.DocSalary.Size = new System.Drawing.Size(210, 36);
            this.DocSalary.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label10.Location = new System.Drawing.Point(169, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Doc_Salary";
            // 
            // DoctorDataGrid
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.DoctorDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DoctorDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DoctorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DoctorDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorDataGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.DoctorDataGrid.EnableHeadersVisualStyles = false;
            this.DoctorDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorDataGrid.Location = new System.Drawing.Point(0, 448);
            this.DoctorDataGrid.Name = "DoctorDataGrid";
            this.DoctorDataGrid.RowHeadersVisible = false;
            this.DoctorDataGrid.RowTemplate.Height = 28;
            this.DoctorDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorDataGrid.Size = new System.Drawing.Size(1204, 252);
            this.DoctorDataGrid.TabIndex = 46;
            this.DoctorDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DoctorDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DoctorDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DoctorDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DoctorDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DoctorDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DoctorDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.DoctorDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DoctorDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DoctorDataGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.DoctorDataGrid.ThemeStyle.ReadOnly = false;
            this.DoctorDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.DoctorDataGrid.ThemeStyle.RowsStyle.Height = 28;
            this.DoctorDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.DoctorDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorDataGrid_CellContentClick);
            this.DoctorDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorDataGrid_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(40, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 47;
            this.label11.Text = "Doctors";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label12.Location = new System.Drawing.Point(43, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Manage doctors";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::WindowsFormsApp1.Properties.Resources.waste_32px4;
            this.btnDelete.Location = new System.Drawing.Point(756, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(146, 39);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = global::WindowsFormsApp1.Properties.Resources.Edit_Property_128px4;
            this.btnUpdate.Location = new System.Drawing.Point(584, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(146, 39);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(187)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::WindowsFormsApp1.Properties.Resources.add_60px5;
            this.btnSave.Location = new System.Drawing.Point(412, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(146, 39);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picture
            // 
            this.picture.BorderRadius = 8;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Image = global::WindowsFormsApp1.Properties.Resources.user__4_;
            this.picture.Location = new System.Drawing.Point(932, 112);
            this.picture.Name = "picture";
            this.picture.ShadowDecoration.Parent = this.picture;
            this.picture.Size = new System.Drawing.Size(175, 132);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 37;
            this.picture.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(932, 392);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(205, 33);
            this.txtSearch.TabIndex = 153;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label13.Location = new System.Drawing.Point(827, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 25);
            this.label13.TabIndex = 152;
            this.label13.Text = "Search";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.lblDisplay.Location = new System.Drawing.Point(350, 470);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(457, 230);
            this.lblDisplay.TabIndex = 161;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DoctorDataGrid);
            this.Controls.Add(this.DocSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboSpec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DocPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DocSecAns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DocSecQue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.Name = "Doctor";
            this.Size = new System.Drawing.Size(1207, 700);
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnBrowser;
        private Guna.UI2.WinForms.Guna2PictureBox picture;
        private Guna.UI2.WinForms.Guna2TextBox DocExp;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox comboSpec;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox DocPhone;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox DocSecAns;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox DocSecQue;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox DocPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox DocUser;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox DocName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboGender;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox DocSalary;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorDataGrid;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDisplay;
    }
}
