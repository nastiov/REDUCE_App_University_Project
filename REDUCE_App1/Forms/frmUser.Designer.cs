namespace REDUCE_App1
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.StatusTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.bLogOut = new System.Windows.Forms.Button();
            this.linfo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.spGetAllUsersMenusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetAllUsersDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.pNewUsre = new System.Windows.Forms.Panel();
            this.labNewUsre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersMenusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersDishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.pNewUsre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(808, 394);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.Hint.SetToolTip(this.dateTimePicker1, "Текущая дата");
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(821, 180);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.Hint.SetToolTip(this.monthCalendar1, "В этом окне вы можите выбрать дату для вывода меню на день");
            // 
            // StatusTime
            // 
            this.StatusTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusTime.Location = new System.Drawing.Point(808, 420);
            this.StatusTime.Name = "StatusTime";
            this.StatusTime.ReadOnly = true;
            this.StatusTime.Size = new System.Drawing.Size(183, 20);
            this.StatusTime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Обзор меню на день";
            // 
            // btnToMenu
            // 
            this.btnToMenu.Location = new System.Drawing.Point(12, 23);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(215, 34);
            this.btnToMenu.TabIndex = 9;
            this.btnToMenu.Text = "Просмотр меню";
            this.Hint.SetToolTip(this.btnToMenu, "Для выбора подробного меню ");
            this.btnToMenu.UseVisualStyleBackColor = true;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Просмотр рецептов";
            this.Hint.SetToolTip(this.button2, "Для вывода списка продуктов для приготовлния");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Просмотр списка покупок";
            this.Hint.SetToolTip(this.button3, "Для вывода необходимого списка продуктов");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCancel.Location = new System.Drawing.Point(799, 542);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(192, 23);
            this.bCancel.TabIndex = 14;
            this.bCancel.Text = "Выход";
            this.Hint.SetToolTip(this.bCancel, "Выход из системы");
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(675, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 34);
            this.button4.TabIndex = 15;
            this.button4.Text = "Запрос Администратору";
            this.Hint.SetToolTip(this.button4, "Нажмите, чтобы сформировать запрос Администратору");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bLogOut
            // 
            this.bLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bLogOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bLogOut.Location = new System.Drawing.Point(799, 501);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(192, 23);
            this.bLogOut.TabIndex = 16;
            this.bLogOut.Text = "Сменить пользователя";
            this.Hint.SetToolTip(this.bLogOut, "Вернуться к окну авторизации");
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // linfo
            // 
            this.linfo.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linfo.AutoSize = true;
            this.linfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linfo.LinkColor = System.Drawing.Color.Goldenrod;
            this.linfo.Location = new System.Drawing.Point(837, 137);
            this.linfo.Name = "linfo";
            this.linfo.Size = new System.Drawing.Size(135, 13);
            this.linfo.TabIndex = 17;
            this.linfo.TabStop = true;
            this.linfo.Text = "Информация о компании";
            this.Hint.SetToolTip(this.linfo, "Нажмите для подробной информации о компании");
            this.linfo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linfo_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Текущая дата:";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 122);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(783, 442);
            this.dgvUser.TabIndex = 19;
            // 
            // pNewUsre
            // 
            this.pNewUsre.Controls.Add(this.labNewUsre);
            this.pNewUsre.Location = new System.Drawing.Point(22, 122);
            this.pNewUsre.Name = "pNewUsre";
            this.pNewUsre.Size = new System.Drawing.Size(694, 382);
            this.pNewUsre.TabIndex = 21;
            this.pNewUsre.Visible = false;
            // 
            // labNewUsre
            // 
            this.labNewUsre.AutoSize = true;
            this.labNewUsre.Location = new System.Drawing.Point(208, 86);
            this.labNewUsre.Name = "labNewUsre";
            this.labNewUsre.Size = new System.Drawing.Size(51, 13);
            this.labNewUsre.TabIndex = 0;
            this.labNewUsre.Text = "NewUsre";
            this.labNewUsre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(1003, 577);
            this.Controls.Add(this.pNewUsre);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linfo);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusTime);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.Text = "REDUCE : Добро пожаловать!";
            this.Hint.SetToolTip(this, "Текущее время");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersMenusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersDishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.pNewUsre.ResumeLayout(false);
            this.pNewUsre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox StatusTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.LinkLabel linfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealOfDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDishDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spGetAllUsersDishesBindingSource;
        private System.Windows.Forms.BindingSource spGetAllUsersMenusBindingSource;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Panel pNewUsre;
        private System.Windows.Forms.Label labNewUsre;
    }
}