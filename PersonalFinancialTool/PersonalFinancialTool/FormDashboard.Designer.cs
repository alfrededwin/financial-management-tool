
namespace PersonalFinancialTool
{
    partial class FormDashboard
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
            this.tabControlDashboard = new System.Windows.Forms.TabControl();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.tabPageEvent = new System.Windows.Forms.TabPage();
            this.tabPagePrediction = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageTransaction = new System.Windows.Forms.TabPage();
            this.tabControlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDashboard
            // 
            this.tabControlDashboard.Controls.Add(this.tabPageTransaction);
            this.tabControlDashboard.Controls.Add(this.tabPageCategory);
            this.tabControlDashboard.Controls.Add(this.tabPageEvent);
            this.tabControlDashboard.Controls.Add(this.tabPagePrediction);
            this.tabControlDashboard.Controls.Add(this.tabPageReport);
            this.tabControlDashboard.Controls.Add(this.tabPageSettings);
            this.tabControlDashboard.Location = new System.Drawing.Point(2, 1);
            this.tabControlDashboard.Name = "tabControlDashboard";
            this.tabControlDashboard.SelectedIndex = 0;
            this.tabControlDashboard.Size = new System.Drawing.Size(800, 449);
            this.tabControlDashboard.TabIndex = 0;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(792, 423);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // tabPageEvent
            // 
            this.tabPageEvent.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvent.Name = "tabPageEvent";
            this.tabPageEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvent.Size = new System.Drawing.Size(792, 423);
            this.tabPageEvent.TabIndex = 2;
            this.tabPageEvent.Text = "Event";
            this.tabPageEvent.UseVisualStyleBackColor = true;
            // 
            // tabPagePrediction
            // 
            this.tabPagePrediction.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrediction.Name = "tabPagePrediction";
            this.tabPagePrediction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrediction.Size = new System.Drawing.Size(792, 423);
            this.tabPagePrediction.TabIndex = 3;
            this.tabPagePrediction.Text = "Prediction";
            this.tabPagePrediction.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(792, 423);
            this.tabPageReport.TabIndex = 4;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(792, 423);
            this.tabPageSettings.TabIndex = 5;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageTransaction
            // 
            this.tabPageTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransaction.Name = "tabPageTransaction";
            this.tabPageTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransaction.Size = new System.Drawing.Size(792, 423);
            this.tabPageTransaction.TabIndex = 0;
            this.tabPageTransaction.Text = "Transaction";
            this.tabPageTransaction.UseVisualStyleBackColor = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlDashboard);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.tabControlDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDashboard;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TabPage tabPageEvent;
        private System.Windows.Forms.TabPage tabPagePrediction;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageTransaction;
    }
}