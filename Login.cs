using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorvusV2
{
    public partial class Login : Form
    {
        private Login _login;
        private Register _register;
        private PlayerInDB _playerindb;
        private CorvusHome _home;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DataAccess aDB = new DataAccess();
            string aMessage = aDB.Login(this.userNameText.Text, this.passwordText.Text);
            // MessageBox.Show(aMessage);

            _home = new CorvusHome();
            this.Hide();
            if (_home.ShowDialog(this, _playerindb))
            {
                this.Show();
            }
        }


        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            _register = new Register();
            _playerindb = new PlayerInDB();
            this.Hide();
            if (_register.ShowDialog(this, _playerindb))
            {
                this.Show();
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (passwordText.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LoginButton.Focus();
                    LoginButton.PerformClick();
                }
            }
        }
    }
}
