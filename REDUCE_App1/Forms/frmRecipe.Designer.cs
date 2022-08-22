namespace REDUCE_App1
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.dgwRecipe = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealOfDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetAllUsersDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allUsersDishes = new REDUCE_App1.AllUsersDishes();
            this.bCancel = new System.Windows.Forms.Button();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dB_REDUCEDataSet = new REDUCE_App1.DB_REDUCEDataSet();
            this.dBREDUCEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetAllUsersDishesTableAdapter = new REDUCE_App1.AllUsersDishesTableAdapters.sp_GetAllUsersDishesTableAdapter();
            this.pNewUsre = new System.Windows.Forms.Panel();
            this.labNewUsre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersDishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allUsersDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_REDUCEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBREDUCEDataSetBindingSource)).BeginInit();
            this.pNewUsre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRecipe
            // 
            this.dgwRecipe.AllowUserToOrderColumns = true;
            this.dgwRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwRecipe.AutoGenerateColumns = false;
            this.dgwRecipe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.mealOfDayDataGridViewTextBoxColumn,
            this.pductNameDataGridViewTextBoxColumn,
            this.weightGoodsDataGridViewTextBoxColumn,
            this.Unit,
            this.instructionDataGridViewTextBoxColumn});
            this.dgwRecipe.DataSource = this.spGetAllUsersDishesBindingSource;
            this.dgwRecipe.Location = new System.Drawing.Point(12, 75);
            this.dgwRecipe.Name = "dgwRecipe";
            this.dgwRecipe.Size = new System.Drawing.Size(897, 462);
            this.dgwRecipe.TabIndex = 9;
            this.Hint.SetToolTip(this.dgwRecipe, "В данном окне список рецептов");
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ваше имя";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // mealOfDayDataGridViewTextBoxColumn
            // 
            this.mealOfDayDataGridViewTextBoxColumn.DataPropertyName = "MealOfDay";
            this.mealOfDayDataGridViewTextBoxColumn.HeaderText = "Прием пищи";
            this.mealOfDayDataGridViewTextBoxColumn.Name = "mealOfDayDataGridViewTextBoxColumn";
            this.mealOfDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pductNameDataGridViewTextBoxColumn
            // 
            this.pductNameDataGridViewTextBoxColumn.DataPropertyName = "PductName";
            this.pductNameDataGridViewTextBoxColumn.HeaderText = "Название продукта";
            this.pductNameDataGridViewTextBoxColumn.Name = "pductNameDataGridViewTextBoxColumn";
            // 
            // weightGoodsDataGridViewTextBoxColumn
            // 
            this.weightGoodsDataGridViewTextBoxColumn.DataPropertyName = "WeightGoods";
            this.weightGoodsDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightGoodsDataGridViewTextBoxColumn.Name = "weightGoodsDataGridViewTextBoxColumn";
            this.weightGoodsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "ед.измерения";
            this.Unit.Name = "Unit";
            // 
            // instructionDataGridViewTextBoxColumn
            // 
            this.instructionDataGridViewTextBoxColumn.DataPropertyName = "Instruction";
            this.instructionDataGridViewTextBoxColumn.HeaderText = "Рекомендации для приготовления";
            this.instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            // 
            // spGetAllUsersDishesBindingSource
            // 
            this.spGetAllUsersDishesBindingSource.DataMember = "sp_GetAllUsersDishes";
            this.spGetAllUsersDishesBindingSource.DataSource = this.allUsersDishes;
            // 
            // allUsersDishes
            // 
            this.allUsersDishes.DataSetName = "AllUsersDishes";
            this.allUsersDishes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCancel.Location = new System.Drawing.Point(717, 551);
            this.bCancel.MaximumSize = new System.Drawing.Size(192, 23);
            this.bCancel.MinimumSize = new System.Drawing.Size(192, 23);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(192, 23);
            this.bCancel.TabIndex = 21;
            this.bCancel.Text = "Вернуться назад";
            this.Hint.SetToolTip(this.bCancel, "Выход из обзора рецептов");
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // btnToMenu
            // 
            this.btnToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToMenu.Location = new System.Drawing.Point(12, 551);
            this.btnToMenu.MaximumSize = new System.Drawing.Size(192, 23);
            this.btnToMenu.MinimumSize = new System.Drawing.Size(192, 23);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(192, 23);
            this.btnToMenu.TabIndex = 19;
            this.btnToMenu.Text = "Вернуться в меню";
            this.Hint.SetToolTip(this.btnToMenu, "Для внесения изменений скорректируйте свое меню");
            this.btnToMenu.UseVisualStyleBackColor = true;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(216, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Обзор рецептов";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(310, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Запрос Администратору";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dB_REDUCEDataSet
            // 
            this.dB_REDUCEDataSet.DataSetName = "DB_REDUCEDataSet";
            this.dB_REDUCEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBREDUCEDataSetBindingSource
            // 
            this.dBREDUCEDataSetBindingSource.DataSource = this.dB_REDUCEDataSet;
            this.dBREDUCEDataSetBindingSource.Position = 0;
            // 
            // sp_GetAllUsersDishesTableAdapter
            // 
            this.sp_GetAllUsersDishesTableAdapter.ClearBeforeFill = true;
            // 
            // pNewUsre
            // 
            this.pNewUsre.Controls.Add(this.labNewUsre);
            this.pNewUsre.Location = new System.Drawing.Point(113, 102);
            this.pNewUsre.Name = "pNewUsre";
            this.pNewUsre.Size = new System.Drawing.Size(694, 382);
            this.pNewUsre.TabIndex = 23;
            this.pNewUsre.Visible = false;
            // 
            // labNewUsre
            // 
            this.labNewUsre.AutoSize = true;
            this.labNewUsre.Location = new System.Drawing.Point(226, 162);
            this.labNewUsre.Name = "labNewUsre";
            this.labNewUsre.Size = new System.Drawing.Size(51, 13);
            this.labNewUsre.TabIndex = 0;
            this.labNewUsre.Text = "NewUsre";
            this.labNewUsre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(921, 586);
            this.Controls.Add(this.pNewUsre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwRecipe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecipe";
            this.Text = "REDUCE : Просмотр рецептов";
            this.Load += new System.EventHandler(this.frmRecipe_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllUsersDishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allUsersDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_REDUCEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBREDUCEDataSetBindingSource)).EndInit();
            this.pNewUsre.ResumeLayout(false);
            this.pNewUsre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwRecipe;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.BindingSource dBREDUCEDataSetBindingSource;
        private DB_REDUCEDataSet dB_REDUCEDataSet;
        private AllUsersDishes allUsersDishes;
        private System.Windows.Forms.BindingSource spGetAllUsersDishesBindingSource;
        private AllUsersDishesTableAdapters.sp_GetAllUsersDishesTableAdapter sp_GetAllUsersDishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealOfDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pNewUsre;
        private System.Windows.Forms.Label labNewUsre;
    }
}