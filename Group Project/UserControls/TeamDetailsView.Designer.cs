namespace Group_Project.UserControls
{
    partial class TeamDetailsView
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
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.lblCurrentTeams = new System.Windows.Forms.Label();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.pnlStandard = new System.Windows.Forms.Panel();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtStadium = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvTeams);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentTeams);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlAdmin);
            this.splitContainer1.Panel2.Controls.Add(this.lblStadium);
            this.splitContainer1.Panel2.Controls.Add(this.lblTeamName);
            this.splitContainer1.Panel2.Controls.Add(this.txtStadium);
            this.splitContainer1.Panel2.Controls.Add(this.txtTeamName);
            this.splitContainer1.Size = new System.Drawing.Size(653, 358);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 28;
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeams.Location = new System.Drawing.Point(10, 50);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(278, 298);
            this.dgvTeams.TabIndex = 2;
            this.dgvTeams.SelectionChanged += new System.EventHandler(this.dgvTeams_SelectionChanged);
            // 
            // lblCurrentTeams
            // 
            this.lblCurrentTeams.AutoSize = true;
            this.lblCurrentTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTeams.Location = new System.Drawing.Point(101, 23);
            this.lblCurrentTeams.Name = "lblCurrentTeams";
            this.lblCurrentTeams.Size = new System.Drawing.Size(135, 24);
            this.lblCurrentTeams.TabIndex = 1;
            this.lblCurrentTeams.Text = "Current Teams";
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.pnlEdit);
            this.pnlAdmin.Controls.Add(this.pnlStandard);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 151);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(351, 207);
            this.pnlAdmin.TabIndex = 31;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.cmdCancel);
            this.pnlEdit.Controls.Add(this.cmdConfirm);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(351, 207);
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
            this.pnlStandard.Size = new System.Drawing.Size(351, 207);
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
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(55, 90);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(45, 13);
            this.lblStadium.TabIndex = 30;
            this.lblStadium.Text = "Stadium";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(55, 64);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(65, 13);
            this.lblTeamName.TabIndex = 26;
            this.lblTeamName.Text = "Team Name";
            // 
            // txtStadium
            // 
            this.txtStadium.Location = new System.Drawing.Point(136, 87);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.ReadOnly = true;
            this.txtStadium.Size = new System.Drawing.Size(100, 20);
            this.txtStadium.TabIndex = 20;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(136, 61);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.ReadOnly = true;
            this.txtTeamName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamName.TabIndex = 18;
            // 
            // TeamDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TeamDetailsView";
            this.Size = new System.Drawing.Size(653, 358);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlStandard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Label lblCurrentTeams;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdConfirm;
        private System.Windows.Forms.Panel pnlStandard;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtStadium;
        private System.Windows.Forms.TextBox txtTeamName;
    }
}
