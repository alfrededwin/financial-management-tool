﻿
namespace PersonalFinancialTool
{
    partial class WeeklyView
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
            this.panelWeekView = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelWeekView
            // 
            this.panelWeekView.Location = new System.Drawing.Point(0, 0);
            this.panelWeekView.Name = "panelWeekView";
            this.panelWeekView.Size = new System.Drawing.Size(138, 255);
            this.panelWeekView.TabIndex = 0;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(21, 258);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(90, 13);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total Transaction";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WeeklyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.panelWeekView);
            this.Name = "WeeklyView";
            this.Size = new System.Drawing.Size(138, 281);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWeekView;
        private System.Windows.Forms.Label lbltotal;
    }
}
