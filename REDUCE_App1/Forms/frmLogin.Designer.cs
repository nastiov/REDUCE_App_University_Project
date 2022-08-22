namespace REDUCE_App1
{
    partial class frmLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.lSingUp = new System.Windows.Forms.LinkLabel();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.epLoginDialog = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPasswordDialog = new System.Windows.Forms.ErrorProvider(this.components);
            this.linfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.epLoginDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordDialog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // lSingUp
            // 
            this.lSingUp.ActiveLinkColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.lSingUp, "lSingUp");
            this.lSingUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lSingUp.LinkColor = System.Drawing.Color.Salmon;
            this.lSingUp.Name = "lSingUp";
            this.lSingUp.TabStop = true;
            this.Hint.SetToolTip(this.lSingUp, resources.GetString("lSingUp.ToolTip"));
            this.lSingUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lSingUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSingUp_LinkClicked);
            // 
            // cbShowPassword
            // 
            resources.ApplyResources(this.cbShowPassword, "cbShowPassword");
            this.cbShowPassword.Checked = true;
            this.cbShowPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowPassword.Name = "cbShowPassword";
            this.Hint.SetToolTip(this.cbShowPassword, resources.GetString("cbShowPassword.ToolTip"));
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // bCancel
            // 
            resources.ApplyResources(this.bCancel, "bCancel");
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Name = "bCancel";
            this.Hint.SetToolTip(this.bCancel, resources.GetString("bCancel.ToolTip"));
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bLogin
            // 
            resources.ApplyResources(this.bLogin, "bLogin");
            this.bLogin.Name = "bLogin";
            this.Hint.SetToolTip(this.bLogin, resources.GetString("bLogin.ToolTip"));
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            this.Hint.SetToolTip(this.tbPassword, resources.GetString("tbPassword.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // tbLogin
            // 
            resources.ApplyResources(this.tbLogin, "tbLogin");
            this.tbLogin.Name = "tbLogin";
            this.Hint.SetToolTip(this.tbLogin, resources.GetString("tbLogin.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // epLoginDialog
            // 
            this.epLoginDialog.ContainerControl = this;
            // 
            // epPasswordDialog
            // 
            this.epPasswordDialog.ContainerControl = this;
            // 
            // linfo
            // 
            this.linfo.ActiveLinkColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.linfo, "linfo");
            this.linfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linfo.LinkColor = System.Drawing.Color.Goldenrod;
            this.linfo.Name = "linfo";
            this.linfo.TabStop = true;
            this.Hint.SetToolTip(this.linfo, resources.GetString("linfo.ToolTip"));
            this.linfo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linfo_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.bLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.bCancel;
            this.Controls.Add(this.linfo);
            this.Controls.Add(this.lSingUp);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.epLoginDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordDialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lSingUp;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.ErrorProvider epLoginDialog;
        private System.Windows.Forms.ErrorProvider epPasswordDialog;
        private System.Windows.Forms.LinkLabel linfo;
    }
}

