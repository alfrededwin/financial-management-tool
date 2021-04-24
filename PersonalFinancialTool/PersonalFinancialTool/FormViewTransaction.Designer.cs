
namespace PersonalFinancialTool
{
    partial class FormViewTransaction
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
            this.buttonCreateTransaction = new System.Windows.Forms.Button();
            this.buttonUpdateTransaction = new System.Windows.Forms.Button();
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.contextMenuStripTransaction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.contextMenuStripTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateTransaction
            // 
            this.buttonCreateTransaction.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.buttonCreateTransaction.Location = new System.Drawing.Point(316, 337);
            this.buttonCreateTransaction.Name = "buttonCreateTransaction";
            this.buttonCreateTransaction.Size = new System.Drawing.Size(144, 30);
            this.buttonCreateTransaction.TabIndex = 30;
            this.buttonCreateTransaction.Text = "Create Transaction";
            this.buttonCreateTransaction.UseVisualStyleBackColor = true;
            this.buttonCreateTransaction.Click += new System.EventHandler(this.navCreateTransaction);
            // 
            // buttonUpdateTransaction
            // 
            this.buttonUpdateTransaction.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.buttonUpdateTransaction.Location = new System.Drawing.Point(466, 337);
            this.buttonUpdateTransaction.Name = "buttonUpdateTransaction";
            this.buttonUpdateTransaction.Size = new System.Drawing.Size(144, 30);
            this.buttonUpdateTransaction.TabIndex = 31;
            this.buttonUpdateTransaction.Text = "Update Transaction";
            this.buttonUpdateTransaction.UseVisualStyleBackColor = true;
            this.buttonUpdateTransaction.Click += new System.EventHandler(this.navUpdateTransaction);
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.Size = new System.Drawing.Size(972, 319);
            this.dataGridViewTransaction.TabIndex = 32;
            this.dataGridViewTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectTransactionRow);
            // 
            // contextMenuStripTransaction
            // 
            this.contextMenuStripTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStripTransaction.Name = "contextMenuStripTransaction";
            this.contextMenuStripTransaction.Size = new System.Drawing.Size(114, 26);
            this.contextMenuStripTransaction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuStripTransaction);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // FormViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 380);
            this.ContextMenuStrip = this.contextMenuStripTransaction;
            this.Controls.Add(this.dataGridViewTransaction);
            this.Controls.Add(this.buttonUpdateTransaction);
            this.Controls.Add(this.buttonCreateTransaction);
            this.MaximizeBox = false;
            this.Name = "FormViewTransaction";
            this.ShowIcon = false;
            this.Text = "View Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            this.contextMenuStripTransaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateTransaction;
        private System.Windows.Forms.Button buttonUpdateTransaction;
        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTransaction;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}