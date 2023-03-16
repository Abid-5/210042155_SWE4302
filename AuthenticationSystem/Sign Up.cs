using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        string filePath = @"C:\Users\abids\Desktop\OOC Lab\AuthenticationSystem\User.txt";

       
        private void signupButton_Click_1(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();


            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox1.Text) || string.IsNullOrWhiteSpace(reTypePassTextBox1.Text))
            {
                MessageBox.Show("Please enter all fields");
                return;
            }

            if (UserExists(usernameTextBox1.Text))
            {
                MessageBox.Show("A user with the same user name already exists");
                return;
            }

            if (passwordTextBox1.Text != reTypePassTextBox1.Text)
            {
                MessageBox.Show("passwords do not match");
                return;
            }

            if (passwordTextBox1.TextLength < 6 || reTypePassTextBox1.TextLength < 6)
            {
                MessageBox.Show("username and password must be at least six characters");
                return;
            }

            lines.Add($"{usernameTextBox1.Text},{passwordTextBox1.Text},{nameTextBox.Text}");
            File.WriteAllLines(filePath, lines);

            Dashboard d1 = new Dashboard(nameTextBox.Text);
            d1.Show();
            this.Hide();
        }

        private bool UserExists(string username)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data[0] == username)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
