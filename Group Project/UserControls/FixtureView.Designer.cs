namespace Group_Project.UserControls
{
    partial class FixtureView
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
            this.lblFixtures = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.spnlFixtures = new System.Windows.Forms.SplitContainer();
            this.dgvFixtures = new System.Windows.Forms.DataGridView();
            this.spnlHeader = new System.Windows.Forms.SplitContainer();
            this.spnlEdit = new System.Windows.Forms.SplitContainer();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAddResult = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAwayTeam = new System.Windows.Forms.TextBox();
            this.txtHomeTeam = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAwayTime = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.nudAwayGoals = new System.Windows.Forms.NumericUpDown();
            this.nudHomeGoals = new System.Windows.Forms.NumericUpDown();
            this.lblAwayGoals = new System.Windows.Forms.Label();
            this.lblHomeGoals = new System.Windows.Forms.Label();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlEditMode = new System.Windows.Forms.Panel();
            this.pnlEditing = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnlFixtures)).BeginInit();
            this.spnlFixtures.Panel1.SuspendLayout();
            this.spnlFixtures.Panel2.SuspendLayout();
            this.spnlFixtures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixtures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnlHeader)).BeginInit();
            this.spnlHeader.Panel1.SuspendLayout();
            this.spnlHeader.Panel2.SuspendLayout();
            this.spnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnlEdit)).BeginInit();
            this.spnlEdit.Panel1.SuspendLayout();
            this.spnlEdit.Panel2.SuspendLayout();
            this.spnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeGoals)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.pnlEditMode.SuspendLayout();
            this.pnlEditing.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFixtures
            // 
            this.lblFixtures.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFixtures.AutoSize = true;
            this.lblFixtures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFixtures.Location = new System.Drawing.Point(286, 0);
            this.lblFixtures.Name = "lblFixtures";
            this.lblFixtures.Size = new System.Drawing.Size(70, 21);
            this.lblFixtures.TabIndex = 0;
            this.lblFixtures.Text = "Fixtures";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(20, 20);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(345, 327);
            this.dgvResults.TabIndex = 2;
            this.dgvResults.SelectionChanged += new System.EventHandler(this.dgvResults_SelectionChanged);
            // 
            // lblResults
            // 
            this.lblResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResults.Location = new System.Drawing.Point(297, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(64, 21);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results";
            // 
            // spnlFixtures
            // 
            this.spnlFixtures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spnlFixtures.Location = new System.Drawing.Point(0, 27);
            this.spnlFixtures.Name = "spnlFixtures";
            // 
            // spnlFixtures.Panel1
            // 
            this.spnlFixtures.Panel1.Controls.Add(this.dgvFixtures);
            this.spnlFixtures.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // spnlFixtures.Panel2
            // 
            this.spnlFixtures.Panel2.Controls.Add(this.dgvResults);
            this.spnlFixtures.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.spnlFixtures.Size = new System.Drawing.Size(778, 367);
            this.spnlFixtures.SplitterDistance = 389;
            this.spnlFixtures.TabIndex = 2;
            // 
            // dgvFixtures
            // 
            this.dgvFixtures.AllowUserToAddRows = false;
            this.dgvFixtures.AllowUserToDeleteRows = false;
            this.dgvFixtures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFixtures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFixtures.Location = new System.Drawing.Point(20, 20);
            this.dgvFixtures.Name = "dgvFixtures";
            this.dgvFixtures.ReadOnly = true;
            this.dgvFixtures.RowHeadersVisible = false;
            this.dgvFixtures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFixtures.Size = new System.Drawing.Size(349, 327);
            this.dgvFixtures.TabIndex = 3;
            this.dgvFixtures.SelectionChanged += new System.EventHandler(this.dgvFixtures_SelectionChanged);
            // 
            // spnlHeader
            // 
            this.spnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.spnlHeader.Location = new System.Drawing.Point(0, 0);
            this.spnlHeader.Name = "spnlHeader";
            // 
            // spnlHeader.Panel1
            // 
            this.spnlHeader.Panel1.Controls.Add(this.lblFixtures);
            // 
            // spnlHeader.Panel2
            // 
            this.spnlHeader.Panel2.Controls.Add(this.lblResults);
            this.spnlHeader.Size = new System.Drawing.Size(778, 27);
            this.spnlHeader.SplitterDistance = 389;
            this.spnlHeader.TabIndex = 2;
            // 
            // spnlEdit
            // 
            this.spnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spnlEdit.Location = new System.Drawing.Point(0, 0);
            this.spnlEdit.Name = "spnlEdit";
            // 
            // spnlEdit.Panel1
            // 
            this.spnlEdit.Panel1.Controls.Add(this.cmdAdd);
            this.spnlEdit.Panel1.Controls.Add(this.cmdDelete);
            this.spnlEdit.Panel1.Controls.Add(this.cmdEdit);
            // 
            // spnlEdit.Panel2
            // 
            this.spnlEdit.Panel2.Controls.Add(this.cmdAddResult);
            this.spnlEdit.Size = new System.Drawing.Size(778, 78);
            this.spnlEdit.SplitterDistance = 389;
            this.spnlEdit.TabIndex = 3;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(23, 15);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(108, 57);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Add Fixture";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(259, 15);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(108, 57);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Delete Fixture";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(141, 15);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(108, 57);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Edit Fixture";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAddResult
            // 
            this.cmdAddResult.Location = new System.Drawing.Point(124, 15);
            this.cmdAddResult.Name = "cmdAddResult";
            this.cmdAddResult.Size = new System.Drawing.Size(108, 57);
            this.cmdAddResult.TabIndex = 3;
            this.cmdAddResult.Text = "Add Result";
            this.cmdAddResult.UseVisualStyleBackColor = true;
            this.cmdAddResult.Click += new System.EventHandler(this.cmdAddResult_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm tt";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(301, 29);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(79, 20);
            this.dtpTime.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(218, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(79, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // txtAwayTeam
            // 
            this.txtAwayTeam.Location = new System.Drawing.Point(133, 29);
            this.txtAwayTeam.Name = "txtAwayTeam";
            this.txtAwayTeam.ReadOnly = true;
            this.txtAwayTeam.Size = new System.Drawing.Size(79, 20);
            this.txtAwayTeam.TabIndex = 8;
            // 
            // txtHomeTeam
            // 
            this.txtHomeTeam.Location = new System.Drawing.Point(34, 29);
            this.txtHomeTeam.Name = "txtHomeTeam";
            this.txtHomeTeam.ReadOnly = true;
            this.txtHomeTeam.Size = new System.Drawing.Size(79, 20);
            this.txtHomeTeam.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(337, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(238, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblAwayTime
            // 
            this.lblAwayTime.AutoSize = true;
            this.lblAwayTime.Location = new System.Drawing.Point(142, 13);
            this.lblAwayTime.Name = "lblAwayTime";
            this.lblAwayTime.Size = new System.Drawing.Size(63, 13);
            this.lblAwayTime.TabIndex = 4;
            this.lblAwayTime.Text = "Away Team";
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(43, 13);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(65, 13);
            this.lblHomeTeam.TabIndex = 3;
            this.lblHomeTeam.Text = "Home Team";
            // 
            // nudAwayGoals
            // 
            this.nudAwayGoals.Location = new System.Drawing.Point(634, 29);
            this.nudAwayGoals.Name = "nudAwayGoals";
            this.nudAwayGoals.Size = new System.Drawing.Size(62, 20);
            this.nudAwayGoals.TabIndex = 16;
            // 
            // nudHomeGoals
            // 
            this.nudHomeGoals.Location = new System.Drawing.Point(470, 29);
            this.nudHomeGoals.Name = "nudHomeGoals";
            this.nudHomeGoals.Size = new System.Drawing.Size(62, 20);
            this.nudHomeGoals.TabIndex = 15;
            // 
            // lblAwayGoals
            // 
            this.lblAwayGoals.AutoSize = true;
            this.lblAwayGoals.Location = new System.Drawing.Point(631, 13);
            this.lblAwayGoals.Name = "lblAwayGoals";
            this.lblAwayGoals.Size = new System.Drawing.Size(63, 13);
            this.lblAwayGoals.TabIndex = 14;
            this.lblAwayGoals.Text = "Away Goals";
            // 
            // lblHomeGoals
            // 
            this.lblHomeGoals.AutoSize = true;
            this.lblHomeGoals.Location = new System.Drawing.Point(467, 13);
            this.lblHomeGoals.Name = "lblHomeGoals";
            this.lblHomeGoals.Size = new System.Drawing.Size(65, 13);
            this.lblHomeGoals.TabIndex = 10;
            this.lblHomeGoals.Text = "Home Goals";
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.dtpTime);
            this.pnlAdmin.Controls.Add(this.nudAwayGoals);
            this.pnlAdmin.Controls.Add(this.dtpDate);
            this.pnlAdmin.Controls.Add(this.pnlEditMode);
            this.pnlAdmin.Controls.Add(this.txtAwayTeam);
            this.pnlAdmin.Controls.Add(this.nudHomeGoals);
            this.pnlAdmin.Controls.Add(this.txtHomeTeam);
            this.pnlAdmin.Controls.Add(this.lblHomeGoals);
            this.pnlAdmin.Controls.Add(this.lblTime);
            this.pnlAdmin.Controls.Add(this.lblDate);
            this.pnlAdmin.Controls.Add(this.lblAwayGoals);
            this.pnlAdmin.Controls.Add(this.lblAwayTime);
            this.pnlAdmin.Controls.Add(this.lblHomeTeam);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 259);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(778, 135);
            this.pnlAdmin.TabIndex = 4;
            // 
            // pnlEditMode
            // 
            this.pnlEditMode.Controls.Add(this.pnlEditing);
            this.pnlEditMode.Controls.Add(this.spnlEdit);
            this.pnlEditMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditMode.Location = new System.Drawing.Point(0, 57);
            this.pnlEditMode.Name = "pnlEditMode";
            this.pnlEditMode.Size = new System.Drawing.Size(778, 78);
            this.pnlEditMode.TabIndex = 4;
            // 
            // pnlEditing
            // 
            this.pnlEditing.Controls.Add(this.cmdCancel);
            this.pnlEditing.Controls.Add(this.cmdAccept);
            this.pnlEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditing.Location = new System.Drawing.Point(0, 0);
            this.pnlEditing.Name = "pnlEditing";
            this.pnlEditing.Size = new System.Drawing.Size(778, 78);
            this.pnlEditing.TabIndex = 5;
            this.pnlEditing.Visible = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(459, 11);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(108, 57);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAccept
            // 
            this.cmdAccept.Location = new System.Drawing.Point(211, 11);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(108, 57);
            this.cmdAccept.TabIndex = 1;
            this.cmdAccept.Text = "Accept";
            this.cmdAccept.UseVisualStyleBackColor = true;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // FixtureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.spnlFixtures);
            this.Controls.Add(this.spnlHeader);
            this.Name = "FixtureView";
            this.Size = new System.Drawing.Size(778, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.spnlFixtures.Panel1.ResumeLayout(false);
            this.spnlFixtures.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnlFixtures)).EndInit();
            this.spnlFixtures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixtures)).EndInit();
            this.spnlHeader.Panel1.ResumeLayout(false);
            this.spnlHeader.Panel1.PerformLayout();
            this.spnlHeader.Panel2.ResumeLayout(false);
            this.spnlHeader.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnlHeader)).EndInit();
            this.spnlHeader.ResumeLayout(false);
            this.spnlEdit.Panel1.ResumeLayout(false);
            this.spnlEdit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnlEdit)).EndInit();
            this.spnlEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeGoals)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlEditMode.ResumeLayout(false);
            this.pnlEditing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFixtures;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.SplitContainer spnlFixtures;
        private System.Windows.Forms.SplitContainer spnlHeader;
        private System.Windows.Forms.DataGridView dgvFixtures;
        private System.Windows.Forms.SplitContainer spnlEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAddResult;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAwayTime;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAwayTeam;
        private System.Windows.Forms.TextBox txtHomeTeam;
        private System.Windows.Forms.Label lblAwayGoals;
        private System.Windows.Forms.Label lblHomeGoals;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.NumericUpDown nudAwayGoals;
        private System.Windows.Forms.NumericUpDown nudHomeGoals;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlEditMode;
        private System.Windows.Forms.Panel pnlEditing;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
    }
}
