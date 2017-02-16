﻿using System;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class frmColourChange : Form
    {

        /// <summary>
        /// Autogenerated code
        /// </summary>
        public frmColourChange()
        {
            InitializeComponent();
        }
        #region Setup
        /// <summary>
        /// Code run on form load, currently just runs the colour change method
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void frmColourChange_Load(object sender, EventArgs e)
        {
            colourChange();
        }
        #endregion
        #region Object Code
        /// <summary>
        /// The standard colour button. This sets the colour property to standard, and passes the change up.
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void cmdStandard_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourSetting = 0;
            UpdateParent(sender, e);
            colourChange();
        }
        /// <summary>
        /// The High Contrast button. This sets the colour property to standard, and passes the change up.
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void cmdHighContrast_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourSetting = 1;
            UpdateParent(sender, e);
            colourChange();
        }
        /// <summary>
        /// The Red Colour button. This sets the colour property to standard, and passes the change up.
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event Argument</param>
        private void cmdRed_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourSetting = 2;
            UpdateParent(sender, e);
            colourChange();
        }
        #endregion
        #region Utility Functions
        /// <summary>
        /// Code that changes the colour of objects on the form
        /// </summary>
        private void colourChange()
        {
            ColourChange.ColourForm(this);
            ColourChange.ColourButton(cmdStandard);
            ColourChange.ColourButton(cmdHighContrast);
            ColourChange.ColourButton(cmdRed);
        }
        /// <summary>
        /// An event to handle passing colour changes up forms.
        /// </summary>
        public event EventHandler ColourChangeEvent;
        /// <summary>
        /// Code to allow the colour change to be passed on up forms.
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguement</param>
        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.ColourChangeEvent != null)
                this.ColourChangeEvent(this, e);
        }
        #endregion
    }
}
