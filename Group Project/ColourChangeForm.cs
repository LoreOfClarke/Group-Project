using System;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class frmColourChange : Form
    {
        public frmColourChange()
        {
            InitializeComponent();
        }


        public event EventHandler ColourChangeEvent;

        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.ColourChangeEvent != null)
                this.ColourChangeEvent(this, e);
        }

        private void cmdStandard_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourSetting = 0;
            UpdateParent(sender, e);
            colourChange();
        }

        private void cmdHighContrast_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourSetting = 1;
            UpdateParent(sender, e);
            colourChange();
        }

        private void colourChange()
        {
            ColourChange.ColourForm(this);
            ColourChange.ColourButton(cmdStandard);
            ColourChange.ColourButton(cmdHighContrast);
            ColourChange.ColourButton(cmdRed);
        }

        private void cmdRed_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourSetting = 2;
            UpdateParent(sender, e);
            colourChange();
        }

        private void frmColourChange_Load(object sender, EventArgs e)
        {
            colourChange();
        }
    }
}
