namespace REDUCE_App1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.dgwMenu = new System.Windows.Forms.DataGridView();
            this.labNewUsre = new System.Windows.Forms.Label();
            this.pNewUsre = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).BeginInit();
            this.pNewUsre.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(968, 622);
            this.button4.MinimumSize = new System.Drawing.Size(284, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(284, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Запрос Администратору";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1085, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1150, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 29;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1143, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(905, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 31;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCancel.Location = new System.Drawing.Point(72, 622);
            this.bCancel.MinimumSize = new System.Drawing.Size(192, 23);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(192, 23);
            this.bCancel.TabIndex = 32;
            this.bCancel.Text = "Вернуться назад";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dgwMenu
            // 
            this.dgwMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMenu.Location = new System.Drawing.Point(72, 121);
            this.dgwMenu.Name = "dgwMenu";
            this.dgwMenu.ReadOnly = true;
            this.dgwMenu.Size = new System.Drawing.Size(1180, 495);
            this.dgwMenu.TabIndex = 33;
            // 
            // labNewUsre
            // 
            this.labNewUsre.AutoSize = true;
            this.labNewUsre.Location = new System.Drawing.Point(226, 162);
            this.labNewUsre.Name = "labNewUsre";
            this.labNewUsre.Size = new System.Drawing.Size(51, 13);
            this.labNewUsre.TabIndex = 0;
            this.labNewUsre.Text = "NewUsre";
            this.labNewUsre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pNewUsre
            // 
            this.pNewUsre.Controls.Add(this.labNewUsre);
            this.pNewUsre.Location = new System.Drawing.Point(72, 121);
            this.pNewUsre.Name = "pNewUsre";
            this.pNewUsre.Size = new System.Drawing.Size(1180, 495);
            this.pNewUsre.TabIndex = 34;
            this.pNewUsre.Visible = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(1289, 657);
            this.Controls.Add(this.pNewUsre);
            this.Controls.Add(this.dgwMenu);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "REDUCE : Ваше персональное меню";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).EndInit();
            this.pNewUsre.ResumeLayout(false);
            this.pNewUsre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DataGridView dgwMenu;
        private System.Windows.Forms.Label labNewUsre;
        private System.Windows.Forms.Panel pNewUsre;
    }
}