using System;
using System.Windows.Forms;

namespace TicTacProject
{
    public partial class Multiplayer : Form
    {
        public Multiplayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Cuando se conecta
        {
            Game game = new Game(false, textBox1.Text);
            Visible = false;
            if (!game.IsDisposed)
                game.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) //Cuando se hostea
        {
            Game game = new Game(true);
            Visible = false;
            if (!game.IsDisposed)
                game.ShowDialog();
            Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Multiplayer_FormClosed(object sender, FormClosedEventArgs e) //Al cerrrar la ventana
        {
            this.Hide();
            MenuApp menu = new MenuApp();
            menu.Show();
        }
    }
}
