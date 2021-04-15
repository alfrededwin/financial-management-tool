
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
            this.buttonCreateTransaction = new System.Windows.Forms.Button();
            this.buttonUpdateTransaction = new System.Windows.Forms.Button();
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
            // 
            // FormViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.buttonUpdateTransaction);
            this.Controls.Add(this.buttonCreateTransaction);
            this.Name = "FormViewTransaction";
            this.Text = "View Transaction";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateTransaction;
        private System.Windows.Forms.Button buttonUpdateTransaction;
    }
}