
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
            this.components = new System.ComponentModel.Container();
            this.tabControlDashboard = new System.Windows.Forms.TabControl();
            this.tabPageTransaction = new System.Windows.Forms.TabPage();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.tabPageEvent = new System.Windows.Forms.TabPage();
            this.tabPagePrediction = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.btnUpdateTransaction = new System.Windows.Forms.Button();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.financialToolDataSet = new PersonalFinancialTool.FinancialToolDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlDashboard.SuspendLayout();
            this.tabPageTransaction.SuspendLayout();
            this.tabPageEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
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
            // tabPageTransaction
            // 
            this.tabPageTransaction.Controls.Add(this.btnUpdateTransaction);
            this.tabPageTransaction.Controls.Add(this.btnCreateTransaction);
            this.tabPageTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransaction.Name = "tabPageTransaction";
            this.tabPageTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransaction.Size = new System.Drawing.Size(792, 423);
            this.tabPageTransaction.TabIndex = 0;
            this.tabPageTransaction.Text = "Transaction";
            this.tabPageTransaction.UseVisualStyleBackColor = true;
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
            this.tabPageEvent.Controls.Add(this.btnUpdateEvent);
            this.tabPageEvent.Controls.Add(this.btnCreateEvent);
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
            // btnUpdateTransaction
            // 
            this.btnUpdateTransaction.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnUpdateTransaction.Location = new System.Drawing.Point(405, 367);
            this.btnUpdateTransaction.Name = "btnUpdateTransaction";
            this.btnUpdateTransaction.Size = new System.Drawing.Size(144, 31);
            this.btnUpdateTransaction.TabIndex = 21;
            this.btnUpdateTransaction.Text = "Update Transaction";
            this.btnUpdateTransaction.UseVisualStyleBackColor = true;
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnCreateTransaction.Location = new System.Drawing.Point(253, 367);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(146, 31);
            this.btnCreateTransaction.TabIndex = 20;
            this.btnCreateTransaction.Text = "Create Transaction";
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnUpdateEvent.Location = new System.Drawing.Point(396, 374);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateEvent.TabIndex = 23;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnCreateEvent.Location = new System.Drawing.Point(259, 374);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnCreateEvent.TabIndex = 22;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // financialToolDataSet
            // 
            this.financialToolDataSet.DataSetName = "FinancialToolDataSet";
            this.financialToolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.financialToolDataSet;
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
            this.tabPageTransaction.ResumeLayout(false);
            this.tabPageEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDashboard;
        private System.Windows.Forms.TabPage tabPageTransaction;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TabPage tabPageEvent;
        private System.Windows.Forms.TabPage tabPagePrediction;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button btnUpdateTransaction;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private FinancialToolDataSet financialToolDataSet;
    }
}