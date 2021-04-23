
namespace PersonalFinancialTool
{
    partial class FormWeeklyView
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
            this.groupBoxWeeklyView = new System.Windows.Forms.GroupBox();
            this.buttonViewWeekly = new System.Windows.Forms.Button();
            this.dateTimePickerWeeklyView = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.groupBoxWeeklyView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWeeklyView
            // 
            this.groupBoxWeeklyView.Controls.Add(this.buttonViewWeekly);
            this.groupBoxWeeklyView.Controls.Add(this.dateTimePickerWeeklyView);
            this.groupBoxWeeklyView.Controls.Add(this.labelEndDate);
            this.groupBoxWeeklyView.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.groupBoxWeeklyView.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWeeklyView.Name = "groupBoxWeeklyView";
            this.groupBoxWeeklyView.Size = new System.Drawing.Size(752, 71);
            this.groupBoxWeeklyView.TabIndex = 2;
            this.groupBoxWeeklyView.TabStop = false;
            this.groupBoxWeeklyView.Text = "Weekly View Criteria";
            // 
            // buttonViewWeekly
            // 
            this.buttonViewWeekly.Location = new System.Drawing.Point(200, 27);
            this.buttonViewWeekly.Name = "buttonViewWeekly";
            this.buttonViewWeekly.Size = new System.Drawing.Size(85, 23);
            this.buttonViewWeekly.TabIndex = 2;
            this.buttonViewWeekly.Text = "View ";
            this.buttonViewWeekly.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerWeeklyView
            // 
            this.dateTimePickerWeeklyView.CustomFormat = "dd MMM yyyy";
            this.dateTimePickerWeeklyView.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerWeeklyView.Location = new System.Drawing.Point(68, 27);
            this.dateTimePickerWeeklyView.Name = "dateTimePickerWeeklyView";
            this.dateTimePickerWeeklyView.Size = new System.Drawing.Size(116, 23);
            this.dateTimePickerWeeklyView.TabIndex = 1;
            this.dateTimePickerWeeklyView.ValueChanged += new System.EventHandler(this.dateTimePickerWeeklyView_ValueChanged);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(6, 33);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(56, 15);
            this.labelEndDate.TabIndex = 0;
            this.labelEndDate.Text = "End Date";
            // 
            // FormWeeklyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.groupBoxWeeklyView);
            this.Name = "FormWeeklyView";
            this.ShowIcon = false;
            this.Text = "Weekly View";
            this.groupBoxWeeklyView.ResumeLayout(false);
            this.groupBoxWeeklyView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWeeklyView;
        private System.Windows.Forms.Button buttonViewWeekly;
        private System.Windows.Forms.DateTimePicker dateTimePickerWeeklyView;
        private System.Windows.Forms.Label labelEndDate;
    }
}