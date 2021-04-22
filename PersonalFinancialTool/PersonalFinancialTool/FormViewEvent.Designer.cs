
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
            this.contextMenuStripEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            this.contextMenuStripEvent.SuspendLayout();
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
            this.dataGridViewEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.Size = new System.Drawing.Size(752, 323);
            this.dataGridViewEvent.TabIndex = 28;
            this.dataGridViewEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectEventRow);
            // 
            // contextMenuStripEvent
            // 
            this.contextMenuStripEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.contextMenuStripEvent.Name = "contextMenuStripEvent";
            this.contextMenuStripEvent.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStripEvent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuStripViewEvent);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // FormViewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.ContextMenuStrip = this.contextMenuStripEvent;
            this.Controls.Add(this.dataGridViewEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.MaximizeBox = false;
            this.Name = "FormViewEvent";
            this.ShowIcon = false;
            this.Text = "View Event";
            this.Load += new System.EventHandler(this.FormViewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            this.contextMenuStripEvent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEvent;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}