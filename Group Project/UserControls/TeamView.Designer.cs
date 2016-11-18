namespace Group_Project.UserControls
{
    partial class TeamView
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTeamDetails = new System.Windows.Forms.Label();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.dgvTeamDetails = new System.Windows.Forms.DataGridView();
            this.pnlPlayerInformation = new System.Windows.Forms.Panel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForname = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForname = new System.Windows.Forms.TextBox();
            this.lblPlayerInformation = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamDetails)).BeginInit();
            this.pnlPlayerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTeamDetails);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(986, 96);
            this.pnlHeader.TabIndex = 24;
            // 
            // lblTeamDetails
            // 
            this.lblTeamDetails.AutoSize = true;
            this.lblTeamDetails.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTeamDetails.Location = new System.Drawing.Point(415, 38);
            this.lblTeamDetails.Name = "lblTeamDetails";
            this.lblTeamDetails.Size = new System.Drawing.Size(187, 29);
            this.lblTeamDetails.TabIndex = 0;
            this.lblTeamDetails.Text = "Team Details";
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.Controls.Add(this.dgvTeamDetails);
            this.pnlPlayers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlayers.Location = new System.Drawing.Point(0, 96);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPlayers.Size = new System.Drawing.Size(498, 426);
            this.pnlPlayers.TabIndex = 25;
            // 
            // dgvTeamDetails
            // 
            this.dgvTeamDetails.AllowUserToAddRows = false;
            this.dgvTeamDetails.AllowUserToDeleteRows = false;
            this.dgvTeamDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamDetails.Location = new System.Drawing.Point(20, 20);
            this.dgvTeamDetails.MultiSelect = false;
            this.dgvTeamDetails.Name = "dgvTeamDetails";
            this.dgvTeamDetails.ReadOnly = true;
            this.dgvTeamDetails.RowHeadersVisible = false;
            this.dgvTeamDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamDetails.Size = new System.Drawing.Size(458, 386);
            this.dgvTeamDetails.TabIndex = 0;
            this.dgvTeamDetails.SelectionChanged += new System.EventHandler(this.dgvTeamDetails_SelectionChanged);
            // 
            // pnlPlayerInformation
            // 
            this.pnlPlayerInformation.Controls.Add(this.dtpDateOfBirth);
            this.pnlPlayerInformation.Controls.Add(this.lblRole);
            this.pnlPlayerInformation.Controls.Add(this.lblDoB);
            this.pnlPlayerInformation.Controls.Add(this.lblSurname);
            this.pnlPlayerInformation.Controls.Add(this.lblForname);
            this.pnlPlayerInformation.Controls.Add(this.txtRole);
            this.pnlPlayerInformation.Controls.Add(this.txtSurname);
            this.pnlPlayerInformation.Controls.Add(this.txtForname);
            this.pnlPlayerInformation.Controls.Add(this.lblPlayerInformation);
            this.pnlPlayerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerInformation.Location = new System.Drawing.Point(498, 96);
            this.pnlPlayerInformation.Name = "pnlPlayerInformation";
            this.pnlPlayerInformation.Size = new System.Drawing.Size(488, 426);
            this.pnlPlayerInformation.TabIndex = 26;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(164, 193);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(125, 20);
            this.dtpDateOfBirth.TabIndex = 10;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(30, 249);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 16);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(30, 197);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(94, 16);
            this.lblDoB.TabIndex = 8;
            this.lblDoB.Text = "Date Of Birth";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(30, 145);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 16);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // lblForname
            // 
            this.lblForname.AutoSize = true;
            this.lblForname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForname.Location = new System.Drawing.Point(30, 93);
            this.lblForname.Name = "lblForname";
            this.lblForname.Size = new System.Drawing.Size(64, 16);
            this.lblForname.TabIndex = 6;
            this.lblForname.Text = "Forname";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(164, 245);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(125, 20);
            this.txtRole.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(164, 144);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(125, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // txtForname
            // 
            this.txtForname.Location = new System.Drawing.Point(164, 92);
            this.txtForname.Name = "txtForname";
            this.txtForname.ReadOnly = true;
            this.txtForname.Size = new System.Drawing.Size(125, 20);
            this.txtForname.TabIndex = 1;
            // 
            // lblPlayerInformation
            // 
            this.lblPlayerInformation.AutoSize = true;
            this.lblPlayerInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInformation.Location = new System.Drawing.Point(152, 44);
            this.lblPlayerInformation.Name = "lblPlayerInformation";
            this.lblPlayerInformation.Size = new System.Drawing.Size(160, 18);
            this.lblPlayerInformation.TabIndex = 0;
            this.lblPlayerInformation.Text = "Player Information";
            // 
            // TeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPlayerInformation);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.pnlHeader);
            this.Name = "TeamView";
            this.Size = new System.Drawing.Size(986, 522);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamDetails)).EndInit();
            this.pnlPlayerInformation.ResumeLayout(false);
            this.pnlPlayerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Panel pnlPlayerInformation;
        private System.Windows.Forms.Label lblTeamDetails;
        private System.Windows.Forms.DataGridView dgvTeamDetails;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForname;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForname;
        private System.Windows.Forms.Label lblPlayerInformation;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}
