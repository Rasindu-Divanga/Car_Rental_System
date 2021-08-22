namespace CarRentalUI
{
    partial class AddEditVehicles
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.LbTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtPlateNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtVIN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMake, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(341, 235);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(274, 22);
            this.txtPlateNumber.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(341, 177);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(274, 22);
            this.txtYear.TabIndex = 8;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(341, 119);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(274, 22);
            this.txtVIN.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(341, 61);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(274, 22);
            this.txtModel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Licence Plate Number";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(341, 3);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(274, 22);
            this.txtMake.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(290, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(290, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(104, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(0, 64);
            this.LbTitle.TabIndex = 3;
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(680, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Visible = false;
            // 
            // AddEditVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 462);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicles";
            this.Text = "Add, Edit Vehicle Details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label lblID;
    }
}