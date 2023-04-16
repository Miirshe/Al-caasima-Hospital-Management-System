
namespace WindowsFormsApp1
{
    partial class ForgetPassword
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Clear = new Guna.UI2.WinForms.Guna2Button();
            this.btnForget = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPrintPassword = new System.Windows.Forms.Label();
            this.GetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.EnterAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.GetQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGetQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.Clear);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnForget);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblPrintPassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.GetPassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.EnterAnswer);
            this.guna2CustomGradientPanel1.Controls.Add(this.GetQuestion);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnGetQuestion);
            this.guna2CustomGradientPanel1.Controls.Add(this.Username);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.button1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(830, 410);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.CheckedState.Parent = this.Clear;
            this.Clear.CustomImages.Parent = this.Clear;
            this.Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.HoverState.Parent = this.Clear;
            this.Clear.Location = new System.Drawing.Point(68, 357);
            this.Clear.Name = "Clear";
            this.Clear.ShadowDecoration.Parent = this.Clear;
            this.Clear.Size = new System.Drawing.Size(337, 42);
            this.Clear.TabIndex = 158;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.btnForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.ForeColor = System.Drawing.Color.White;
            this.btnForget.LinkColor = System.Drawing.Color.White;
            this.btnForget.Location = new System.Drawing.Point(68, 309);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(337, 42);
            this.btnForget.TabIndex = 157;
            this.btnForget.TabStop = true;
            this.btnForget.Text = "BACK_LOGIN";
            this.btnForget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnForget_LinkClicked);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Forgot_password_cuate;
            this.guna2PictureBox1.Location = new System.Drawing.Point(72, 54);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(333, 256);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 156;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblPrintPassword
            // 
            this.lblPrintPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.lblPrintPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintPassword.ForeColor = System.Drawing.Color.White;
            this.lblPrintPassword.Location = new System.Drawing.Point(488, 309);
            this.lblPrintPassword.Name = "lblPrintPassword";
            this.lblPrintPassword.Size = new System.Drawing.Size(262, 40);
            this.lblPrintPassword.TabIndex = 155;
            this.lblPrintPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetPassword
            // 
            this.GetPassword.BackColor = System.Drawing.Color.White;
            this.GetPassword.BorderRadius = 8;
            this.GetPassword.CheckedState.Parent = this.GetPassword;
            this.GetPassword.CustomImages.Parent = this.GetPassword;
            this.GetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.GetPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPassword.ForeColor = System.Drawing.Color.White;
            this.GetPassword.HoverState.Parent = this.GetPassword;
            this.GetPassword.Location = new System.Drawing.Point(576, 254);
            this.GetPassword.Name = "GetPassword";
            this.GetPassword.ShadowDecoration.Parent = this.GetPassword;
            this.GetPassword.Size = new System.Drawing.Size(174, 42);
            this.GetPassword.TabIndex = 154;
            this.GetPassword.Text = "Get_Password";
            this.GetPassword.Click += new System.EventHandler(this.GetPassword_Click);
            // 
            // EnterAnswer
            // 
            this.EnterAnswer.BackColor = System.Drawing.Color.White;
            this.EnterAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.EnterAnswer.BorderRadius = 8;
            this.EnterAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EnterAnswer.DefaultText = "";
            this.EnterAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EnterAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EnterAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EnterAnswer.DisabledState.Parent = this.EnterAnswer;
            this.EnterAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EnterAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EnterAnswer.FocusedState.Parent = this.EnterAnswer;
            this.EnterAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EnterAnswer.HoverState.Parent = this.EnterAnswer;
            this.EnterAnswer.Location = new System.Drawing.Point(491, 208);
            this.EnterAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnterAnswer.Name = "EnterAnswer";
            this.EnterAnswer.PasswordChar = '\0';
            this.EnterAnswer.PlaceholderText = "";
            this.EnterAnswer.SelectedText = "";
            this.EnterAnswer.ShadowDecoration.Parent = this.EnterAnswer;
            this.EnterAnswer.Size = new System.Drawing.Size(259, 36);
            this.EnterAnswer.TabIndex = 153;
            // 
            // GetQuestion
            // 
            this.GetQuestion.BackColor = System.Drawing.Color.White;
            this.GetQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.GetQuestion.BorderRadius = 8;
            this.GetQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GetQuestion.DefaultText = "";
            this.GetQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GetQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GetQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GetQuestion.DisabledState.Parent = this.GetQuestion;
            this.GetQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GetQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GetQuestion.FocusedState.Parent = this.GetQuestion;
            this.GetQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GetQuestion.HoverState.Parent = this.GetQuestion;
            this.GetQuestion.Location = new System.Drawing.Point(491, 161);
            this.GetQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetQuestion.Name = "GetQuestion";
            this.GetQuestion.PasswordChar = '\0';
            this.GetQuestion.PlaceholderText = "";
            this.GetQuestion.ReadOnly = true;
            this.GetQuestion.SelectedText = "";
            this.GetQuestion.ShadowDecoration.Parent = this.GetQuestion;
            this.GetQuestion.Size = new System.Drawing.Size(259, 36);
            this.GetQuestion.TabIndex = 152;
            // 
            // btnGetQuestion
            // 
            this.btnGetQuestion.BackColor = System.Drawing.Color.White;
            this.btnGetQuestion.BorderRadius = 8;
            this.btnGetQuestion.CheckedState.Parent = this.btnGetQuestion;
            this.btnGetQuestion.CustomImages.Parent = this.btnGetQuestion;
            this.btnGetQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(22)))), ((int)(((byte)(127)))));
            this.btnGetQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuestion.ForeColor = System.Drawing.Color.White;
            this.btnGetQuestion.HoverState.Parent = this.btnGetQuestion;
            this.btnGetQuestion.Location = new System.Drawing.Point(576, 111);
            this.btnGetQuestion.Name = "btnGetQuestion";
            this.btnGetQuestion.ShadowDecoration.Parent = this.btnGetQuestion;
            this.btnGetQuestion.Size = new System.Drawing.Size(174, 42);
            this.btnGetQuestion.TabIndex = 151;
            this.btnGetQuestion.Text = "Get_Question";
            this.btnGetQuestion.Click += new System.EventHandler(this.btnGetQuestion_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.Username.BorderRadius = 8;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.Parent = this.Username;
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.FocusedState.Parent = this.Username;
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.HoverState.Parent = this.Username;
            this.Username.Location = new System.Drawing.Point(491, 67);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderText = "";
            this.Username.SelectedText = "";
            this.Username.ShadowDecoration.Parent = this.Username;
            this.Username.Size = new System.Drawing.Size(259, 36);
            this.Username.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 148;
            this.label1.Text = "User_Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.macos_close_32px;
            this.button1.Location = new System.Drawing.Point(772, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 38);
            this.button1.TabIndex = 146;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 410);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button GetPassword;
        private Guna.UI2.WinForms.Guna2TextBox EnterAnswer;
        private Guna.UI2.WinForms.Guna2TextBox GetQuestion;
        private Guna.UI2.WinForms.Guna2Button btnGetQuestion;
        private System.Windows.Forms.Label lblPrintPassword;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.LinkLabel btnForget;
        private Guna.UI2.WinForms.Guna2Button Clear;
    }
}