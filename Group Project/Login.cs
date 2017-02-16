﻿using System;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// autogenerated code
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event to allow other forms to pass the colour change up the chain. This should never be used, but is here incase future developments change something.
        /// </summary>
        public event EventHandler ColourChangeEvent;
        /// <summary>
        /// code to run the colouchange event
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event argument</param>
        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.ColourChangeEvent != null)
                this.ColourChangeEvent(this, e);
        }
        /// <summary>
        /// code run when colourchange event is called
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">event argument</param>
        private void ColourChangeForm_ColourChangeEvent(object sender, EventArgs e)
        {
            colourchange();
        }
        /// <summary>
        /// code to change all of the colours on the form
        /// </summary>
        private void colourchange()
        {
            ColourChange.ColourForm(this);
            ColourChange.ColourButton(cmdLogin);
            ColourChange.ColourLabel(lblUsername);
            ColourChange.ColourLabel(lblPassword);
            ColourChange.ColourLabel(lblVerifyPassword);
            ColourChange.ColourTextbox(txtUsername);
            ColourChange.ColourTextbox(txtPassword);
            ColourChange.ColourTextbox(txtVerifyPassword);
        }
        /// <summary>
        /// code run on form load. Just runs the colour change method at this time
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event argument</param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            colourchange();
        }
        /// <summary>
        /// Code run on the button: Firstly the password fields are checked to ensure that they are the same, Then the database is checked for associated usernames, and the password value is taken from the database and checked against the password in the textboxes (it has been done this way to allow for upgrading to hashing the password). If the password is valid, the datbase is asked for the access level of the user, and the corect form for the user is opened.
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event argument</param>
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtVerifyPassword.Text)
            {
                MessageBox.Show("Passwords Do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Database.DatabaseConnection.dbConnect();
            this.Owner.Hide();
            if (txtPassword.Text == Database.PasswordList.GetPassword(txtUsername.Text))
            {
                switch(Database.PasswordList.GetAccessLevel(txtUsername.Text))
                {
                    case "ADMINISTRATOR"://The user is an administrator
                        AdminView AView = new AdminView();
                        AView.Owner = this.Owner;
                        AView.Show();
                        this.Close();
                        break;
                    default://the user is a manager (assuming sanitised database)
                        ManagerView MView = new ManagerView();
                        MView.Owner = this.Owner;
                        MView.TeamID = int.Parse(txtUsername.Text);
                        MView.Show();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            Database.DatabaseConnection.dbDisconnect();

        }
    }
}
