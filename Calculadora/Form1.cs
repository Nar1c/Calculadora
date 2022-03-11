using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double acumular = 0;
        double salve = 0;
        string operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void labelResultado_Click(object sender, EventArgs e)
        {

        }


        private void buttonZero_Click(object sender, EventArgs e)
        {
           labelSalve.Text += "0";

        }//0

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "1";
            }
            else
            {
                labelSalve.Text += "1";
            }
        }//1

        private void buttonDois_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "2";
            }
            else
            {
                labelSalve.Text += "2";
            }
        }//2

        private void buttonTres_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "3";
            }
            else
            {
                labelSalve.Text += "3";
            }
        }//3

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "4";
            }
            else
            {
                labelSalve.Text += "4";
            }
        }//4

        private void buttonCinco_Click(object sender, EventArgs e)
        { 
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "5";
            } 
            else
            {
                labelSalve.Text += "5";
            }
        }//5

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "6";
            }
            else
            {
                labelSalve.Text += "6";
            }
        }//6

        private void buttonSete_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "7";
            }
            else
            {
                labelSalve.Text += "7";
            }
        }//7

        private void buttonOito_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "8";
            }
            else
            {
                labelSalve.Text += "8";
            }
        }//8

        private void buttonNove_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text == "0")
            {
                labelSalve.Text = "9";
            }
            else
            {
                labelSalve.Text += "9";
            }
        }//9


        private void labelResultad_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            labelSalve.Text += ",";
        }
        private void buttonMaisMenos_Click(object sender, EventArgs e)
        {
            double maismenos = double.Parse(labelSalve.Text);
            if (maismenos > 0)
            {
                labelSalve.Text = "-" + labelSalve.Text;
            }
            else if (maismenos < 0)
            {
                labelSalve.Text = labelSalve.Text.Substring(1);
            }
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            operacao = "+";
            labelSalve.Text = "0";

        }
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            operacao = "-";
            labelSalve.Text = "0";
        }
        private void buttonVezes_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            operacao = "*";
            labelSalve.Text = "0";
        }
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            operacao = "/";
            labelSalve.Text = "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "+": soma(); break;
                case "-": subtracao(); break;
                case "/": divisao(); break;
                case "*": multiplicacao(); break;
                case "%": porcento(); break;
            }
        }

        private void soma()
        {
            acumular += double.Parse(labelSalve.Text);
            labelSalve.Text = acumular.ToString();
            acumular = 0;
            operacao = "";
        }
        private void subtracao()
        {
            acumular -= double.Parse(labelSalve.Text);
            labelSalve.Text = acumular.ToString();
            acumular = 0;
            operacao = "";
        }
        private void divisao()
        {
            acumular /= double.Parse(labelSalve.Text);
            labelSalve.Text = acumular.ToString();
            acumular = 0;
            operacao = "";
        }
        private void multiplicacao()
        {
            acumular *= double.Parse(labelSalve.Text);
            labelSalve.Text = acumular.ToString();
            acumular = 0;
            operacao = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (labelSalve.Text.Length > 1)
            {
                labelSalve.Text = labelSalve.Text.Substring(0, labelSalve.Text.Length - 1);
            }
            else
            {
                labelSalve.Text = "0";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            labelSalve.Text = "0";
                acumular = 0;
                operacao = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelSalve.Text = "0";
        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            acumular *= acumular;
            labelSalve.Text = acumular.ToString();
            acumular = 0;
        }

        private void buttonDividirUm_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            acumular = 1 / acumular;
            labelSalve.Text = acumular.ToString();
            acumular = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonFeliz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bazinga!");
        }

        private void buttonPorcentagem_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            operacao = "%";
            labelSalve.Text = "0";
        }
        private void porcento()
        {
            acumular /= 100;
            acumular *= double.Parse(labelSalve.Text);
            labelSalve.Text = acumular.ToString();
            acumular = 0;
            operacao = "";
        }

        private void buttonRaizQuadrada_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelSalve.Text);
            acumular = Math.Sqrt(acumular);
            labelSalve.Text = acumular.ToString();
            acumular = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelSalve.Text = salve.ToString();
            labelMR.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salve += double.Parse(labelSalve.Text);
            labelMR.Text = salve.ToString();
            labelSalve.Text = "0";        }

        private void button3_Click(object sender, EventArgs e)
        {
            salve -= double.Parse(labelSalve.Text);
            labelMR.Text = salve.ToString();
            labelSalve.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelMR.Text = "";
            salve = 0;
        }
    }

}
