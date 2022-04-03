using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBBank_v2
{
    public partial class frmLogin : Form
    {

        public string Numero { get; private set; }
        public string Senha { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Numero = txtNumeroConta.Text;
            this.Senha = txtSenha.Text;
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtNumeroConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
