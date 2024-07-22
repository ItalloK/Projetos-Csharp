namespace LoginRegistroLocal
{
    partial class reglogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Nick = new TextBox();
            btn_Login = new Button();
            label1 = new Label();
            label2 = new Label();
            tb_Senha = new TextBox();
            SuspendLayout();
            // 
            // tb_Nick
            // 
            tb_Nick.Location = new Point(12, 27);
            tb_Nick.Name = "tb_Nick";
            tb_Nick.Size = new Size(169, 23);
            tb_Nick.TabIndex = 0;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(12, 100);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(169, 23);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Digite seu nick:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite sua senha:";
            // 
            // tb_Senha
            // 
            tb_Senha.Location = new Point(12, 71);
            tb_Senha.Name = "tb_Senha";
            tb_Senha.PasswordChar = '*';
            tb_Senha.Size = new Size(169, 23);
            tb_Senha.TabIndex = 1;
            // 
            // reglogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 137);
            Controls.Add(tb_Senha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Login);
            Controls.Add(tb_Nick);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "reglogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login e Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Nick;
        private Button btn_Login;
        private Label label1;
        private Label label2;
        private TextBox tb_Senha;
    }
}
