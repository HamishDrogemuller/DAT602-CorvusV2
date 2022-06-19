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
    public partial class Admin : Form
    {
        private Admin _admin;
        private PlayerInDB _playerInDB;
        private CorvusHome _home;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        public bool ShowDialog(CorvusHome home, PlayerInDB playerInDB)
        {
            _home = home;
            _playerInDB = playerInDB;
            return ShowDialog() == DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess aDB = new DataAccess();
            string aMessage = aDB.updatePlayer(this.usernameText.Text, this.passwordText.Text, this.EmailText.Text);
            MessageBox.Show(aMessage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess aDB = new DataAccess();
            string aMessage = aDB.deleteAccount(this.usernameText.Text);
            MessageBox.Show(aMessage);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _home.Show();
            DialogResult = DialogResult.Cancel;
        }
    }
}
