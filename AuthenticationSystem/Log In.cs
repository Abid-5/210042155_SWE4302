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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createAccLabel_Click(object sender, EventArgs e)
        {
            Sign_Up s1=new Sign_Up();
            s1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string filePath = @"C:\Users\abids\Desktop\OOC Lab\AuthenticationSystem\User.txt";
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (CheckCredentials(usernameTextBox.Text, passwordTextBox.Text))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data[0] == usernameTextBox.Text)
                    {
                        Dashboard dashboardForm = new Dashboard(data[2]);
                        dashboardForm.Show();
                        this.Hide();
                    }
                }

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data[0] == username && data[1] == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
