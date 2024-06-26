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
    public partial class F_KeyLogin : Form
    {
        public F_KeyLogin()
        {
            InitializeComponent();
        }

        private int VerificaKey()
        {
            var recebeValor = 0;
            if(recebeValor == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
