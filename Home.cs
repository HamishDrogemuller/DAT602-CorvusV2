using System.Data;
using MySql.Data.MySqlClient;

namespace CorvusV2
{
    public partial class CorvusHome : Form
    {
        private Login _login;
        private PlayerInDB _playerInDB;
        private Gameboard _gameboard;
        private Admin _admin;
        private static String connectionString = "Server=localhost;Port=3306;Database=Corvus;Uid=Strix;password=Corvere300;";
        private MySqlConnection mySqlConnection = new MySqlConnection(connectionString);


        public CorvusHome()
        {
            InitializeComponent();
        }

        public bool ShowDialog(Login login, PlayerInDB playerInDB)
        {
            _login = login;
            _playerInDB = playerInDB;
            return ShowDialog() == DialogResult.OK;
        }


        private void CorvusHome_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _login.Show();
            DialogResult = DialogResult.Cancel;

        }

        private void JoinGameButton_Click(object sender, EventArgs e)
        {
            _gameboard = new Gameboard();
            _playerInDB = new PlayerInDB();
            this.Hide();
            if (_gameboard.ShowDialog(this, _playerInDB))
            {
                this.Show();
            }
        }

        private void AdministrationButton_Click(object sender, EventArgs e)
        {
            _admin = new Admin();
            _playerInDB = new PlayerInDB();

            this.Hide();
            if (_admin.ShowDialog(this, _playerInDB))
            {
                this.Show();
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getActiveBtn_Click(object sender, EventArgs e)
        {

            DataAccess aDB = new DataAccess();
            string aMessage = aDB.getActivePlayers();
            // MessageBox.Show(aMessage);

            var table = aDB.getActivePlayers();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}