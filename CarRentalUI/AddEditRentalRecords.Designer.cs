namespace CarRentalUI
{
    partial class AddEditRentalRecords
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtRented = new System.Windows.Forms.DateTimePicker();
            this.DtReturned = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Rental Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(42, 174);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(251, 22);
            this.txtname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Rented";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Returned";
            // 
            // DtRented
            // 
            this.DtRented.Location = new System.Drawing.Point(42, 263);
            this.DtRented.Name = "DtRented";
            this.DtRented.Size = new System.Drawing.Size(200, 22);
            this.DtRented.TabIndex = 5;
            // 
            // DtReturned
            // 
            this.DtReturned.Location = new System.Drawing.Point(369, 263);
            this.DtReturned.Name = "DtReturned";
            this.DtReturned.Size = new System.Drawing.Size(200, 22);
            this.DtReturned.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type Of Car";
            // 
            // cmbCarType
            // 
            this.cmbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Location = new System.Drawing.Point(42, 353);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(200, 24);
            this.cmbCarType.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(369, 174);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(251, 22);
            this.txtCost.TabIndex = 11;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(366, 142);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(36, 17);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost";
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(705, 417);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 17);
            this.lblRecordId.TabIndex = 12;
            this.lblRecordId.Visible = false;
            // 
            // AddEditRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 460);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCarType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtReturned);
            this.Controls.Add(this.DtRented);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditRentalRecords";
            this.Text = "Add Rental Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtRented;
        private System.Windows.Forms.DateTimePicker DtReturned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblRecordId;
    }
}

