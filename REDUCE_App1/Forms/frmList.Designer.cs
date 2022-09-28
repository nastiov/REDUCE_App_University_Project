namespace REDUCE_App1
{
    partial class frmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmList));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Упаковка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetAllUsersListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allUsersLists = new REDUCE_App1.AllUsersLists();
            this.sp_GetAllUsersListsTableAdapter = new REDUCE_App1.AllUsersListsTableAdapters.sp_GetAllUsersListsTableAdapter();
            this.pNewUsre = new System.Windows.Forms.Panel();
            this.labNewUsre = new System.Windows.Forms.Label();
            this.WeekTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersListsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allUsersLists)).BeginInit();
            this.pNewUsre.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(24, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(796, 159);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.Hint.SetToolTip(this.richTextBox1, "В этом поле выведен список продуктов на выбранный период");
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(24, 292);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(796, 96);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.Hint.SetToolTip(this.richTextBox2, "В этом поле вы можите дополнить свой список продуктов");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(24, 414);
            this.button1.MaximumSize = new System.Drawing.Size(192, 23);
            this.button1.MinimumSize = new System.Drawing.Size(192, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Изменить";
            this.Hint.SetToolTip(this.button1, "Нажмите для внесения изменений в основной список проуктов");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(225, 414);
            this.btSave.MaximumSize = new System.Drawing.Size(192, 23);
            this.btSave.MinimumSize = new System.Drawing.Size(192, 23);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(192, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Сохранить файл";
            this.Hint.SetToolTip(this.btSave, "Нажмите для сохранения текстового файла");
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCancel.Location = new System.Drawing.Point(423, 414);
            this.bCancel.MaximumSize = new System.Drawing.Size(192, 23);
            this.bCancel.MinimumSize = new System.Drawing.Size(192, 23);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(192, 23);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Вернуться назад";
            this.Hint.SetToolTip(this.bCancel, "Выход из обзора списка продуктов");
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lab1
            // 
            this.lab1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab1.Location = new System.Drawing.Point(178, 9);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(482, 46);
            this.lab1.TabIndex = 16;
            this.lab1.Text = "Обзор списка продуктов";
            // 
            // lab2
            // 
            this.lab2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(21, 276);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(105, 13);
            this.lab2.TabIndex = 17;
            this.lab2.Text = "Дополнить список:";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(628, 414);
            this.button4.MaximumSize = new System.Drawing.Size(192, 23);
            this.button4.MinimumSize = new System.Drawing.Size(192, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Запрос Администратору";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Понедельник";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Воскресенье";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "Файлы RTF|*.rtf";
            this.saveFileDialog1.FileName = "List";
            this.saveFileDialog1.Filter = "Файлы RTF|*.rtf|Текстовый документ|*.txt|Все файлы|*.*";
            this.saveFileDialog1.InitialDirectory = "D:\\";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pductNameDataGridViewTextBoxColumn,
            this.Упаковка,
            this.Unit,
            this.Amount,
            this.up,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spGetAllUsersListsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(796, 159);
            this.dataGridView1.TabIndex = 24;
            // 
            // pductNameDataGridViewTextBoxColumn
            // 
            this.pductNameDataGridViewTextBoxColumn.DataPropertyName = "PductName";
            this.pductNameDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.pductNameDataGridViewTextBoxColumn.Name = "pductNameDataGridViewTextBoxColumn";
            this.pductNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Упаковка
            // 
            this.Упаковка.DataPropertyName = "Quant";
            this.Упаковка.HeaderText = "Упаковка";
            this.Упаковка.Name = "Упаковка";
            this.Упаковка.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "в уп.";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Кол-во";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // up
            // 
            this.up.DataPropertyName = "up";
            this.up.HeaderText = " ";
            this.up.Name = "up";
            this.up.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость покупки";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spGetAllUsersListsBindingSource
            // 
            this.spGetAllUsersListsBindingSource.DataMember = "sp_GetAllUsersLists";
            this.spGetAllUsersListsBindingSource.DataSource = this.allUsersLists;
            // 
            // allUsersLists
            // 
            this.allUsersLists.DataSetName = "AllUsersLists";
            this.allUsersLists.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetAllUsersListsTableAdapter
            // 
            this.sp_GetAllUsersListsTableAdapter.ClearBeforeFill = true;
            // 
            // pNewUsre
            // 
            this.pNewUsre.Controls.Add(this.labNewUsre);
            this.pNewUsre.Location = new System.Drawing.Point(24, 106);
            this.pNewUsre.Name = "pNewUsre";
            this.pNewUsre.Size = new System.Drawing.Size(796, 159);
            this.pNewUsre.TabIndex = 25;
            this.pNewUsre.Visible = false;
            // 
            // labNewUsre
            // 
            this.labNewUsre.AutoSize = true;
            this.labNewUsre.Location = new System.Drawing.Point(342, 67);
            this.labNewUsre.Name = "labNewUsre";
            this.labNewUsre.Size = new System.Drawing.Size(51, 13);
            this.labNewUsre.TabIndex = 0;
            this.labNewUsre.Text = "NewUsre";
            this.labNewUsre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WeekTimer
            // 
            this.WeekTimer.Enabled = true;
            this.WeekTimer.Interval = 1000;
            this.WeekTimer.Tick += new System.EventHandler(this.WeekTimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(430, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 33);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Период:     ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "    -    ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.rbMonth);
            this.panel1.Controls.Add(this.rbWeek);
            this.panel1.Controls.Add(this.rbToday);
            this.panel1.Location = new System.Drawing.Point(24, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 41);
            this.panel1.TabIndex = 27;
            this.Hint.SetToolTip(this.panel1, "Выберите период просмотра продуктов");
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Location = new System.Drawing.Point(3, 6);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(112, 17);
            this.rbToday.TabIndex = 0;
            this.rbToday.Text = "меню на сегодня";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.Visible = false;
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Checked = true;
            this.rbWeek.Location = new System.Drawing.Point(126, 6);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(109, 17);
            this.rbWeek.TabIndex = 1;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "меню на неделю";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(250, 6);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(103, 17);
            this.rbMonth.TabIndex = 2;
            this.rbMonth.Text = "меню на месяц";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(845, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pNewUsre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmList";
            this.Text = "REDUCE : Просмотр списка продуктов";
            this.Hint.SetToolTip(this, "В данном окне выводится список продуктов на основе рациона питания");
            this.Load += new System.EventHandler(this.frmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersListsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allUsersLists)).EndInit();
            this.pNewUsre.ResumeLayout(false);
            this.pNewUsre.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AllUsersLists allUsersLists;
        private System.Windows.Forms.BindingSource spGetAllUsersListsBindingSource;
        private AllUsersListsTableAdapters.sp_GetAllUsersListsTableAdapter sp_GetAllUsersListsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pNewUsre;
        private System.Windows.Forms.Label labNewUsre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Упаковка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn up;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer WeekTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.RadioButton rbToday;
    }
}