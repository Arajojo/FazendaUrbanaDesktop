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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "admin";

            if (txtUser.Text == User & txtPassword.Text == Password)
            {
                frmMain FrmMain = new frmMain();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
