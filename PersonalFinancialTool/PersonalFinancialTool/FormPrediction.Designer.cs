
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPrediction = new System.Windows.Forms.GroupBox();
            this.buttonViewPrediction = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chartPrediction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPrediction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrediction)).BeginInit();
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
            // buttonViewPrediction
            // 
            this.buttonViewPrediction.Location = new System.Drawing.Point(259, 27);
            this.buttonViewPrediction.Name = "buttonViewPrediction";
            this.buttonViewPrediction.Size = new System.Drawing.Size(127, 23);
            this.buttonViewPrediction.TabIndex = 2;
            this.buttonViewPrediction.Text = "View Prediction";
            this.buttonViewPrediction.UseVisualStyleBackColor = true;
            this.buttonViewPrediction.Click += new System.EventHandler(this.ViewPrediction);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // chartPrediction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrediction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrediction.Legends.Add(legend1);
            this.chartPrediction.Location = new System.Drawing.Point(177, 89);
            this.chartPrediction.Name = "chartPrediction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Average Category";
            this.chartPrediction.Series.Add(series1);
            this.chartPrediction.Size = new System.Drawing.Size(680, 279);
            this.chartPrediction.TabIndex = 2;
            this.chartPrediction.Text = "chart1";
            // 
            // FormPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 380);
            this.Controls.Add(this.chartPrediction);
            this.Controls.Add(this.groupBoxPrediction);
            this.MaximizeBox = false;
            this.Name = "FormPrediction";
            this.ShowIcon = false;
            this.Text = "Prediction";
            this.groupBoxPrediction.ResumeLayout(false);
            this.groupBoxPrediction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrediction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPrediction;
        private System.Windows.Forms.Button buttonViewPrediction;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrediction;
    }
}