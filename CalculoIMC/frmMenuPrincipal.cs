using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            frmImc abrir = new frmImc();
            abrir.Show();
            this.Hide();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pcbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCombustivel_Click(object sender, EventArgs e)
        {
            frmCombustivel abrir = new frmCombustivel();
            abrir.Show();
            this.Hide();
        }

        private void pcbSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            frmFolhaPagamento abrir = new frmFolhaPagamento();
            abrir.Show();
            this.Hide();
        }
    }
}
