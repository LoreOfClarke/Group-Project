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
            this.spnlHeader = new System.Windows.Forms.SplitContainer();
            this.dgvFixtures = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnlFixtures)).BeginInit();
            this.spnlFixtures.Panel1.SuspendLayout();
            this.spnlFixtures.Panel2.SuspendLayout();
            this.spnlFixtures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnlHeader)).BeginInit();
            this.spnlHeader.Panel1.SuspendLayout();
            this.spnlHeader.Panel2.SuspendLayout();
            this.spnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixtures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFixtures
            // 
            this.lblFixtures.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFixtures.AutoSize = true;
            this.lblFixtures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFixtures.Location = new System.Drawing.Point(153, 0);
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
            this.dgvResults.Size = new System.Drawing.Size(342, 312);
            this.dgvResults.TabIndex = 2;
            // 
            // lblResults
            // 
            this.lblResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResults.Location = new System.Drawing.Point(166, 0);
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
            this.spnlFixtures.Size = new System.Drawing.Size(772, 352);
            this.spnlFixtures.SplitterDistance = 386;
            this.spnlFixtures.TabIndex = 2;
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
            this.spnlHeader.Size = new System.Drawing.Size(772, 27);
            this.spnlHeader.SplitterDistance = 386;
            this.spnlHeader.TabIndex = 2;
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
            this.dgvFixtures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFixtures.Size = new System.Drawing.Size(346, 312);
            this.dgvFixtures.TabIndex = 3;
            // 
            // FixtureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spnlFixtures);
            this.Controls.Add(this.spnlHeader);
            this.Name = "FixtureView";
            this.Size = new System.Drawing.Size(772, 379);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.spnlFixtures.Panel1.ResumeLayout(false);
            this.spnlFixtures.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnlFixtures)).EndInit();
            this.spnlFixtures.ResumeLayout(false);
            this.spnlHeader.Panel1.ResumeLayout(false);
            this.spnlHeader.Panel1.PerformLayout();
            this.spnlHeader.Panel2.ResumeLayout(false);
            this.spnlHeader.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnlHeader)).EndInit();
            this.spnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixtures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFixtures;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.SplitContainer spnlFixtures;
        private System.Windows.Forms.SplitContainer spnlHeader;
        private System.Windows.Forms.DataGridView dgvFixtures;
    }
}
