using FazendaUrbanaDesktop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaUrbanaDesktop
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void BuscarTodosFunc(FuncionarioRepositorio funcionarioRepositorio)
        {
            var funcionarios = funcionarioRepositorio.BuscarTodosFunc();
            dgRelatorio.DataSource = funcionarios.ToList();
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

        private void btnOS_Click(object sender, EventArgs e)
        {
            frmOS frmOS = new frmOS();
            frmOS.Show();
            this.Close();
        }
        

        private void combListagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entities data = new Entities();//instanciando a conexão com o banco para poder utilizar os recursos do entity

            if (combListagem.Text == "Listar ordens de serviços")//verificando conteudo da combo
            {
                List<os> Os = new List<os>();//criando a lista do tipo os do entity
                Os = data.os.ToList(); // transformando os dados da Os em lista e armazenando dentro da lista criada
                dgRelatorio.DataSource = Os;//colocando o source da datag para exibir os dados

            }else if (combListagem.Text == "Listar clientes")//verificando o conteudo da combo
            {
                List<clients> Clients = new List<clients>();//o resto é feito da mesma maneira porem com tabelas diferentes
                Clients = data.clients.ToList();
                dgRelatorio.DataSource = Clients;

            }else if (combListagem.Text == "Listar fornecedores") {

                List<suppliers> Suppliers = new List<suppliers>();
                Suppliers = data.suppliers.ToList();
                dgRelatorio.DataSource = Suppliers;
            }else if (combListagem.Text == "Listar produtos")
            {
                List<products> Products = new List<products>();
                Products = data.products.ToList();
                dgRelatorio.DataSource = Products;
            }else if (combListagem.Text == "Listar funcionários")
            {
                List<employees> Employees = new List<employees>();
                Employees = data.employees.ToList();
                dgRelatorio.DataSource = Employees;
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            combListagem.Text = "Listar ordens de serviços";
        }
    }
}
