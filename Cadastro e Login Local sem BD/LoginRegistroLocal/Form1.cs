namespace LoginRegistroLocal
{
    public partial class reglogin : Form
    {
        public string nick;
        private string senha;
        private string pastaRaiz = Directory.GetCurrentDirectory();

        public reglogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            nick = tb_Nick.Text;
            senha = tb_Senha.Text;
            string filePath = Path.Combine(pastaRaiz, (nick + ".txt"));
            try
            {
                if (File.Exists(filePath))
                {
                    string text = File.ReadAllText(filePath);
                    if (text == senha)
                    {
                        this.Hide();
                        BoasVindas bv = new BoasVindas(nick);
                        bv.Show();
                    }
                    else
                    {
                        MessageBox.Show("Você errou a senha...");
                        this.Close();
                    }
                }
                else
                {
                    File.WriteAllText(filePath, senha);
                    MessageBox.Show("Novo usuário criado!");
                    this.Hide();
                    BoasVindas bv = new BoasVindas(nick);
                    bv.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
