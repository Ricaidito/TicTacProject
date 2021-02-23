using System;
using System.Windows.Forms;

namespace TicTacProject
{
    public partial class GameSP : Form
    {
        MenuApp menu = new MenuApp();
        public GameSP()
        {
            InitializeComponent();
        }

        public bool CheckButtons() //Revisa si todos los botones están presionados
        {
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                return true;
            else return false;
        }

        public void IA() //Computadora
        {
            Random random = new Random();
            int randomNumer = random.Next(1, 9);
            bool jugadaIA = false;

            while (!jugadaIA && !CheckButtons())
            {
                switch (randomNumer)
                {
                    case 1:
                        if (button1.Enabled)
                        {
                            button1.Enabled = false;
                            button1.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 2:
                        if (button2.Enabled)
                        {
                            button2.Enabled = false;
                            button2.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 3:
                        if (button3.Enabled)
                        {
                            button3.Enabled = false;
                            button3.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 4:
                        if (button4.Enabled)
                        {
                            button4.Enabled = false;
                            button4.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 5:
                        if (button5.Enabled)
                        {
                            button5.Enabled = false;
                            button5.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 6:
                        if (button6.Enabled)
                        {
                            button6.Enabled = false;
                            button6.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 7:
                        if (button7.Enabled)
                        {
                            button7.Enabled = false;
                            button7.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 8:
                        if (button8.Enabled)
                        {
                            button8.Enabled = false;
                            button8.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                    case 9:
                        if (button9.Enabled)
                        {
                            button9.Enabled = false;
                            button9.Text = "O";
                            jugadaIA = true;
                        }
                        else randomNumer = random.Next(1, 9);
                        break;
                }
            }
        }

        public bool CheckBoard() //Revisa qué jugador ganó
        {
            //Condiciones horizontales
            bool horizontal1 = button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "";
            bool horizontal2 = button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "";
            bool horizontal3 = button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "";
            //Condiciones verticales
            bool vertical1 = button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "";
            bool vertical2 = button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "";
            bool vertical3 = button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "";
            //Condiciones diagonales
            bool diag1 = button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "";
            bool diag2 = button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "";
            //Condición de empate
            bool empate = button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "";

            if (horizontal1)
            {
                if (button1.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();
                }
                else if (button1.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }

            else if (horizontal2)
            {
                if (button4.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                else if (button4.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }

            else if (horizontal3)
            {
                if (button7.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                else if (button7.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }

            else if (vertical1)
            {
                if (button1.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                else if (button1.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }

            else if (vertical2)
            {
                if (button2.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                else if (button2.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }
            
            else if (vertical3)
            {
                if (button3.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                else if (button3.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }

            else if (diag1)
            {
                if (button9.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                else if (button9.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }

            else if (diag2)
            {
                if (button7.Text == "X")
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                else if (button7.Text == "O")
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show(label1.Text);
                    this.Close();
                    menu.Show();

                }
                return true;
            }
            
            else if (empate)
            {
                label1.Text = "Empate!";
                MessageBox.Show(label1.Text);
                this.Close();
                menu.Show();

                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            button1.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            button2.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            button3.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            button4.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            button5.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            button6.Enabled = false;
            CheckBoard();
            IA();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            button7.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            button8.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            button9.Enabled = false;
            CheckBoard();
            IA();
            CheckBoard();
        }

        private void GameSP_Load(object sender, EventArgs e)
        {

        }

        private void GameSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
