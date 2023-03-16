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
    public partial class Dashboard : Form
    {
        public Dashboard(string text)
        {
            InitializeComponent();
            welcome.Text = $"Welcome {text}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 l1 = new Form1();
            l1.Show();
            this.Hide();
        }
    }
}
