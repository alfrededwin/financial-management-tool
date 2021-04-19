
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
            this.components = new System.ComponentModel.Container();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.eventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialToolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialToolDataSet = new PersonalFinancialTool.FinancialToolDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).BeginInit();
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
            this.btnUpdateEvent.Click += new System.EventHandler(this.UpdateEvent);
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
            this.btnCreateEvent.Click += new System.EventHandler(this.navCreateEvent);
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.AutoGenerateColumns = false;
            this.dataGridViewEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIdDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventStatusDataGridViewTextBoxColumn});
            this.dataGridViewEvent.DataSource = this.eventsBindingSource;
            this.dataGridViewEvent.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.Size = new System.Drawing.Size(752, 323);
            this.dataGridViewEvent.TabIndex = 28;
            this.dataGridViewEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectEventRow);
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            this.eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            this.eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            this.eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            this.eventIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventStatusDataGridViewTextBoxColumn
            // 
            this.eventStatusDataGridViewTextBoxColumn.DataPropertyName = "EventStatus";
            this.eventStatusDataGridViewTextBoxColumn.HeaderText = "EventStatus";
            this.eventStatusDataGridViewTextBoxColumn.Name = "eventStatusDataGridViewTextBoxColumn";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.financialToolDataSetBindingSource;
            // 
            // financialToolDataSetBindingSource
            // 
            this.financialToolDataSetBindingSource.DataSource = this.financialToolDataSet;
            this.financialToolDataSetBindingSource.Position = 0;
            // 
            // financialToolDataSet
            // 
            this.financialToolDataSet.DataSetName = "FinancialToolDataSet";
            this.financialToolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormViewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.dataGridViewEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.MaximizeBox = false;
            this.Name = "FormViewEvent";
            this.ShowIcon = false;
            this.Text = "View Event";
            this.Load += new System.EventHandler(this.FormViewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialToolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private System.Windows.Forms.BindingSource financialToolDataSetBindingSource;
        private FinancialToolDataSet financialToolDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventStatusDataGridViewTextBoxColumn;
    }
}