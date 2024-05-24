namespace DashBoard.UserControls
{
    partial class UC_OrderHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.Transaction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order History";
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction,
            this.Amount,
            this.Date,
            this.Status});
            this.dgvOrderHistory.Location = new System.Drawing.Point(99, 168);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.Size = new System.Drawing.Size(614, 467);
            this.dgvOrderHistory.TabIndex = 17;
            this.dgvOrderHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderHistory_CellContentClick);
            // 
            // Transaction
            // 
            this.Transaction.HeaderText = "Transaction";
            this.Transaction.Name = "Transaction";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(744, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 565);
            this.panel1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 26);
            this.textBox1.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(544, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 27);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(638, 131);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 27);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // UC_OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrderHistory);
            this.Controls.Add(this.label1);
            this.Name = "UC_OrderHistory";
            this.Size = new System.Drawing.Size(1110, 677);
            this.Load += new System.EventHandler(this.UC_OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.DataGridViewButtonColumn Transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
    }
}
