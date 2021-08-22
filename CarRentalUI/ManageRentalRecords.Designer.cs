namespace CarRentalUI
{
    partial class ManageRentalRecords
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvRecordListing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordListing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(677, 100);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 34);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(606, 459);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(208, 40);
            this.btnDeleteRecord.TabIndex = 10;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(302, 459);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(208, 40);
            this.btnEditRecord.TabIndex = 9;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(12, 459);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(208, 40);
            this.btnAddRecord.TabIndex = 8;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Rental Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvRecordListing
            // 
            this.gvRecordListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordListing.Location = new System.Drawing.Point(12, 150);
            this.gvRecordListing.Name = "gvRecordListing";
            this.gvRecordListing.RowTemplate.Height = 24;
            this.gvRecordListing.Size = new System.Drawing.Size(802, 290);
            this.gvRecordListing.TabIndex = 6;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 516);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvRecordListing);
            this.Name = "ManageRentalRecords";
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvRecordListing;
    }
}