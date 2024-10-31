using FazendaUrbanaDesktop.Classes;
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
    public partial class frmCliente : Form
    {
        Entities data = new Entities();
        public frmCliente()
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

        private void btnOS_Click(object sender, EventArgs e)
        {
            frmOS frmOS = new frmOS();
            frmOS.Show();
            this.Close();
        }

        private void mtxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ckType_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCPF.Text = "";
            if (!ckType.Checked)
            {
                mtxtCPF.Mask = "00,000,000/0000-00";
            }
            else
            {
                mtxtCPF.Mask = "000,000,000/00";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clients Client = new clients();
            if (ckType.Checked)
            {
                String _cpf = mtxtCPF.Text.Replace(".", "");
                _cpf = _cpf.Replace("/", "");
                _cpf = _cpf.Replace(" ", "");
                Client.cpf = _cpf;
            }
            else
            {
                String _cnpj = mtxtCPF.Text.Replace(".", "");
                _cnpj = _cnpj.Replace("/", "");
                _cnpj = _cnpj.Replace("-", "");
                _cnpj = _cnpj.Replace(" ", "");
                Client.cpf = _cnpj;
            }

            String _tel = mtxtTel.Text.Replace("-", "");
            _tel = _tel.Replace("(", "");
            _tel = _tel.Replace(")", "");
            Client.phone = _tel;

            Client.name = txtNome.Text;
            Client.adress = txtEnd.Text;

            data.clients.Add(Client);
            data.SaveChanges();
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
