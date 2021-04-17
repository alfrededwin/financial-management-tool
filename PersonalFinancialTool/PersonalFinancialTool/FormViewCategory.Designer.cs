
namespace PersonalFinancialTool
{
    partial class FormViewCategory
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
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialToolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialToolDataSet = new PersonalFinancialTool.FinancialToolDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnUpdateCategory.Location = new System.Drawing.Point(384, 341);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateCategory.TabIndex = 25;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.navUpdateCategory);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnCreateCategory.Location = new System.Drawing.Point(247, 341);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(131, 31);
            this.btnCreateCategory.TabIndex = 24;
            this.btnCreateCategory.Text = "Create Category";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.navCreateCategory);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AutoGenerateColumns = false;
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.categoryDescriptionDataGridViewTextBoxColumn,
            this.categoryTypeDataGridViewTextBoxColumn});
            this.dataGridViewCategory.DataSource = this.categoriesBindingSource;
            this.dataGridViewCategory.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.Size = new System.Drawing.Size(752, 323);
            this.dataGridViewCategory.TabIndex = 26;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCategoryRow);
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // categoryDescriptionDataGridViewTextBoxColumn
            // 
            this.categoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CategoryDescription";
            this.categoryDescriptionDataGridViewTextBoxColumn.HeaderText = "CategoryDescription";
            this.categoryDescriptionDataGridViewTextBoxColumn.Name = "categoryDescriptionDataGridViewTextBoxColumn";
            // 
            // categoryTypeDataGridViewTextBoxColumn
            // 
            this.categoryTypeDataGridViewTextBoxColumn.DataPropertyName = "CategoryType";
            this.categoryTypeDataGridViewTextBoxColumn.HeaderText = "CategoryType";
            this.categoryTypeDataGridViewTextBoxColumn.Name = "categoryTypeDataGridViewTextBoxColumn";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.financialToolDataSetBindingSource;
            // 
            // financialToolDataSetBindingSource
            // 
            this.financialToolDataSetBindingSource.DataSource = this.financialToolDataSet;
            this.financialToolDataSetBindingSource.Position = 0;
            // 
            // financialToolDataSet
            // 
            this.financialToolDataSet.DataSetName = "FinancialToolDataSet";
            this.financialToolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnCreateCategory);
            this.Name = "FormViewCategory";
            this.Text = "View Category";
            this.Load += new System.EventHandler(this.FormViewCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.BindingSource financialToolDataSetBindingSource;
        private FinancialToolDataSet financialToolDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTypeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridViewCategory;
    }
}