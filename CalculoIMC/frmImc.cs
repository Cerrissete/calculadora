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
    public partial class frmImc : Form
    {
        public frmImc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       double numPeso, numAltura, imc = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            numAltura = Convert.ToDouble(mskAltura.Text);
            numPeso = Convert.ToDouble(mskPeso.Text);

            imc = numPeso / (numAltura * numAltura);
            

            txtImc.Text = imc.ToString();
          
            if (imc <= 18.5)
            {
                lblResult.Text = "Seu resultdo é desnutrido";
            }

            if (imc >= 18.6)
            {
                lblResult.Text = "Seu resultado é padrao";
            }

            if (imc >= 25)
            {
                lblResult.Text = "Seu resultado é gordao em pae";
            }

            if (imc >= 30)
            {
                lblResult.Text = "Seu resultado é enorme";
            }

            if (imc >= 40)
            {
                lblResult.Text = "Seu resultado é imenso";
            }


        }
        
        private void lblIMC_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void limparCampos()
        {
            mskAltura.Clear();
            txtImc.Clear();
            mskPeso.Clear();
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos(); 
        }
    }
}
