namespace Group_Project.UserControls
{
    partial class PasswordControlView
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
            this.lblCurrentLogins = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtPasswordVerfic = new System.Windows.Forms.TextBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cboAccess = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.pnlStandard = new System.Windows.Forms.Panel();
            this.lblPasswordVerific = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccess = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentLogins
            // 
            this.lblCurrentLogins.AutoSize = true;
            this.lblCurrentLogins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLogins.Location = new System.Drawing.Point(101, 23);
            this.lblCurrentLogins.Name = "lblCurrentLogins";
            this.lblCurrentLogins.Size = new System.Drawing.Size(133, 24);
            this.lblCurrentLogins.TabIndex = 1;
            this.lblCurrentLogins.Text = "Current Logins";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(136, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 18;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(58, 3);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(236, 64);
            this.cmdAdd.TabIndex = 17;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtPasswordVerfic
            // 
            this.txtPasswordVerfic.Location = new System.Drawing.Point(136, 145);
            this.txtPasswordVerfic.Name = "txtPasswordVerfic";
            this.txtPasswordVerfic.PasswordChar = '*';
            this.txtPasswordVerfic.ReadOnly = true;
            this.txtPasswordVerfic.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordVerfic.TabIndex = 20;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(58, 73);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(236, 64);
            this.cmdUpdate.TabIndex = 21;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(58, 143);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(236, 64);
            this.cmdDelete.TabIndex = 22;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cboAccess
            // 
            this.cboAccess.FormattingEnabled = true;
            this.cboAccess.Location = new System.Drawing.Point(136, 92);
            this.cboAccess.Name = "cboAccess";
            this.cboAccess.Size = new System.Drawing.Size(100, 21);
            this.cboAccess.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.CausesValidation = false;
            this.txtPassword.Location = new System.Drawing.Point(136, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Controls.Add(this.splitContainer1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(728, 437);
            this.panel8.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPasswords);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentLogins);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlAdmin);
            this.splitContainer1.Panel2.Controls.Add(this.lblPasswordVerific);
            this.splitContainer1.Panel2.Controls.Add(this.lblPassword);
            this.splitContainer1.Panel2.Controls.Add(this.lblAccess);
            this.splitContainer1.Panel2.Controls.Add(this.lblUsername);
            this.splitContainer1.Panel2.Controls.Add(this.txtPassword);
            this.splitContainer1.Panel2.Controls.Add(this.cboAccess);
            this.splitContainer1.Panel2.Controls.Add(this.txtPasswordVerfic);
            this.splitContainer1.Panel2.Controls.Add(this.txtUsername);
            this.splitContainer1.Size = new System.Drawing.Size(728, 437);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 26;
            // 
            // dgvPasswords
            // 
            this.dgvPasswords.AllowUserToAddRows = false;
            this.dgvPasswords.AllowUserToDeleteRows = false;
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPasswords.Location = new System.Drawing.Point(10, 50);
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.ReadOnly = true;
            this.dgvPasswords.RowHeadersVisible = false;
            this.dgvPasswords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasswords.Size = new System.Drawing.Size(314, 377);
            this.dgvPasswords.TabIndex = 2;
            this.dgvPasswords.SelectionChanged += new System.EventHandler(this.dgvPasswords_SelectionChanged);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.pnlEdit);
            this.pnlAdmin.Controls.Add(this.pnlStandard);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 230);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(390, 207);
            this.pnlAdmin.TabIndex = 31;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.cmdCancel);
            this.pnlEdit.Controls.Add(this.cmdConfirm);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(390, 207);
            this.pnlEdit.TabIndex = 0;
            this.pnlEdit.Visible = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(58, 73);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(236, 64);
            this.cmdCancel.TabIndex = 19;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Location = new System.Drawing.Point(58, 3);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(236, 64);
            this.cmdConfirm.TabIndex = 18;
            this.cmdConfirm.Text = "Confirm";
            this.cmdConfirm.UseVisualStyleBackColor = true;
            this.cmdConfirm.Click += new System.EventHandler(this.cmdConfirm_Click);
            // 
            // pnlStandard
            // 
            this.pnlStandard.Controls.Add(this.cmdAdd);
            this.pnlStandard.Controls.Add(this.cmdUpdate);
            this.pnlStandard.Controls.Add(this.cmdDelete);
            this.pnlStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStandard.Location = new System.Drawing.Point(0, 0);
            this.pnlStandard.Name = "pnlStandard";
            this.pnlStandard.Size = new System.Drawing.Size(390, 207);
            this.pnlStandard.TabIndex = 23;
            // 
            // lblPasswordVerific
            // 
            this.lblPasswordVerific.AutoSize = true;
            this.lblPasswordVerific.Location = new System.Drawing.Point(55, 148);
            this.lblPasswordVerific.Name = "lblPasswordVerific";
            this.lblPasswordVerific.Size = new System.Drawing.Size(59, 13);
            this.lblPasswordVerific.TabIndex = 30;
            this.lblPasswordVerific.Text = "Verification";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Password";
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.Location = new System.Drawing.Point(55, 95);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(75, 13);
            this.lblAccess.TabIndex = 27;
            this.lblAccess.Text = "Access Rights";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(55, 64);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username";
            // 
            // PasswordControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Name = "PasswordControlView";
            this.Size = new System.Drawing.Size(728, 437);
            this.panel8.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlStandard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentLogins;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtPasswordVerfic;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.ComboBox cboAccess;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblPasswordVerific;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvPasswords;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlStandard;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdConfirm;
    }
}
