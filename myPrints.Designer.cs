
namespace WindowsFormsApp1
{
    partial class myPrints
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CRPrint = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboSubPaitient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboChoose = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Generate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1144, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // CRPrint
            // 
            this.CRPrint.ActiveViewIndex = -1;
            this.CRPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPrint.Location = new System.Drawing.Point(1, 134);
            this.CRPrint.Name = "CRPrint";
            this.CRPrint.Size = new System.Drawing.Size(1188, 577);
            this.CRPrint.TabIndex = 1;
            this.CRPrint.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CRPrint.Load += new System.EventHandler(this.CRPrint_Load);
            // 
            // comboSubPaitient
            // 
            this.comboSubPaitient.BackColor = System.Drawing.Color.Transparent;
            this.comboSubPaitient.BorderRadius = 8;
            this.comboSubPaitient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSubPaitient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubPaitient.FocusedColor = System.Drawing.Color.Empty;
            this.comboSubPaitient.FocusedState.Parent = this.comboSubPaitient;
            this.comboSubPaitient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSubPaitient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboSubPaitient.FormattingEnabled = true;
            this.comboSubPaitient.HoverState.Parent = this.comboSubPaitient;
            this.comboSubPaitient.ItemHeight = 30;
            this.comboSubPaitient.Items.AddRange(new object[] {
            "Select Item"});
            this.comboSubPaitient.ItemsAppearance.Parent = this.comboSubPaitient;
            this.comboSubPaitient.Location = new System.Drawing.Point(655, 57);
            this.comboSubPaitient.Name = "comboSubPaitient";
            this.comboSubPaitient.ShadowDecoration.Parent = this.comboSubPaitient;
            this.comboSubPaitient.Size = new System.Drawing.Size(226, 36);
            this.comboSubPaitient.TabIndex = 2;
            // 
            // comboChoose
            // 
            this.comboChoose.BackColor = System.Drawing.Color.Transparent;
            this.comboChoose.BorderRadius = 8;
            this.comboChoose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChoose.FocusedColor = System.Drawing.Color.Empty;
            this.comboChoose.FocusedState.Parent = this.comboChoose;
            this.comboChoose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboChoose.FormattingEnabled = true;
            this.comboChoose.HoverState.Parent = this.comboChoose;
            this.comboChoose.ItemHeight = 30;
            this.comboChoose.Items.AddRange(new object[] {
            "All",
            "Custom"});
            this.comboChoose.ItemsAppearance.Parent = this.comboChoose;
            this.comboChoose.Location = new System.Drawing.Point(12, 57);
            this.comboChoose.Name = "comboChoose";
            this.comboChoose.ShadowDecoration.Parent = this.comboChoose;
            this.comboChoose.Size = new System.Drawing.Size(226, 36);
            this.comboChoose.TabIndex = 3;
            this.comboChoose.TextChanged += new System.EventHandler(this.comboChoose_TextChanged);
            // 
            // Generate
            // 
            this.Generate.BorderRadius = 8;
            this.Generate.CheckedState.Parent = this.Generate;
            this.Generate.CustomImages.Parent = this.Generate;
            this.Generate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Generate.ForeColor = System.Drawing.Color.White;
            this.Generate.HoverState.Parent = this.Generate;
            this.Generate.Location = new System.Drawing.Point(983, 48);
            this.Generate.Name = "Generate";
            this.Generate.ShadowDecoration.Parent = this.Generate;
            this.Generate.Size = new System.Drawing.Size(180, 45);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Generate";
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // myPrints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 708);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.comboChoose);
            this.Controls.Add(this.comboSubPaitient);
            this.Controls.Add(this.CRPrint);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myPrints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myPrints";
            this.Load += new System.EventHandler(this.myPrints_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRPrint;
        private Guna.UI2.WinForms.Guna2ComboBox comboSubPaitient;
        private Guna.UI2.WinForms.Guna2ComboBox comboChoose;
        private Guna.UI2.WinForms.Guna2Button Generate;
    }
}