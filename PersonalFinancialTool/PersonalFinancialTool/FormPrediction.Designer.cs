
namespace PersonalFinancialTool
{
    partial class FormPrediction
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPrediction = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonViewPrediction = new System.Windows.Forms.Button();
            this.groupBoxPrediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prediction Date";
            // 
            // groupBoxPrediction
            // 
            this.groupBoxPrediction.Controls.Add(this.buttonViewPrediction);
            this.groupBoxPrediction.Controls.Add(this.dateTimePicker1);
            this.groupBoxPrediction.Controls.Add(this.label1);
            this.groupBoxPrediction.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.groupBoxPrediction.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPrediction.Name = "groupBoxPrediction";
            this.groupBoxPrediction.Size = new System.Drawing.Size(752, 71);
            this.groupBoxPrediction.TabIndex = 1;
            this.groupBoxPrediction.TabStop = false;
            this.groupBoxPrediction.Text = "Prediction Criteria";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonViewPrediction
            // 
            this.buttonViewPrediction.Location = new System.Drawing.Point(259, 27);
            this.buttonViewPrediction.Name = "buttonViewPrediction";
            this.buttonViewPrediction.Size = new System.Drawing.Size(127, 23);
            this.buttonViewPrediction.TabIndex = 2;
            this.buttonViewPrediction.Text = "View Prediction";
            this.buttonViewPrediction.UseVisualStyleBackColor = true;
            // 
            // FormPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.groupBoxPrediction);
            this.Name = "FormPrediction";
            this.Text = "Prediction";
            this.groupBoxPrediction.ResumeLayout(false);
            this.groupBoxPrediction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPrediction;
        private System.Windows.Forms.Button buttonViewPrediction;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}