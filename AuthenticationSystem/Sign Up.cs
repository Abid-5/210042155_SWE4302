using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthenticationSystem
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            Form1 l1 = new Form1();
            l1.Show();
            this.Hide();
        }
    }
}
