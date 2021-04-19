
namespace PersonalFinancialTool
{
    partial class FormCreateEvent
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
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblLoginSubTitle = new System.Windows.Forms.Label();
            this.dateTimeEventDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoOneTime = new System.Windows.Forms.RadioButton();
            this.rdoRecurring = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnUpdateEvent.Location = new System.Drawing.Point(184, 188);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateEvent.TabIndex = 19;
            this.btnUpdateEvent.Text = "Update";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            this.btnUpdateEvent.Click += new System.EventHandler(this.UpdateEvent);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.btnCreateEvent.Location = new System.Drawing.Point(47, 188);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(131, 31);
            this.btnCreateEvent.TabIndex = 18;
            this.btnCreateEvent.Text = "Create";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.CreateEvent);
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.textBoxEventName.Location = new System.Drawing.Point(157, 69);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(208, 25);
            this.textBoxEventName.TabIndex = 15;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblEventDate.Location = new System.Drawing.Point(44, 114);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(77, 17);
            this.lblEventDate.TabIndex = 13;
            this.lblEventDate.Text = "Event Date";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblEventName.Location = new System.Drawing.Point(44, 77);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(44, 17);
            this.lblEventName.TabIndex = 12;
            this.lblEventName.Text = "Name";
            // 
            // lblLoginSubTitle
            // 
            this.lblLoginSubTitle.AutoSize = true;
            this.lblLoginSubTitle.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lblLoginSubTitle.Location = new System.Drawing.Point(44, 27);
            this.lblLoginSubTitle.Name = "lblLoginSubTitle";
            this.lblLoginSubTitle.Size = new System.Drawing.Size(301, 17);
            this.lblLoginSubTitle.TabIndex = 11;
            this.lblLoginSubTitle.Text = "Fill in the required fields to create a new Event.";
            // 
            // dateTimeEventDate
            // 
            this.dateTimeEventDate.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.dateTimeEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEventDate.Location = new System.Drawing.Point(157, 106);
            this.dateTimeEventDate.Name = "dateTimeEventDate";
            this.dateTimeEventDate.Size = new System.Drawing.Size(208, 25);
            this.dateTimeEventDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.label1.Location = new System.Drawing.Point(44, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Event Status";
            // 
            // rdoOneTime
            // 
            this.rdoOneTime.AutoSize = true;
            this.rdoOneTime.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.rdoOneTime.Location = new System.Drawing.Point(157, 147);
            this.rdoOneTime.Name = "rdoOneTime";
            this.rdoOneTime.Size = new System.Drawing.Size(86, 21);
            this.rdoOneTime.TabIndex = 22;
            this.rdoOneTime.TabStop = true;
            this.rdoOneTime.Text = "One Time";
            this.rdoOneTime.UseVisualStyleBackColor = true;
            // 
            // rdoRecurring
            // 
            this.rdoRecurring.AutoSize = true;
            this.rdoRecurring.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.rdoRecurring.Location = new System.Drawing.Point(263, 147);
            this.rdoRecurring.Name = "rdoRecurring";
            this.rdoRecurring.Size = new System.Drawing.Size(88, 21);
            this.rdoRecurring.TabIndex = 23;
            this.rdoRecurring.TabStop = true;
            this.rdoRecurring.Text = "Recurring";
            this.rdoRecurring.UseVisualStyleBackColor = true;
            // 
            // FormCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 294);
            this.Controls.Add(this.rdoRecurring);
            this.Controls.Add(this.rdoOneTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeEventDate);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblLoginSubTitle);
            this.MaximizeBox = false;
            this.Name = "FormCreateEvent";
            this.ShowIcon = false;
            this.Text = "Create Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblLoginSubTitle;
        private System.Windows.Forms.DateTimePicker dateTimeEventDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoOneTime;
        private System.Windows.Forms.RadioButton rdoRecurring;
        public System.Windows.Forms.Button btnUpdateEvent;
        public System.Windows.Forms.Button btnCreateEvent;
    }
}