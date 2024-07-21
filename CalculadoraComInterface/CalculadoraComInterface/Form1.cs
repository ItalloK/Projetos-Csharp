namespace CalculadoraComInterface
{
    public partial class Form1 : Form
    {
        public double soma = 0;
        public int index = 0;
        public int[] valor = { -1, -1 };


        public Form1()
        {
            InitializeComponent();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            setValue(7);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            setValue(8);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setValue(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setValue(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setValue(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setValue(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setValue(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setValue(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setValue(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValue(0);
        }


        private void setValue(int val)
        {
            if (tb_tela.Text.Length < 11)
            {
                tb_tela.Text += val;
            }
            else
            {
                MessageBox.Show("Maximo de numeros digitados;");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            soma += int.Parse(tb_tela.Text);
            tb_telaNums.Text += tb_tela.Text + "+";
            tb_tela.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tb_tela.Text != "")
            {
                tb_telaNums.Text += tb_tela.Text;
                soma += int.Parse(tb_tela.Text);
                tb_tela.Text = soma.ToString();
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button10.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
                button7.Enabled = false;
                button6.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                tb_tela.Text = soma.ToString();
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button10.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
                button7.Enabled = false;
                button6.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
            }            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb_tela.Clear();
            tb_telaNums.Clear();
            soma = 0;
            button16.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button13.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
        }
    }
}
