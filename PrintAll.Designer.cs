
namespace WindowsFormsApp1
{
    partial class PrintAll
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
            this.crPrint = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crPrint
            // 
            this.crPrint.ActiveViewIndex = -1;
            this.crPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.crPrint.Location = new System.Drawing.Point(3, 114);
            this.crPrint.Name = "crPrint";
            this.crPrint.ShowCloseButton = false;
            this.crPrint.ShowCopyButton = false;
            this.crPrint.ShowLogo = false;
            this.crPrint.ShowZoomButton = false;
            this.crPrint.Size = new System.Drawing.Size(1383, 594);
            this.crPrint.TabIndex = 1;
            this.crPrint.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrintAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.crPrint);
            this.Name = "PrintAll";
            this.Size = new System.Drawing.Size(1386, 708);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crPrint;
    }
}
