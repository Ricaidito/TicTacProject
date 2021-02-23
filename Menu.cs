using System;
using System.Windows.Forms;

namespace TicTacProject
{
    public partial class MenuApp : Form
    {
        public MenuApp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Multiplayer
        {
            Multiplayer multiplayer = new Multiplayer();
            multiplayer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //Salir
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //Singleplayer
        {
            GameSP gameSP = new GameSP();
            gameSP.Show();
            this.Hide();
        }

        private void MenuApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
