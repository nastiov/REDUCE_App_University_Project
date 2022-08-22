namespace REDUCE_App1
{
    partial class frmRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequest));
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.bSave = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.dB_REDUCE_request = new REDUCE_App1.DB_REDUCE_request();
            this.spRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_RequestTableAdapter = new REDUCE_App1.DB_REDUCE_requestTableAdapters.sp_RequestTableAdapter();
            this.iDrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_REDUCE_request)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AutoGenerateColumns = false;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDrequestDataGridViewTextBoxColumn,
            this.requestDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn});
            this.dgvRequest.DataSource = this.spRequestBindingSource;
            this.dgvRequest.Location = new System.Drawing.Point(11, 11);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.Size = new System.Drawing.Size(712, 376);
            this.dgvRequest.TabIndex = 0;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(507, 418);
            this.bSave.MaximumSize = new System.Drawing.Size(75, 23);
            this.bSave.MinimumSize = new System.Drawing.Size(75, 23);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(426, 418);
            this.bAdd.MaximumSize = new System.Drawing.Size(75, 23);
            this.bAdd.MinimumSize = new System.Drawing.Size(75, 23);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "Добавить поле";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bFind
            // 
            this.bFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bFind.Location = new System.Drawing.Point(332, 418);
            this.bFind.MaximumSize = new System.Drawing.Size(75, 23);
            this.bFind.MinimumSize = new System.Drawing.Size(75, 23);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 13;
            this.bFind.Text = "Поиск";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSearchValue.Location = new System.Drawing.Point(10, 418);
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(316, 20);
            this.tbSearchValue.TabIndex = 12;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCancel.Location = new System.Drawing.Point(600, 418);
            this.bCancel.MaximumSize = new System.Drawing.Size(123, 23);
            this.bCancel.MinimumSize = new System.Drawing.Size(123, 23);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(123, 23);
            this.bCancel.TabIndex = 17;
            this.bCancel.Text = "Вернуться назад";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dB_REDUCE_request
            // 
            this.dB_REDUCE_request.DataSetName = "DB_REDUCE_request";
            this.dB_REDUCE_request.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spRequestBindingSource
            // 
            this.spRequestBindingSource.DataMember = "sp_Request";
            this.spRequestBindingSource.DataSource = this.dB_REDUCE_request;
            // 
            // sp_RequestTableAdapter
            // 
            this.sp_RequestTableAdapter.ClearBeforeFill = true;
            // 
            // iDrequestDataGridViewTextBoxColumn
            // 
            this.iDrequestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDrequestDataGridViewTextBoxColumn.DataPropertyName = "ID_request";
            this.iDrequestDataGridViewTextBoxColumn.HeaderText = "№ запроса";
            this.iDrequestDataGridViewTextBoxColumn.Name = "iDrequestDataGridViewTextBoxColumn";
            this.iDrequestDataGridViewTextBoxColumn.Width = 88;
            // 
            // requestDataGridViewTextBoxColumn
            // 
            this.requestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.requestDataGridViewTextBoxColumn.DataPropertyName = "Request";
            this.requestDataGridViewTextBoxColumn.HeaderText = "Тип запроса";
            this.requestDataGridViewTextBoxColumn.Name = "requestDataGridViewTextBoxColumn";
            this.requestDataGridViewTextBoxColumn.Width = 96;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO_request";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ваше ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 89;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Текст";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 62;
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.dgvRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(749, 489);
            this.Name = "frmRequest";
            this.Text = "REDUCE : Запрос администратору.";
            this.Load += new System.EventHandler(this.frmRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_REDUCE_request)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRequestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.Button bCancel;
        private DB_REDUCE_request dB_REDUCE_request;
        private System.Windows.Forms.BindingSource spRequestBindingSource;
        private DB_REDUCE_requestTableAdapters.sp_RequestTableAdapter sp_RequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDrequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
    }
}