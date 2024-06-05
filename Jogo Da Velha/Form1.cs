using System.Media;
using System.Runtime.ConstrainedExecution;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        private static string soundSelecionado = "";
        string[] soundsFla = new string[]
        {
            "sounds\\audiofla.wav",
            "sounds\\babigol.wav",
            "sounds\\hinogolfla.wav"
        };
        private static string valorSelecionado = "";

        int XPlayer = 0, OPlayer = 0, EmpatesPontos = 0, Rodadas = 0;
        bool turno = true, fimjogo = false;
        string[] texto = new string[9];
        Boolean isFlamengo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btm_Click(object sender, EventArgs e)
        {
            Button btm = (Button)sender;

            int buttonIndex = btm.TabIndex;

            if (btm.Text == "" && fimjogo == false)
            {
                if (turno)
                {
                    btm.Text = "X";
                    texto[buttonIndex] = btm.Text;
                    Rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btm.Text = "O";
                    texto[buttonIndex] = btm.Text;
                    Rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }

        }


        void Vencedor(int PlayerCampeao)
        {
            if (isFlamengo == true)
            {
                Random random = new Random();
                int indiceAleatorio = random.Next(soundsFla.Length);
                valorSelecionado = soundsFla[indiceAleatorio];
                tocarFlamengo();
            }
            fimjogo = true;
            if (PlayerCampeao == 1)
            {
                XPlayer++;
                PontosX.Text = Convert.ToString(XPlayer);
                MessageBox.Show("Jogador X ganhou!!");
                turno = true;
            }
            else
            {
                OPlayer++;
                BolaPontos.Text = Convert.ToString(OPlayer);
                MessageBox.Show("Jogador O ganhou!!");
                turno = false;
            }
            

        }

        void Checagem(int ChecagemPlayer)
        {
            string Suporte = "";

            if (ChecagemPlayer == 1)
            {
                Suporte = "X";
            }
            else
            {
                Suporte = "O";
            }

            for (int horiz = 0; horiz < 8; horiz += 3)
            {
                if (Suporte == texto[horiz])
                {
                    if (texto[horiz] == texto[horiz + 1] && texto[horiz] == texto[horiz + 2])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            for (int vert = 0; vert < 3; vert++)
            {
                if (Suporte == texto[vert])
                {
                    if (texto[vert] == texto[vert + 3] && texto[vert] == texto[vert + 6])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            if (texto[0] == Suporte)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8]) // Principal
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }
            }
            if (texto[2] == Suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6]) // Secundaria
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }
            }

            if (Rodadas == 9 && fimjogo == false)
            {
                EmpatesPontos++;
                Empates.Text = Convert.ToString(EmpatesPontos);
                MessageBox.Show("Jogo Empatou!!");
                fimjogo = true;
                return;
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            funcLimpar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100);
        }

        private void pretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcLimpar();
            isFlamengo = false;
            string imagePath = "themes\\temapreto.png";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            AlterarFundoBotao(Color.FromArgb(128, 128, 128));
            AlterarCorFonte(Color.White);
            AlterarCorBorda(Color.White);
        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcLimpar();
            isFlamengo = false;
            string imagePath = "themes\\temarosa.png";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            AlterarFundoBotao(Color.FromArgb(255, 192, 255));
            AlterarCorFonte(Color.Black);
            AlterarCorBorda(Color.FromArgb(255, 0, 255));
        }

        private void AlterarCorBorda(Color cor)
        {
            btm.FlatAppearance.BorderColor = cor;
            button2.FlatAppearance.BorderColor = cor;
            button1.FlatAppearance.BorderColor = cor;
            button3.FlatAppearance.BorderColor = cor;
            button4.FlatAppearance.BorderColor = cor;
            button5.FlatAppearance.BorderColor = cor;
            button6.FlatAppearance.BorderColor = cor;
            button7.FlatAppearance.BorderColor = cor;
            button8.FlatAppearance.BorderColor = cor;
            btnlimpar.FlatAppearance.BorderColor = cor;
        }

        private void AlterarCorFonte(Color cor)
        {
            btm.ForeColor = cor;
            button2.ForeColor = cor;
            button1.ForeColor = cor;
            button3.ForeColor = cor;
            button4.ForeColor = cor;
            button5.ForeColor = cor;
            button6.ForeColor = cor;
            button7.ForeColor = cor;
            button8.ForeColor = cor;
            btnlimpar.ForeColor = cor;
        }

        private void AlterarFundoBotao(Color cor)
        {
            btnlimpar.BackColor = cor;
            button2.FlatAppearance.MouseOverBackColor = cor;
            btm.FlatAppearance.MouseOverBackColor = cor;
            button1.FlatAppearance.MouseOverBackColor = cor;
            button3.FlatAppearance.MouseOverBackColor = cor;
            button4.FlatAppearance.MouseOverBackColor = cor;
            button5.FlatAppearance.MouseOverBackColor = cor;
            button6.FlatAppearance.MouseOverBackColor = cor;
            button7.FlatAppearance.MouseOverBackColor = cor;
            button8.FlatAppearance.MouseOverBackColor = cor;
        }

        private void flamengoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcLimpar();
            isFlamengo = true;
            string imagePath = "themes\\temaflamengo.png";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            AlterarCorFonte(Color.White);
            /* Cor quando passa o mouse por cima */
            btm.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 211, 211);

            /* Bordas dos Botões */
            btm.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
            button3.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
            button7.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
            button8.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
            btnlimpar.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);


            btnlimpar.BackColor = Color.FromArgb(0, 0 ,0); //quando passao mouse em cima
        }

        private void tocarFlamengo()
        {
            SoundPlayer simpleSound = new SoundPlayer(valorSelecionado);
            simpleSound.Play();
        }

        private void funcLimpar()
        {
            btm.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            Rodadas = 0;
            fimjogo = false;
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";

            }
        }
    }
}
