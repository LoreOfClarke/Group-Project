using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdManagerLogin_Click(object sender, EventArgs e)
        {
            ManagerView MView = new ManagerView();
            MView.TeamID = int.Parse(numericUpDown1.Value.ToString());
            MView.Owner = this.Owner;
            MView.Show();
            this.Owner.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminView AView = new AdminView();
            AView.Owner = this.Owner;
            AView.Show();
            this.Owner.Hide();
            this.Close();
        }
    }
}
