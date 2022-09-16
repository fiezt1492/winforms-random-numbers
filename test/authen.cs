using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class authen : Form
    {
        public bool isLoggedIn = false;
        public authen()
        {
            InitializeComponent();
        }

        private void authen_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text == "admin")
            {
                isLoggedIn = true;
                this.Close();
            }
            else MessageBox.Show("Sai tai khoan.");
        }

        private void authen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) btnLogin.PerformClick(); 
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) btnLogin.PerformClick();
        }
    }
}
