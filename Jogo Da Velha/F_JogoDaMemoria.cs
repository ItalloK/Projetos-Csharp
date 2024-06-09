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
    public partial class F_JogoDaMemoria : Form
    {
        int movimentos, cliques, cartasEncontradas, tagIndex;
        Image[] img = new Image[9]; //  quantidade de imagens e n picture box



        public F_JogoDaMemoria()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                int tagIndex = int.Parse(String.Format("{0}",item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.FundoCartas; // poe as imagens para aparecer apenas o fundo;
                item.Enabled = true;
            }
        }

        private void Posicoes()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();

                int[] xP = { 23, 129, 235, 341, 447, 553 };
                int[] yP = { 27, 133, 239 };

                var X = xP[rdn.Next(0, xP.Length)];
                var Y = yP[rdn.Next(0, yP.Length)];

                item.Location = new Point(X, Y);
            }
        }
    }
}
