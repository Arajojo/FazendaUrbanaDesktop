using FazendaUrbanaDesktop.Classes;
using FazendaUrbanaDesktop.Repositories;
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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void SalvarFunc(object sender, EventArgs e)
        {
            var funcionario = new Funcionario(0,txtNomeFunc.Text, txtDocumentoFunc.Text, txtTelefoneFunc.Text, txtEnderecoFunc.Text, txtData_Adm.Text, txtData_Nasc.Text);
            var funcionarioRepositorio = new FuncionarioRepositorio();
            funcionarioRepositorio.Insert(funcionario);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomeFunc.Text = string.Empty;
            txtDocumentoFunc.Text = string.Empty;
            txtData_Adm.Text = string.Empty;
            txtEnderecoFunc.Text = string.Empty;
            txtTelefoneFunc.Text = string.Empty;
            txtData_Nasc.Text = string.Empty;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();
            frmProduto.Show();
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
