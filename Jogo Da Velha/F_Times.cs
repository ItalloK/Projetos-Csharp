using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class F_Times : Form
    {
        public static string time1 = "";
        public static string time2 = "";

        public F_Times()
        {
            InitializeComponent();
        }
        private void escolhaTime(string nomeTime)
        {
            if (time1 == "")
            {
                time1 = nomeTime;
                lbl_time1.Text = nomeTime;
            }
            else if (time2 == "")
            {
                time2 = nomeTime;
                lbl_time2.Text = nomeTime;
            }
            else
            {
                MessageBox.Show("Ja foi escolhido 2 times, clique em limpar.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            escolhaTime("Flamengo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escolhaTime("Vasco");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            escolhaTime("São Paulo");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escolhaTime("Santos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escolhaTime("Fluminense");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            escolhaTime("Atletico-Mg");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            escolhaTime("Botafogo");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            escolhaTime("Internacional");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escolhaTime("Bahia");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            escolhaTime("Fortaleza");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            escolhaTime("Corinthians");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            escolhaTime("Palmeiras");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            escolhaTime("Cruzeiro");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            escolhaTime("Grêmio");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            escolhaTime("Criciuma");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            escolhaTime("Athletico PR");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            escolhaTime("Bragantino");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            escolhaTime("EC Vitória");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            escolhaTime("Juventude");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            escolhaTime("Ceara");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            time1 = "";
            time2 = "";
            lbl_time1.Text = "...";
            lbl_time2.Text = "...";
            MessageBox.Show("Campos limpos, escolha os times novamente.");
        }
    }
}
