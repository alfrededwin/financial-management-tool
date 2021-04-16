
namespace PersonalFinancialTool
{
    partial class FormCreateCategory
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
            this.lblLoginSubTitle = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.labelCatType = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryDesc = new System.Windows.Forms.TextBox();
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginSubTitle
            // 
            this.lblLoginSubTitle.AutoSize = true;
            this.lblLoginSubTitle.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblLoginSubTitle.Location = new System.Drawing.Point(53, 26);
            this.lblLoginSubTitle.Name = "lblLoginSubTitle";
            this.lblLoginSubTitle.Size = new System.Drawing.Size(317, 17);
            this.lblLoginSubTitle.TabIndex = 2;
            this.lblLoginSubTitle.Text = "Fill in the required fields to create a new Category";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblCategoryName.Location = new System.Drawing.Point(53, 76);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(44, 17);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "Name";
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblCategoryDescription.Location = new System.Drawing.Point(53, 113);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(81, 17);
            this.lblCategoryDescription.TabIndex = 4;
            this.lblCategoryDescription.Text = "Description";
            // 
            // labelCatType
            // 
            this.labelCatType.AutoSize = true;
            this.labelCatType.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.labelCatType.Location = new System.Drawing.Point(53, 149);
            this.labelCatType.Name = "labelCatType";
            this.labelCatType.Size = new System.Drawing.Size(99, 17);
            this.labelCatType.TabIndex = 5;
            this.labelCatType.Text = "Category Type";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.textBoxCategoryName.Location = new System.Drawing.Point(166, 68);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(208, 25);
            this.textBoxCategoryName.TabIndex = 6;
            // 
            // textBoxCategoryDesc
            // 
            this.textBoxCategoryDesc.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.textBoxCategoryDesc.Location = new System.Drawing.Point(166, 105);
            this.textBoxCategoryDesc.Name = "textBoxCategoryDesc";
            this.textBoxCategoryDesc.Size = new System.Drawing.Size(208, 25);
            this.textBoxCategoryDesc.TabIndex = 7;
            // 
            // comboBoxCategoryType
            // 
            this.comboBoxCategoryType.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.comboBoxCategoryType.Location = new System.Drawing.Point(166, 141);
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            this.comboBoxCategoryType.Size = new System.Drawing.Size(208, 25);
            this.comboBoxCategoryType.TabIndex = 8;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnCreateCategory.Location = new System.Drawing.Point(56, 188);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(131, 31);
            this.btnCreateCategory.TabIndex = 9;
            this.btnCreateCategory.Text = "Create";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.CreateCategory);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnUpdateCategory.Location = new System.Drawing.Point(193, 188);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateCategory.TabIndex = 10;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.UpdateCategory);
            // 
            // FormCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.comboBoxCategoryType);
            this.Controls.Add(this.textBoxCategoryDesc);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelCatType);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblLoginSubTitle);
            this.MaximizeBox = false;
            this.Name = "FormCreateCategory";
            this.Text = "Create Category";
            this.Load += new System.EventHandler(this.FormCreateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginSubTitle;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label labelCatType;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        public System.Windows.Forms.TextBox textBoxCategoryName;
        public System.Windows.Forms.TextBox textBoxCategoryDesc;
        public System.Windows.Forms.ComboBox comboBoxCategoryType;
    }
}