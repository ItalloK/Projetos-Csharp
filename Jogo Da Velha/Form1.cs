namespace JogoDaVelha
{
    public partial class Form1 : Form
    {

        int XPlayer = 0, OPlayer = 0, EmpatesPontos = 0, Rodadas = 0;
        bool turno = true, fimjogo = false;
        string[] texto = new string[9];

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100);
        }
    }
}
