using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace CorvusV2
{
    public partial class Register : Form
    {
        private Login _login;
        private PlayerInDB _playerindb;
        public Register()
        {
            InitializeComponent();
        }

        public bool ShowDialog(Login login, PlayerInDB playerInDB)
        {
            _login = login;
            _playerindb = playerInDB;
            return ShowDialog() == DialogResult.OK;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DataAccess aDB = new DataAccess();
            string aMessage = aDB.AddNewUser(this.usernameText.Text,this.PasswordText.Text,this.EmailText.Text);
            MessageBox.Show(aMessage);

            DialogResult = DialogResult.OK;
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*';
        }
    }
}
