
namespace PersonalFinancialTool
{
    partial class FormViewEvent
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
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnUpdateEvent.Location = new System.Drawing.Point(376, 341);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateEvent.TabIndex = 27;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnCreateEvent.Location = new System.Drawing.Point(239, 341);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnCreateEvent.TabIndex = 26;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // FormViewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Name = "FormViewEvent";
            this.Text = "View Event";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnCreateEvent;
    }
}