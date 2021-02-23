using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TicTacProject
{
    public partial class Game : Form
    {
        //Variables de apoyo
        private char jugador;
        private char oponente;
        
        //Variables para la conexión
        private Socket s;
        private BackgroundWorker dataReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient cliente;

        public Game(bool isHost, string ip = null)
        {
            InitializeComponent();
            dataReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if(isHost) //Si es host empieza la conexión
            {
                jugador = 'X';
                oponente = 'O';
                server = new TcpListener(System.Net.IPAddress.Any, 5050);
                server.Start();
                s = server.AcceptSocket();
            }
            else //De lo contrario conectate al servidor del otro lado
            {
                jugador = 'O';
                oponente = 'X';
                try //Intenta conectarte, de lo contrario cierra la ventana y muestra el error
                {
                    cliente = new TcpClient(ip, 5050);
                    s = cliente.Client;
                    dataReceiver.RunWorkerAsync();
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error: " + exception.Message);
                    Close();
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e) //Aquí manejamos los turnos
        {
            if (CheckTab())
                return;

            FreezeTab();
            label1.Text = "Espera por tu oponente";

            RecibirMov();
            label1.Text = "Es tu turno!";

            if (!CheckTab())
                ActivarTab();
        }

        private bool CheckTab() //Revisamos el tablero por si un jugador ganó
        {
            //Revisión de horizontales
            if(button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                if(button1.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            {
                if (button4.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            {
                if (button7.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            //Revisión de verticales
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {
                if (button1.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {
                if (button2.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            {
                if (button3.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (button1.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (button3.Text[0] == jugador)
                {
                    label1.Text = "Has ganado!";
                    MessageBox.Show("Has ganado!");
                }
                else
                {
                    label1.Text = "Perdiste";
                    MessageBox.Show("Perdiste");
                }
                return true;
            }

            //En caso de que no gane ningún jugador
            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "Empate!";
                MessageBox.Show("Empate!");
                return true;
            }
            return false;
        }
        private void FreezeTab() //Desactivar el tablero
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void ActivarTab() //Activar el tablero para las casillas vacias
        {
            if (button1.Text == "")
                button1.Enabled = true;

            if (button2.Text == "")
                button2.Enabled = true;

            if (button3.Text == "")
                button3.Enabled = true;

            if (button4.Text == "")
                button4.Enabled = true;

            if (button5.Text == "")
                button5.Enabled = true;

            if (button6.Text == "")
                button6.Enabled = true;

            if (button7.Text == "")
                button7.Enabled = true;

            if (button8.Text == "")
                button8.Enabled = true;

            if (button9.Text == "")
                button9.Enabled = true;
        }

        private void RecibirMov() //Recibir datos en el socket
        {
            byte[] buffer = new byte[1];
            s.Receive(buffer);

            if (buffer[0] == 1)
                button1.Text = oponente.ToString();

            if (buffer[0] == 2)
                button2.Text = oponente.ToString();

            if (buffer[0] == 3)
                button3.Text = oponente.ToString();

            if (buffer[0] == 4)
                button4.Text = oponente.ToString();

            if (buffer[0] == 5)
                button5.Text = oponente.ToString();

            if (buffer[0] == 6)
                button6.Text = oponente.ToString();

            if (buffer[0] == 7)
                button7.Text = oponente.ToString();

            if (buffer[0] == 8)
                button8.Text = oponente.ToString();

            if (buffer[0] == 9)
                button9.Text = oponente.ToString();
        }

        //Enviar los valores al rival
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 };
            s.Send(num);
            button1.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 };
            s.Send(num);
            button2.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 };
            s.Send(num);
            button3.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 };
            s.Send(num);
            button4.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] num = { 5 };
            s.Send(num);
            button5.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] num = { 6 };
            s.Send(num);
            button6.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] num = { 7 };
            s.Send(num);
            button7.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] num = { 8 };
            s.Send(num);
            button8.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] num = { 9 };
            s.Send(num);
            button9.Text = jugador.ToString();
            dataReceiver.RunWorkerAsync();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataReceiver.WorkerSupportsCancellation = true;
            dataReceiver.CancelAsync();
            
            if (server != null)
                server.Stop();

            Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
