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
    public partial class frmCarregamento : Form
    {
        public frmCarregamento()
        {
            InitializeComponent();
        }

        private void frmCarregamento_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                lblPorcentagem.Text = progressBar1.Value.ToString() + "%";
            }else
            {
                timer1.Stop();

                MessageBox.Show("Bem vindo ao sistema!", "Olá", MessageBoxButtons.OK);

                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();

                
            }
        }
    }
}
