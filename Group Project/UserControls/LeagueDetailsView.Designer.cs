namespace Group_Project.UserControls
{
    partial class LeagueDetailsView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvLeagues = new System.Windows.Forms.DataGridView();
            this.lblCurrentLeagues = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.pnlStandard = new System.Windows.Forms.Panel();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblSponsor = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblLeagueName = new System.Windows.Forms.Label();
            this.txtSponsor = new System.Windows.Forms.TextBox();
            this.txtLeagueName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvLeagues);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentLeagues);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.nudCapacity);
            this.splitContainer1.Panel2.Controls.Add(this.pnlAdmin);
            this.splitContainer1.Panel2.Controls.Add(this.lblSponsor);
            this.splitContainer1.Panel2.Controls.Add(this.lblCapacity);
            this.splitContainer1.Panel2.Controls.Add(this.lblLeagueName);
            this.splitContainer1.Panel2.Controls.Add(this.txtSponsor);
            this.splitContainer1.Panel2.Controls.Add(this.txtLeagueName);
            this.splitContainer1.Size = new System.Drawing.Size(743, 395);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 27;
            // 
            // dgvLeagues
            // 
            this.dgvLeagues.AllowUserToAddRows = false;
            this.dgvLeagues.AllowUserToDeleteRows = false;
            this.dgvLeagues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeagues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeagues.Location = new System.Drawing.Point(10, 50);
            this.dgvLeagues.Name = "dgvLeagues";
            this.dgvLeagues.ReadOnly = true;
            this.dgvLeagues.RowHeadersVisible = false;
            this.dgvLeagues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeagues.Size = new System.Drawing.Size(320, 335);
            this.dgvLeagues.TabIndex = 2;
            this.dgvLeagues.SelectionChanged += new System.EventHandler(this.dgvLeagues_SelectionChanged);
            // 
            // lblCurrentLeagues
            // 
            this.lblCurrentLeagues.AutoSize = true;
            this.lblCurrentLeagues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLeagues.Location = new System.Drawing.Point(101, 23);
            this.lblCurrentLeagues.Name = "lblCurrentLeagues";
            this.lblCurrentLeagues.Size = new System.Drawing.Size(150, 24);
            this.lblCurrentLeagues.TabIndex = 1;
            this.lblCurrentLeagues.Text = "Current Leagues";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(136, 88);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(100, 20);
            this.nudCapacity.TabIndex = 32;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.pnlEdit);
            this.pnlAdmin.Controls.Add(this.pnlStandard);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 188);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(399, 207);
            this.pnlAdmin.TabIndex = 31;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.cmdCancel);
            this.pnlEdit.Controls.Add(this.cmdConfirm);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(399, 207);
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
            this.pnlStandard.Size = new System.Drawing.Size(399, 207);
            this.pnlStandard.TabIndex = 23;
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
            // lblSponsor
            // 
            this.lblSponsor.AutoSize = true;
            this.lblSponsor.Location = new System.Drawing.Point(55, 116);
            this.lblSponsor.Name = "lblSponsor";
            this.lblSponsor.Size = new System.Drawing.Size(46, 13);
            this.lblSponsor.TabIndex = 30;
            this.lblSponsor.Text = "Sponsor";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(55, 90);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(48, 13);
            this.lblCapacity.TabIndex = 29;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblLeagueName
            // 
            this.lblLeagueName.AutoSize = true;
            this.lblLeagueName.Location = new System.Drawing.Point(55, 64);
            this.lblLeagueName.Name = "lblLeagueName";
            this.lblLeagueName.Size = new System.Drawing.Size(74, 13);
            this.lblLeagueName.TabIndex = 26;
            this.lblLeagueName.Text = "League Name";
            // 
            // txtSponsor
            // 
            this.txtSponsor.Location = new System.Drawing.Point(136, 113);
            this.txtSponsor.Name = "txtSponsor";
            this.txtSponsor.ReadOnly = true;
            this.txtSponsor.Size = new System.Drawing.Size(100, 20);
            this.txtSponsor.TabIndex = 20;
            // 
            // txtLeagueName
            // 
            this.txtLeagueName.Location = new System.Drawing.Point(136, 61);
            this.txtLeagueName.Name = "txtLeagueName";
            this.txtLeagueName.ReadOnly = true;
            this.txtLeagueName.Size = new System.Drawing.Size(100, 20);
            this.txtLeagueName.TabIndex = 18;
            // 
            // LeagueDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "LeagueDetailsView";
            this.Size = new System.Drawing.Size(743, 395);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlStandard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvLeagues;
        private System.Windows.Forms.Label lblCurrentLeagues;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdConfirm;
        private System.Windows.Forms.Panel pnlStandard;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label lblSponsor;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblLeagueName;
        private System.Windows.Forms.TextBox txtSponsor;
        private System.Windows.Forms.TextBox txtLeagueName;
        private System.Windows.Forms.NumericUpDown nudCapacity;
    }
}
