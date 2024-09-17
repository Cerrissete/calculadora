using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaABC
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDivisao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // se estiver vazio, irá fazer esses comandos abaixo
            if (txtVariavel1.Text == "")
            {
                MessageBox.Show("Preencha a váriavel 1! ", "Alerta", MessageBoxButtons.OK);
            }


            if (txtVariavel2.Text == "")
            {
                MessageBox.Show("Preencha a váriavel 2!", "Alerta", MessageBoxButtons.OK);
            }


            if (rdbAdicao.Checked || rdbSubtracao.Checked || rdbMultiplicacao.Checked || rdbDivisao.Checked)
            {
                lblResult.Focus();
            }

            else
            {
                MessageBox.Show("Escolha qual operação será usada.", "Alerta");
            }


            //lógica operações

            double num1, num2, soma, sub, multi, div = 0;


            try { 
                num1 = Convert.ToDouble(txtVariavel1.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números na variavel 1");
                return;
            }

            try
            {
                num2 = Convert.ToDouble(txtVariavel2.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números na variavel 2");
                return;
            }
          
            num1 = Convert.ToDouble(txtVariavel1.Text);
            num2 = Convert.ToDouble(txtVariavel2.Text);


            if (rdbAdicao.Checked == true)
            {
                soma = num1 + num2;
                lblResult.Text = soma.ToString();

            }

            if (rdbSubtracao.Checked == true)
            {
                sub = num1 - num2;
                lblResult.Text = sub.ToString();

            }

            if (rdbMultiplicacao.Checked == true)
            {
                multi = num1 * num2;
                lblResult.Text = multi.ToString();
            }

            if (rdbDivisao.Checked == true)
            {
                div = num1 / num2;
                lblResult.Text = div.ToString();
            }

            if (num1 == 0 && rdbDivisao.Checked)
            {
                MessageBox.Show("Não é possivel dividir o numero por 0");
                
            }

            if (num2 == 0 && rdbDivisao.Checked)
            {
                MessageBox.Show("Não é possivel dividir o numero por 0");
                
            }

        }

        public void limparCampos()
        {
            txtVariavel1.Clear();
            txtVariavel2.Clear();
            rdbAdicao.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;
            lblResult.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
