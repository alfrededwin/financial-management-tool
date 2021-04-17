
namespace PersonalFinancialTool
{
    partial class FormViewTransaction
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
            this.buttonCreateTransaction = new System.Windows.Forms.Button();
            this.buttonUpdateTransaction = new System.Windows.Forms.Button();
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.financialToolDataSet = new PersonalFinancialTool.FinancialToolDataSet();
            this.financialToolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateTransaction
            // 
            this.buttonCreateTransaction.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.buttonCreateTransaction.Location = new System.Drawing.Point(233, 341);
            this.buttonCreateTransaction.Name = "buttonCreateTransaction";
            this.buttonCreateTransaction.Size = new System.Drawing.Size(138, 31);
            this.buttonCreateTransaction.TabIndex = 30;
            this.buttonCreateTransaction.Text = "Create Transaction";
            this.buttonCreateTransaction.UseVisualStyleBackColor = true;
            this.buttonCreateTransaction.Click += new System.EventHandler(this.navCreateTransaction);
            // 
            // buttonUpdateTransaction
            // 
            this.buttonUpdateTransaction.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.buttonUpdateTransaction.Location = new System.Drawing.Point(377, 341);
            this.buttonUpdateTransaction.Name = "buttonUpdateTransaction";
            this.buttonUpdateTransaction.Size = new System.Drawing.Size(138, 31);
            this.buttonUpdateTransaction.TabIndex = 31;
            this.buttonUpdateTransaction.Text = "Update Transaction";
            this.buttonUpdateTransaction.UseVisualStyleBackColor = true;
            this.buttonUpdateTransaction.Click += new System.EventHandler(this.navUpdateTransaction);
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.AutoGenerateColumns = false;
            this.dataGridViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.categoryTypeDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.expenseDataGridViewTextBoxColumn,
            this.transDescriptionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.eventIdDataGridViewTextBoxColumn});
            this.dataGridViewTransaction.DataSource = this.transactionsBindingSource;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.Size = new System.Drawing.Size(752, 309);
            this.dataGridViewTransaction.TabIndex = 32;
            this.dataGridViewTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectTransactionRow);
            // 
            // financialToolDataSet
            // 
            this.financialToolDataSet.DataSetName = "FinancialToolDataSet";
            this.financialToolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financialToolDataSetBindingSource
            // 
            this.financialToolDataSetBindingSource.DataSource = this.financialToolDataSet;
            this.financialToolDataSetBindingSource.Position = 0;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.financialToolDataSetBindingSource;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryTypeDataGridViewTextBoxColumn
            // 
            this.categoryTypeDataGridViewTextBoxColumn.DataPropertyName = "CategoryType";
            this.categoryTypeDataGridViewTextBoxColumn.HeaderText = "CategoryType";
            this.categoryTypeDataGridViewTextBoxColumn.Name = "categoryTypeDataGridViewTextBoxColumn";
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            this.expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            this.expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            this.expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            // 
            // transDescriptionDataGridViewTextBoxColumn
            // 
            this.transDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TransDescription";
            this.transDescriptionDataGridViewTextBoxColumn.HeaderText = "TransDescription";
            this.transDescriptionDataGridViewTextBoxColumn.Name = "transDescriptionDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            this.eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            this.eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            this.eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            this.eventIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.dataGridViewTransaction);
            this.Controls.Add(this.buttonUpdateTransaction);
            this.Controls.Add(this.buttonCreateTransaction);
            this.Name = "FormViewTransaction";
            this.Text = "View Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateTransaction;
        private System.Windows.Forms.Button buttonUpdateTransaction;
        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private System.Windows.Forms.BindingSource financialToolDataSetBindingSource;
        private FinancialToolDataSet financialToolDataSet;
    }
}