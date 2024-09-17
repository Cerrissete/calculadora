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
    public partial class frmCombustivel : Form
    {
        public frmCombustivel()
        {
            InitializeComponent();
        }

        private void frmCombustivel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public void limparCampos()
        {
            txtConsumo.Clear();
            txtDistancia.Clear();
            txtPreco.Clear();
            lblTotal.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia, consumo, preco, calculo = 0;


           


                try
                {
                    distancia = Convert.ToDouble(txtDistancia.Text);


                }
                catch (Exception)
                {
                    MessageBox.Show("Digite apenas números no campo 1!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDistancia.Clear();
                    return;
                }
            
            try
            {
                consumo = Convert.ToDouble(txtConsumo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas números no campo 2!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsumo.Clear();
                return;

            }

            try
            {
                preco = Convert.ToDouble(txtPreco.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Digite apenas números no campo 3!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Clear();
                return;
            }

            distancia = Convert.ToDouble(txtDistancia.Text); 
            consumo = Convert.ToDouble(txtConsumo.Text);
            preco = Convert.ToDouble(txtPreco.Text);

            calculo = (distancia / consumo) * preco;

            lblTotal.Text = "R$" + calculo.ToString();

        }
    }
}
