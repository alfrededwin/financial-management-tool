
namespace PersonalFinancialTool
{
    partial class FormCreateTransaction
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.dateTimeTransDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.comboBoxTransEventName = new System.Windows.Forms.ComboBox();
            this.textBoxTransDesc = new System.Windows.Forms.TextBox();
            this.labelTransEventName = new System.Windows.Forms.Label();
            this.lblTransDate = new System.Windows.Forms.Label();
            this.lblTransDesc = new System.Windows.Forms.Label();
            this.lblLoginSubTitle = new System.Windows.Forms.Label();
            this.comboBoxTransCategoryType = new System.Windows.Forms.ComboBox();
            this.labelTransactionCatType = new System.Windows.Forms.Label();
            this.cmbIncomeType = new System.Windows.Forms.ComboBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.lblExpense = new System.Windows.Forms.Label();
            this.textBoxTransAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblAmount.Location = new System.Drawing.Point(43, 260);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 17);
            this.lblAmount.TabIndex = 33;
            this.lblAmount.Text = "Amount";
            // 
            // dateTimeTransDate
            // 
            this.dateTimeTransDate.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.dateTimeTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTransDate.Location = new System.Drawing.Point(170, 215);
            this.dateTimeTransDate.Name = "dateTimeTransDate";
            this.dateTimeTransDate.Size = new System.Drawing.Size(208, 25);
            this.dateTimeTransDate.TabIndex = 32;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnUpdateEvent.Location = new System.Drawing.Point(183, 334);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateEvent.TabIndex = 31;
            this.btnUpdateEvent.Text = "Update";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnCreateEvent.Location = new System.Drawing.Point(46, 334);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnCreateEvent.TabIndex = 30;
            this.btnCreateEvent.Text = "Create";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.CreateTransaction);
            // 
            // comboBoxTransEventName
            // 
            this.comboBoxTransEventName.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboBoxTransEventName.FormattingEnabled = true;
            this.comboBoxTransEventName.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.comboBoxTransEventName.Location = new System.Drawing.Point(170, 291);
            this.comboBoxTransEventName.Name = "comboBoxTransEventName";
            this.comboBoxTransEventName.Size = new System.Drawing.Size(208, 25);
            this.comboBoxTransEventName.TabIndex = 29;
            // 
            // textBoxTransDesc
            // 
            this.textBoxTransDesc.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.textBoxTransDesc.Location = new System.Drawing.Point(170, 178);
            this.textBoxTransDesc.Name = "textBoxTransDesc";
            this.textBoxTransDesc.Size = new System.Drawing.Size(208, 25);
            this.textBoxTransDesc.TabIndex = 28;
            // 
            // labelTransEventName
            // 
            this.labelTransEventName.AutoSize = true;
            this.labelTransEventName.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.labelTransEventName.Location = new System.Drawing.Point(43, 294);
            this.labelTransEventName.Name = "labelTransEventName";
            this.labelTransEventName.Size = new System.Drawing.Size(84, 17);
            this.labelTransEventName.TabIndex = 27;
            this.labelTransEventName.Text = "Event Name";
            // 
            // lblTransDate
            // 
            this.lblTransDate.AutoSize = true;
            this.lblTransDate.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblTransDate.Location = new System.Drawing.Point(43, 223);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(114, 17);
            this.lblTransDate.TabIndex = 26;
            this.lblTransDate.Text = "Transaction Date";
            // 
            // lblTransDesc
            // 
            this.lblTransDesc.AutoSize = true;
            this.lblTransDesc.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblTransDesc.Location = new System.Drawing.Point(43, 186);
            this.lblTransDesc.Name = "lblTransDesc";
            this.lblTransDesc.Size = new System.Drawing.Size(81, 17);
            this.lblTransDesc.TabIndex = 25;
            this.lblTransDesc.Text = "Description";
            // 
            // lblLoginSubTitle
            // 
            this.lblLoginSubTitle.AutoSize = true;
            this.lblLoginSubTitle.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblLoginSubTitle.Location = new System.Drawing.Point(43, 33);
            this.lblLoginSubTitle.Name = "lblLoginSubTitle";
            this.lblLoginSubTitle.Size = new System.Drawing.Size(335, 17);
            this.lblLoginSubTitle.TabIndex = 24;
            this.lblLoginSubTitle.Text = "Fill in the required fields to create a new Transaction";
            // 
            // comboBoxTransCategoryType
            // 
            this.comboBoxTransCategoryType.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboBoxTransCategoryType.FormattingEnabled = true;
            this.comboBoxTransCategoryType.Items.AddRange(new object[] {
            "Income\t",
            "Expense"});
            this.comboBoxTransCategoryType.Location = new System.Drawing.Point(170, 70);
            this.comboBoxTransCategoryType.Name = "comboBoxTransCategoryType";
            this.comboBoxTransCategoryType.Size = new System.Drawing.Size(208, 25);
            this.comboBoxTransCategoryType.TabIndex = 37;
            // 
            // labelTransactionCatType
            // 
            this.labelTransactionCatType.AutoSize = true;
            this.labelTransactionCatType.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.labelTransactionCatType.Location = new System.Drawing.Point(43, 78);
            this.labelTransactionCatType.Name = "labelTransactionCatType";
            this.labelTransactionCatType.Size = new System.Drawing.Size(99, 17);
            this.labelTransactionCatType.TabIndex = 36;
            this.labelTransactionCatType.Text = "Category Type";
            // 
            // cmbIncomeType
            // 
            this.cmbIncomeType.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbIncomeType.FormattingEnabled = true;
            this.cmbIncomeType.Location = new System.Drawing.Point(170, 105);
            this.cmbIncomeType.Name = "cmbIncomeType";
            this.cmbIncomeType.Size = new System.Drawing.Size(208, 25);
            this.cmbIncomeType.TabIndex = 39;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblIncome.Location = new System.Drawing.Point(43, 113);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(107, 17);
            this.lblIncome.TabIndex = 38;
            this.lblIncome.Text = "Income (Payer)";
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Location = new System.Drawing.Point(170, 141);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(208, 25);
            this.cmbExpenseType.TabIndex = 41;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblExpense.Location = new System.Drawing.Point(43, 149);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(113, 17);
            this.lblExpense.TabIndex = 40;
            this.lblExpense.Text = "Expense (Payee)";
            // 
            // textBoxTransAmount
            // 
            this.textBoxTransAmount.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.textBoxTransAmount.Location = new System.Drawing.Point(170, 252);
            this.textBoxTransAmount.Name = "textBoxTransAmount";
            this.textBoxTransAmount.Size = new System.Drawing.Size(208, 25);
            this.textBoxTransAmount.TabIndex = 42;
            // 
            // FormCreateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.textBoxTransAmount);
            this.Controls.Add(this.cmbExpenseType);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.cmbIncomeType);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.comboBoxTransCategoryType);
            this.Controls.Add(this.labelTransactionCatType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dateTimeTransDate);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.comboBoxTransEventName);
            this.Controls.Add(this.textBoxTransDesc);
            this.Controls.Add(this.labelTransEventName);
            this.Controls.Add(this.lblTransDate);
            this.Controls.Add(this.lblTransDesc);
            this.Controls.Add(this.lblLoginSubTitle);
            this.MaximizeBox = false;
            this.Name = "FormCreateTransaction";
            this.Text = "Create Transaction";
            this.Load += new System.EventHandler(this.FormCreateTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DateTimePicker dateTimeTransDate;
        private System.Windows.Forms.ComboBox comboBoxTransEventName;
        private System.Windows.Forms.TextBox textBoxTransDesc;
        private System.Windows.Forms.Label labelTransEventName;
        private System.Windows.Forms.Label lblTransDate;
        private System.Windows.Forms.Label lblTransDesc;
        private System.Windows.Forms.Label lblLoginSubTitle;
        private System.Windows.Forms.ComboBox comboBoxTransCategoryType;
        private System.Windows.Forms.Label labelTransactionCatType;
        private System.Windows.Forms.ComboBox cmbIncomeType;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.ComboBox cmbExpenseType;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.TextBox textBoxTransAmount;
        public System.Windows.Forms.Button btnUpdateEvent;
        public System.Windows.Forms.Button btnCreateEvent;
    }
}