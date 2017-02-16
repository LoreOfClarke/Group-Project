namespace Group_Project.UserControls
{
    partial class LeagueTeamAssignmentView
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
            this.pnlAssingnment = new System.Windows.Forms.Panel();
            this.chkAssigned = new System.Windows.Forms.CheckBox();
            this.cmdAssign = new System.Windows.Forms.Button();
            this.spnlPanels = new System.Windows.Forms.SplitContainer();
            this.dgvLeagues = new System.Windows.Forms.DataGridView();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.pnlAssingnment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnlPanels)).BeginInit();
            this.spnlPanels.Panel1.SuspendLayout();
            this.spnlPanels.Panel2.SuspendLayout();
            this.spnlPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAssingnment
            // 
            this.pnlAssingnment.Controls.Add(this.chkAssigned);
            this.pnlAssingnment.Controls.Add(this.cmdAssign);
            this.pnlAssingnment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssingnment.Location = new System.Drawing.Point(0, 421);
            this.pnlAssingnment.Name = "pnlAssingnment";
            this.pnlAssingnment.Size = new System.Drawing.Size(662, 70);
            this.pnlAssingnment.TabIndex = 0;
            // 
            // chkAssigned
            // 
            this.chkAssigned.AutoSize = true;
            this.chkAssigned.Location = new System.Drawing.Point(294, 15);
            this.chkAssigned.Name = "chkAssigned";
            this.chkAssigned.Size = new System.Drawing.Size(69, 17);
            this.chkAssigned.TabIndex = 2;
            this.chkAssigned.Text = "Assigned";
            this.chkAssigned.UseVisualStyleBackColor = true;
            this.chkAssigned.Click += new System.EventHandler(this.chkAssigned_Click);
            // 
            // cmdAssign
            // 
            this.cmdAssign.Location = new System.Drawing.Point(294, 38);
            this.cmdAssign.Name = "cmdAssign";
            this.cmdAssign.Size = new System.Drawing.Size(75, 23);
            this.cmdAssign.TabIndex = 0;
            this.cmdAssign.Text = "Un/Assign";
            this.cmdAssign.UseVisualStyleBackColor = true;
            this.cmdAssign.Click += new System.EventHandler(this.cmdAssign_Click);
            // 
            // spnlPanels
            // 
            this.spnlPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spnlPanels.Location = new System.Drawing.Point(0, 0);
            this.spnlPanels.Name = "spnlPanels";
            // 
            // spnlPanels.Panel1
            // 
            this.spnlPanels.Panel1.Controls.Add(this.dgvLeagues);
            this.spnlPanels.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // spnlPanels.Panel2
            // 
            this.spnlPanels.Panel2.Controls.Add(this.dgvTeams);
            this.spnlPanels.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.spnlPanels.Size = new System.Drawing.Size(662, 421);
            this.spnlPanels.SplitterDistance = 325;
            this.spnlPanels.TabIndex = 1;
            // 
            // dgvLeagues
            // 
            this.dgvLeagues.AllowUserToAddRows = false;
            this.dgvLeagues.AllowUserToDeleteRows = false;
            this.dgvLeagues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeagues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeagues.Location = new System.Drawing.Point(10, 10);
            this.dgvLeagues.Name = "dgvLeagues";
            this.dgvLeagues.ReadOnly = true;
            this.dgvLeagues.RowHeadersVisible = false;
            this.dgvLeagues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeagues.Size = new System.Drawing.Size(305, 401);
            this.dgvLeagues.TabIndex = 3;
            this.dgvLeagues.SelectionChanged += new System.EventHandler(this.dgvLeagues_SelectionChanged);
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeams.Location = new System.Drawing.Point(10, 10);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(313, 401);
            this.dgvTeams.TabIndex = 3;
            this.dgvTeams.SelectionChanged += new System.EventHandler(this.dgvTeams_SelectionChanged);
            // 
            // LeagueTeamAssignmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spnlPanels);
            this.Controls.Add(this.pnlAssingnment);
            this.Name = "LeagueTeamAssignmentView";
            this.Size = new System.Drawing.Size(662, 491);
            this.pnlAssingnment.ResumeLayout(false);
            this.pnlAssingnment.PerformLayout();
            this.spnlPanels.Panel1.ResumeLayout(false);
            this.spnlPanels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnlPanels)).EndInit();
            this.spnlPanels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAssingnment;
        private System.Windows.Forms.SplitContainer spnlPanels;
        private System.Windows.Forms.CheckBox chkAssigned;
        private System.Windows.Forms.Button cmdAssign;
        private System.Windows.Forms.DataGridView dgvLeagues;
        private System.Windows.Forms.DataGridView dgvTeams;
    }
}
