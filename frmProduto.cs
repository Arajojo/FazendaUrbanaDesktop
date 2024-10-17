using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbanaDesktop
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario frmFuncionario = new frmFuncionario();
            frmFuncionario.Show();
            this.Close();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor frmFornecedor = new frmFornecedor();
            frmFornecedor.Show();
            this.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.Show();
            this.Close();
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            frmOS frmOS = new frmOS();
            frmOS.Show();
            this.Close();
        }
    }
}
