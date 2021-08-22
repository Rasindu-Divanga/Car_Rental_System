namespace CarRentalUI
{
    partial class ManageUsers
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
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUserListing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserListing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Location = new System.Drawing.Point(606, 426);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(208, 40);
            this.btnDeactivateUser.TabIndex = 16;
            this.btnDeactivateUser.Text = "Deactivate/Activate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(302, 426);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(208, 40);
            this.btnResetPassword.TabIndex = 15;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(12, 426);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(208, 40);
            this.btnAddUsers.TabIndex = 14;
            this.btnAddUsers.Text = "Add New User";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvUserListing
            // 
            this.gvUserListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserListing.Location = new System.Drawing.Point(12, 117);
            this.gvUserListing.Name = "gvUserListing";
            this.gvUserListing.RowTemplate.Height = 24;
            this.gvUserListing.Size = new System.Drawing.Size(802, 290);
            this.gvUserListing.TabIndex = 12;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 498);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvUserListing);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUserListing;
    }
}