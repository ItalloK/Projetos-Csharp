using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChamarKey();
        }

        private void ChamarKey()
        {
            this.Hide();
            F_KeyLogin f_KeyLogin = new F_KeyLogin();
            f_KeyLogin.ShowDialog();
        }
    }
}
