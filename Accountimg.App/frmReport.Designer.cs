﻿
namespace Accountimg.App
{
    partial class frmReport
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEditTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnPrintTransaction = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditTransaction,
            this.btnDeleteTransaction,
            this.btnRefreshTransaction,
            this.btnPrintTransaction});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(665, 97);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Image = global::Accountimg.App.Properties.Resources.edit_trans;
            this.btnEditTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(80, 94);
            this.btnEditTransaction.Text = "Edit Trans.";
            this.btnEditTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditTransaction.Click += new System.EventHandler(this.btnEditTransaction_Click);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Image = global::Accountimg.App.Properties.Resources.delete_trans;
            this.btnDeleteTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(98, 94);
            this.btnDeleteTransaction.Text = "Delete Trans.";
            this.btnDeleteTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnRefreshTransaction
            // 
            this.btnRefreshTransaction.Image = global::Accountimg.App.Properties.Resources.refresh_report;
            this.btnRefreshTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshTransaction.Name = "btnRefreshTransaction";
            this.btnRefreshTransaction.Size = new System.Drawing.Size(74, 94);
            this.btnRefreshTransaction.Text = "Refresh";
            this.btnRefreshTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshTransaction.Click += new System.EventHandler(this.btnRefreshTransaction_Click);
            // 
            // btnPrintTransaction
            // 
            this.btnPrintTransaction.Image = global::Accountimg.App.Properties.Resources.print;
            this.btnPrintTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintTransaction.Name = "btnPrintTransaction";
            this.btnPrintTransaction.Size = new System.Drawing.Size(78, 94);
            this.btnPrintTransaction.Text = "Print";
            this.btnPrintTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(519, 17);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(413, 17);
            this.txtToDate.Mask = "00,00,0000";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(100, 23);
            this.txtToDate.TabIndex = 7;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(64, 16);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(169, 24);
            this.cbCustomer.TabIndex = 5;
            
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(275, 17);
            this.txtFromDate.Mask = "00,00,0000";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(100, 23);
            this.txtFromDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvReport.Location = new System.Drawing.Point(6, 147);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(647, 294);
            this.dgvReport.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "Customer";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            this.Column3.HeaderText = "Amount";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateTime";
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.HeaderText = "Description";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 453);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEditTransaction;
        private System.Windows.Forms.ToolStripButton btnDeleteTransaction;
        private System.Windows.Forms.ToolStripButton btnRefreshTransaction;
        private System.Windows.Forms.ToolStripButton btnPrintTransaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}