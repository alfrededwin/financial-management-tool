
namespace PersonalFinancialTool
{
    partial class WeeklyViewValues
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelTransactionDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(8, 25);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(8, 44);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "Amount";
            // 
            // labelTransactionDesc
            // 
            this.labelTransactionDesc.AutoSize = true;
            this.labelTransactionDesc.Location = new System.Drawing.Point(8, 7);
            this.labelTransactionDesc.Name = "labelTransactionDesc";
            this.labelTransactionDesc.Size = new System.Drawing.Size(88, 13);
            this.labelTransactionDesc.TabIndex = 2;
            this.labelTransactionDesc.Text = "TransactionDesc";
            // 
            // WeeklyViewValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelTransactionDesc);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCategory);
            this.Name = "WeeklyViewValues";
            this.Size = new System.Drawing.Size(119, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelTransactionDesc;
    }
}
