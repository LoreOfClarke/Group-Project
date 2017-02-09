using System;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        public event EventHandler ColourChangeEvent;

        protected void UpdateParent(object sender, EventArgs e)
        {
            if (this.ColourChangeEvent != null)
                this.ColourChangeEvent(this, e);
        }

        private void cmdManagerLogin_Click(object sender, EventArgs e)
        {
            ManagerView MView = new ManagerView();
            MView.TeamID = int.Parse(numericUpDown1.Value.ToString());
            MView.Owner = this.Owner;
            MView.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
            MView.Show();
            this.Owner.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminView AView = new AdminView();
            AView.Owner = this.Owner;
            AView.Show();
            AView.ColourChangeEvent += ColourChangeForm_ColourChangeEvent;
            this.Owner.Hide();
            this.Close();
        }

        private void ColourChangeForm_ColourChangeEvent(object sender, EventArgs e)
        {
            colourchange();
        }

        private void colourchange()
        {
            ColourChange.ColourForm(this);
            ColourChange.ColourButton(cmdManagerLogin);
            ColourChange.ColourButton(button1);
            ColourChange.ColourNumericUD(numericUpDown1);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            colourchange();
        }
    }
}
