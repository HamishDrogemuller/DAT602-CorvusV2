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
    public partial class Gameboard : Form
    {
        private Login _login;
        private PlayerInDB _playerInDB;
        private CorvusHome _home;
        public Gameboard()
        {
            InitializeComponent();
        }

        public bool ShowDialog(CorvusHome home, PlayerInDB playerInDB)
        {
            _home = home;
            _playerInDB = playerInDB;
            return ShowDialog()== DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PictureBox pictureBox1 = new (PictureBox)sender;

            //int row = (pictureBox1.Top / 11);
            //int col = (pictureBox1.Left / 21);
            //MessageBox.Show("The (row,col) is (" + row.ToString() + "," + col.ToString(), ")");
        }

        private void Gameboard_Load(object sender, EventArgs e)
        {
            PictureBox[,] Tiles = new PictureBox[20, 20];

            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 20; col++)
                {
                    Tiles[row, col] = new PictureBox();
                    Tiles[row, col].Width = 50;
                    Tiles[row, col].Height = 50;
                    Tiles[row, col].BackColor = Color.Black;
                    Tiles[row, col].Left = col * 51;
                    Tiles[row, col].Top = col * 51;
                    Tiles[row, col].Click += pictureBox1_Click;
                    this.Controls.Add(Tiles[row, col]);
                    this.Invalidate();
                }
            }

            //this.Gamespace.BringToFront();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //int numOfCells = 200;
            //int cellSize = 20;
            //Pen p = new Pen(Color.Black);

            //for (int y = 0; y < numOfCells; ++y)
            //{
            //    g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            //}

            //for (int x = 0; x < numOfCells; ++x)
            //{
            //    g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            //}


        }
    }
}
