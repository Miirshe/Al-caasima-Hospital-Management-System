
namespace WindowsFormsApp1
{
    partial class Pharmacy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DocName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPatientID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPatMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MedType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MedQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MedCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DiagnosisDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComboDiagDisease = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.DocName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DocName.HoverState.Parent = this.DocName;
            this.DocName.Location = new System.Drawing.Point(794, 114);
            this.DocName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocName.Name = "DocName";
            this.DocName.PasswordChar = '\0';
            this.DocName.PlaceholderText = "";
            this.DocName.ReadOnly = true;
            this.DocName.SelectedText = "";
            this.DocName.ShadowDecoration.Parent = this.DocName;
            this.DocName.Size = new System.Drawing.Size(232, 34);
            this.DocName.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(792, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "Doc_Name";
            // 
            // PatName
            // 
            this.PatName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.PatName.BorderRadius = 8;
            this.PatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatName.DefaultText = "";
            this.PatName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatName.DisabledState.Parent = this.PatName;
            this.PatName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatName.FocusedState.Parent = this.PatName;
            this.PatName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatName.HoverState.Parent = this.PatName;
            this.PatName.Location = new System.Drawing.Point(502, 114);
            this.PatName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PatName.Name = "PatName";
            this.PatName.PasswordChar = '\0';
            this.PatName.PlaceholderText = "";
            this.PatName.ReadOnly = true;
            this.PatName.SelectedText = "";
            this.PatName.ShadowDecoration.Parent = this.PatName;
            this.PatName.Size = new System.Drawing.Size(232, 34);
            this.PatName.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(499, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 133;
            this.label1.Text = "Patient_Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(211, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 132;
            this.label4.Text = "Patient_ID";
            // 
            // comboPatientID
            // 
            this.comboPatientID.BackColor = System.Drawing.Color.Transparent;
            this.comboPatientID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.comboPatientID.BorderRadius = 8;
            this.comboPatientID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPatientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPatientID.FocusedColor = System.Drawing.Color.Empty;
            this.comboPatientID.FocusedState.Parent = this.comboPatientID;
            this.comboPatientID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPatientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboPatientID.FormattingEnabled = true;
            this.comboPatientID.HoverState.Parent = this.comboPatientID;
            this.comboPatientID.ItemHeight = 30;
            this.comboPatientID.ItemsAppearance.Parent = this.comboPatientID;
            this.comboPatientID.Location = new System.Drawing.Point(214, 112);
            this.comboPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboPatientID.Name = "comboPatientID";
            this.comboPatientID.ShadowDecoration.Parent = this.comboPatientID;
            this.comboPatientID.Size = new System.Drawing.Size(231, 36);
            this.comboPatientID.TabIndex = 131;
            this.comboPatientID.SelectionChangeCommitted += new System.EventHandler(this.comboPatientID_SelectionChangeCommitted);
            // 
            // txtPatMedicine
            // 
            this.txtPatMedicine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.txtPatMedicine.BorderRadius = 8;
            this.txtPatMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatMedicine.DefaultText = "";
            this.txtPatMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatMedicine.DisabledState.Parent = this.txtPatMedicine;
            this.txtPatMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatMedicine.FocusedState.Parent = this.txtPatMedicine;
            this.txtPatMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatMedicine.HoverState.Parent = this.txtPatMedicine;
            this.txtPatMedicine.Location = new System.Drawing.Point(504, 177);
            this.txtPatMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatMedicine.Name = "txtPatMedicine";
            this.txtPatMedicine.PasswordChar = '\0';
            this.txtPatMedicine.PlaceholderText = "";
            this.txtPatMedicine.ReadOnly = true;
            this.txtPatMedicine.SelectedText = "";
            this.txtPatMedicine.ShadowDecoration.Parent = this.txtPatMedicine;
            this.txtPatMedicine.Size = new System.Drawing.Size(232, 34);
            this.txtPatMedicine.TabIndex = 146;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(503, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 145;
            this.label9.Text = "Pat_Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(215, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 143;
            this.label2.Text = "Patient_Diagnosis";
            // 
            // MedType
            // 
            this.MedType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.MedType.BorderRadius = 8;
            this.MedType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedType.DefaultText = "";
            this.MedType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedType.DisabledState.Parent = this.MedType;
            this.MedType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedType.FocusedState.Parent = this.MedType;
            this.MedType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedType.HoverState.Parent = this.MedType;
            this.MedType.Location = new System.Drawing.Point(797, 177);
            this.MedType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedType.Name = "MedType";
            this.MedType.PasswordChar = '\0';
            this.MedType.PlaceholderText = "";
            this.MedType.SelectedText = "";
            this.MedType.ShadowDecoration.Parent = this.MedType;
            this.MedType.Size = new System.Drawing.Size(232, 34);
            this.MedType.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(796, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 147;
            this.label3.Text = "Med_type";
            // 
            // MedQuantity
            // 
            this.MedQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.MedQuantity.BorderRadius = 8;
            this.MedQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedQuantity.DefaultText = "";
            this.MedQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedQuantity.DisabledState.Parent = this.MedQuantity;
            this.MedQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedQuantity.FocusedState.Parent = this.MedQuantity;
            this.MedQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedQuantity.HoverState.Parent = this.MedQuantity;
            this.MedQuantity.Location = new System.Drawing.Point(218, 247);
            this.MedQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedQuantity.Name = "MedQuantity";
            this.MedQuantity.PasswordChar = '\0';
            this.MedQuantity.PlaceholderText = "";
            this.MedQuantity.SelectedText = "";
            this.MedQuantity.ShadowDecoration.Parent = this.MedQuantity;
            this.MedQuantity.Size = new System.Drawing.Size(232, 36);
            this.MedQuantity.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(214, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 149;
            this.label6.Text = "Med_Quantity";
            // 
            // MedCost
            // 
            this.MedCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.MedCost.BorderRadius = 8;
            this.MedCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedCost.DefaultText = "";
            this.MedCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedCost.DisabledState.Parent = this.MedCost;
            this.MedCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedCost.FocusedState.Parent = this.MedCost;
            this.MedCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedCost.HoverState.Parent = this.MedCost;
            this.MedCost.Location = new System.Drawing.Point(506, 247);
            this.MedCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedCost.Name = "MedCost";
            this.MedCost.PasswordChar = '\0';
            this.MedCost.PlaceholderText = "";
            this.MedCost.SelectedText = "";
            this.MedCost.ShadowDecoration.Parent = this.MedCost;
            this.MedCost.Size = new System.Drawing.Size(232, 36);
            this.MedCost.TabIndex = 152;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(501, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 151;
            this.label7.Text = "Med_Cost";
            // 
            // DiagnosisDataGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DiagnosisDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DiagnosisDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DiagnosisDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisDataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.DiagnosisDataGrid.EnableHeadersVisualStyles = false;
            this.DiagnosisDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisDataGrid.Location = new System.Drawing.Point(-5, 455);
            this.DiagnosisDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiagnosisDataGrid.Name = "DiagnosisDataGrid";
            this.DiagnosisDataGrid.RowHeadersVisible = false;
            this.DiagnosisDataGrid.RowTemplate.Height = 28;
            this.DiagnosisDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiagnosisDataGrid.Size = new System.Drawing.Size(1413, 407);
            this.DiagnosisDataGrid.TabIndex = 156;
            this.DiagnosisDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DiagnosisDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DiagnosisDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DiagnosisDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DiagnosisDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DiagnosisDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.DiagnosisDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiagnosisDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisDataGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.DiagnosisDataGrid.ThemeStyle.ReadOnly = false;
            this.DiagnosisDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.DiagnosisDataGrid.ThemeStyle.RowsStyle.Height = 28;
            this.DiagnosisDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.DiagnosisDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisDataGrid_CellContentClick);
            // 
            // ComboDiagDisease
            // 
            this.ComboDiagDisease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.ComboDiagDisease.BorderRadius = 8;
            this.ComboDiagDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ComboDiagDisease.DefaultText = "";
            this.ComboDiagDisease.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ComboDiagDisease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ComboDiagDisease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ComboDiagDisease.DisabledState.Parent = this.ComboDiagDisease;
            this.ComboDiagDisease.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ComboDiagDisease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDiagDisease.FocusedState.Parent = this.ComboDiagDisease;
            this.ComboDiagDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.ComboDiagDisease.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDiagDisease.HoverState.Parent = this.ComboDiagDisease;
            this.ComboDiagDisease.Location = new System.Drawing.Point(216, 177);
            this.ComboDiagDisease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboDiagDisease.Name = "ComboDiagDisease";
            this.ComboDiagDisease.PasswordChar = '\0';
            this.ComboDiagDisease.PlaceholderText = "";
            this.ComboDiagDisease.ReadOnly = true;
            this.ComboDiagDisease.SelectedText = "";
            this.ComboDiagDisease.ShadowDecoration.Parent = this.ComboDiagDisease;
            this.ComboDiagDisease.Size = new System.Drawing.Size(232, 34);
            this.ComboDiagDisease.TabIndex = 157;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label12.Location = new System.Drawing.Point(51, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 17);
            this.label12.TabIndex = 159;
            this.label12.Text = "Manage pharmacy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(49, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 158;
            this.label11.Text = "Pharmacy";
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
            this.txtSearch.Location = new System.Drawing.Point(867, 402);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(196, 35);
            this.txtSearch.TabIndex = 161;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(764, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 160;
            this.label8.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::WindowsFormsApp1.Properties.Resources.waste_32px8;
            this.btnDelete.Location = new System.Drawing.Point(890, 297);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(139, 44);
            this.btnDelete.TabIndex = 155;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = global::WindowsFormsApp1.Properties.Resources.Edit_Property_128px8;
            this.btnUpdate.Location = new System.Drawing.Point(718, 297);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(139, 44);
            this.btnUpdate.TabIndex = 154;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(187)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::WindowsFormsApp1.Properties.Resources.add_60px9;
            this.btnSave.Location = new System.Drawing.Point(547, 297);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(139, 44);
            this.btnSave.TabIndex = 153;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.lblDisplay.Location = new System.Drawing.Point(544, 582);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(457, 217);
            this.lblDisplay.TabIndex = 164;
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ComboDiagDisease);
            this.Controls.Add(this.DiagnosisDataGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.MedCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MedQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MedType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatMedicine);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboPatientID);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pharmacy";
            this.Size = new System.Drawing.Size(1408, 862);
            this.Load += new System.EventHandler(this.Pharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox DocName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox comboPatientID;
        private Guna.UI2.WinForms.Guna2TextBox txtPatMedicine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox MedType;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox MedQuantity;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox MedCost;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2DataGridView DiagnosisDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox ComboDiagDisease;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDisplay;
    }
}
