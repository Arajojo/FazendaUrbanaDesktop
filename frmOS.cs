﻿using FazendaUrbanaDesktop.Classes;
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
    public partial class frmOS : Form
    {
        public frmOS()
        {
            InitializeComponent();
        }
        Entities data = new Entities();
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//btnEnviar
        {
            os Os = new os();
            Os.dateEmi = DateTime.Now.Date;
            Os.entregaProd = dtEntregaProd.Value;

            Os.employeeId = int.Parse(mtxtFunc.Text);
            Os.productId = int.Parse(txtIdProd.Text);
            Os.quantity = int.Parse(nQtd.Value.ToString());

            if (ckType.Checked)
            {
                String _cpf = mtxtCPF.Text.Replace(".", "");
                _cpf = _cpf.Replace("/", "");
                _cpf = _cpf.Replace(" ", "");
                Os.clientCpf = _cpf;
            }
            else
            {
                String _cnpj = mtxtCPF.Text.Replace(".", "");
                _cnpj = _cnpj.Replace("/", "");
                _cnpj = _cnpj.Replace("-", "");
                _cnpj = _cnpj.Replace(" ", "");
                Os.clientCpf = _cnpj;
            }
            

            data.os.Add(Os);
            data.SaveChanges();
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void frmOS_Load(object sender, EventArgs e)//evento quando o formulario carregar
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//txtIdProd
        {
            if (txtIdProd.Text != "")
            {
               int.TryParse(txtIdProd.Text, out int _id);
               products Product = new products();
                Product = Produto.GetProduct(_id);
                if (Product != null)
                {
                    
                    txtTitleProd.Text = Product.title;
                    txtIdProd.Text = Product.id.ToString();
                    txtValor.Text = OS.calcPrice(decimal.Parse(cmbDescont.Text), Product.price, nQtd.Value).ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum Produto encontrado!", "Resultado Busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitleProd.Text = "";
                    txtValor.Text = "0";
                }
                
            }
            else
            {
                txtIdProd.Text = "0";
                txtTitleProd.Text = "";
                txtValor.Text = "0";
            }
        }

        private void nQtd_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(txtIdProd.Text, out int _id);
            products Product = new products();
            Product = data.products.Where(c => c.id == _id).FirstOrDefault();
            if (Product != null)
            {
                txtTitleProd.Text = Product.title;
                txtIdProd.Text = Product.id.ToString();
                txtValor.Text = OS.calcPrice(decimal.Parse(cmbDescont.Text), Product.price, nQtd.Value).ToString();
            }
            else
            {
                txtValor.Text = "0";
            }
        }

        private void cmbDescont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDescont.Text == "")
            {
                cmbDescont.Text = "0";
            }

            int.TryParse(txtIdProd.Text, out int _id);
            products Product = new products();
            Product = data.products.Where(c => c.id == _id).FirstOrDefault();
            if (Product != null)
            {
                txtTitleProd.Text = Product.title;
                txtIdProd.Text = Product.id.ToString();
                txtValor.Text = OS.calcPrice(decimal.Parse(cmbDescont.Text), Product.price, nQtd.Value).ToString();
            }
        }

        private void mtxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void mtxtCPF_LostFocus(object sender, EventArgs e)
        {
            if (ckType.Checked)
            {
                String _cpf = mtxtCPF.Text.Replace(".", "");
                _cpf = _cpf.Replace("/", "");
                _cpf = _cpf.Replace(" ", "");
                
                if (_cpf.Length == 11)
                {
                    clients Client = new clients();

                    Client = data.clients.Where(c => c.cpf == _cpf).FirstOrDefault();
                    if (Client != null)
                    {
                        txtClientName.Text = Client.name;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não cadastrado");
                    }
                }
                else
                {
                    MessageBox.Show("cpf invalido");
                }
            }
            else
            {
                String _cnpj = mtxtCPF.Text.Replace(".", "");
                _cnpj = _cnpj.Replace("/", "");
                _cnpj = _cnpj.Replace("-", "");
                _cnpj = _cnpj.Replace(" ", "");
                if (_cnpj.Length == 14)
                {
                    clients Client = new clients();

                    Client = data.clients.Where(c => c.cpf == _cnpj).FirstOrDefault();
                    if(Client != null)
                    {
                        txtClientName.Text = Client.name;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não cadastrado");
                    }
                }
                else
                {
                    MessageBox.Show("cnpj invalido");
                }
            }
            
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

        private void mtxtFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void mtxtFunc_LostFocus(object sender, EventArgs e)
        {
                int.TryParse(mtxtFunc.Text, out int _id);
            
            
                employees Employer = new employees();

                Employer = data.employees.Where(c => c.id == _id).FirstOrDefault();
                if (Employer != null)
                {
                    txtFuncName.Text = Employer.name;
                }
                else
                {
                    MessageBox.Show("Funcionario não cadastrado");
                    txtFuncName.Text = "";
                }
            
        }
    }
}
