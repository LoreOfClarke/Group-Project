namespace Group_Project
{
    partial class frmColourChange
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
            this.cmdStandard = new System.Windows.Forms.Button();
            this.cmdHighContrast = new System.Windows.Forms.Button();
            this.cmdRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStandard
            // 
            this.cmdStandard.Location = new System.Drawing.Point(31, 25);
            this.cmdStandard.Name = "cmdStandard";
            this.cmdStandard.Size = new System.Drawing.Size(103, 23);
            this.cmdStandard.TabIndex = 0;
            this.cmdStandard.Text = "Standard";
            this.cmdStandard.UseVisualStyleBackColor = true;
            this.cmdStandard.Click += new System.EventHandler(this.cmdStandard_Click);
            // 
            // cmdHighContrast
            // 
            this.cmdHighContrast.Location = new System.Drawing.Point(31, 54);
            this.cmdHighContrast.Name = "cmdHighContrast";
            this.cmdHighContrast.Size = new System.Drawing.Size(103, 23);
            this.cmdHighContrast.TabIndex = 1;
            this.cmdHighContrast.Text = "High Contrast";
            this.cmdHighContrast.UseVisualStyleBackColor = true;
            this.cmdHighContrast.Click += new System.EventHandler(this.cmdHighContrast_Click);
            // 
            // cmdRed
            // 
            this.cmdRed.Location = new System.Drawing.Point(31, 83);
            this.cmdRed.Name = "cmdRed";
            this.cmdRed.Size = new System.Drawing.Size(103, 23);
            this.cmdRed.TabIndex = 2;
            this.cmdRed.Text = "Red";
            this.cmdRed.UseVisualStyleBackColor = true;
            this.cmdRed.Click += new System.EventHandler(this.cmdRed_Click);
            // 
            // frmColourChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 289);
            this.Controls.Add(this.cmdRed);
            this.Controls.Add(this.cmdHighContrast);
            this.Controls.Add(this.cmdStandard);
            this.Name = "frmColourChange";
            this.Text = "ColourChangeForm";
            this.Load += new System.EventHandler(this.frmColourChange_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStandard;
        private System.Windows.Forms.Button cmdHighContrast;
        private System.Windows.Forms.Button cmdRed;
    }
}