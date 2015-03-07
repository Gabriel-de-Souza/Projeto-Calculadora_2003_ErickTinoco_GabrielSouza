using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        Calculador calc;
        public float value1;
        public bool enter1;

        public float value2;
        public bool enter2;

        public bool subs;

        public float valueFinal;

        public string operacao;

        public bool resultado;
        
        public Form1()
        {
            InitializeComponent();
            calc = new Calculador();
            enterValue.Text = "0";
        }

        private void Digitou(object sender, EventArgs e)
        {
            Button digito = sender as Button;
            if (subs)
            {
                if (digito.Text == ",")
                {
                    enterValue.Text = "0,";
                }
                else
                {
                    enterValue.Text = digito.Text;
                }
                subs = false;
            }
            else
            {
                if (enterValue.Text != "0" || digito.Text == ",")
                {
                    if (digito.Text == ",")
                    {
                        if (enterValue.Text.IndexOf(",") < 0)
                        {
                            enterValue.Text += digito.Text;
                        }
                    }
                    else
                    {
                        enterValue.Text += digito.Text;
                    }
                }
                else
                {
                    enterValue.Text = digito.Text;
                }
            }
        }

        private void operacaoBasica(object sender, EventArgs e)
        {
            Button digito = sender as Button;
            if (!enter1 || resultado)
            {
                value1 = float.Parse(enterValue.Text);
                operacao = digito.Text;
                enter1 = true;
                subs = true;
                enter2 = false;
                resultado = false;
                countView.Text += value1 + " " + operacao;
            }
            else 
            {
                value2 = float.Parse(enterValue.Text);
                enter2 = false;
                valueFinal = Calcular(value1, value2, operacao);
                enterValue.Text = "" + valueFinal;
                subs = true;
                value1 = valueFinal;
                operacao = digito.Text;
                countView.Text += " " + value2 + " " + operacao + " ";
            }
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            if (!enter2)
            {
                value2 = float.Parse(enterValue.Text);
                enter2 = true;
                valueFinal = Calcular(value1, value2, operacao);
                enterValue.Text = "" + valueFinal;
                subs = true;
                resultado = true;
            }
            else 
            {
                value1 = float.Parse(enterValue.Text);
                valueFinal = Calcular(value1, value2, operacao);
                enterValue.Text = "" + valueFinal;
                subs = true;
                enter1 = false;
            }
            countView.Text = "";
        }


        private void sqrt_Click(object sender, EventArgs e)
        {
            enterValue.Text = "" + Math.Sqrt(float.Parse(enterValue.Text));
        }

        private void pot_Click(object sender, EventArgs e)
        {
            enterValue.Text = "" + float.Parse(enterValue.Text) * float.Parse(enterValue.Text);
        }

        private void ce_Click(object sender, EventArgs e)
        {
            enterValue.Text = "0";
        }

        private void sin_Click(object sender, EventArgs e)
        {
            enterValue.Text = "" + Math.Sin(double.Parse(enterValue.Text));
        }

        private void cos_Click(object sender, EventArgs e)
        {
            enterValue.Text = "" + Math.Cos(double.Parse(enterValue.Text));
        }

        private void tg_Click(object sender, EventArgs e)
        {
            enterValue.Text = "" + Math.Atan(double.Parse(enterValue.Text));
        }

        public float Calcular(float v1, float v2, string operacao) 
        {
            switch (operacao)
            {
                case "+":
                    return calc.soma(v1, v2);

                case "-":
                    return calc.menos(v1, v2);

                case "*":
                    return calc.multi(v1, v2);

                case "/":
                    return calc.div(v1, v2);

                case "RESTO":
                    return calc.resto(v1, v2);

                case "%":
                    return calc.porC(v1, v2);

                default:
                    return 0;
            }
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            enterValue.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            enterValue.Text = "0";
            operacao = null;
            subs = false;
            value2 = 0;
            enter2 = false;
            value1 = 0;
            enter1 = false;
            subs = false;
            resultado = false;
        }
    }

    public class Calculador
    {
        public float soma(float value1, float value2)
        {
            return value1 + value2;
        }

        public float menos(float value1, float value2)
        {
            return value1 - value2;
        }

        public float multi(float value1, float value2)
        {
            return value1 * value2;
        }

        public float div(float value1, float value2)
        {
            return value1 / value2;
        }

        public float resto(float value1, float value2)
        {
            return value1 % value2;
        }

        public float porC(float value1, float value2)
        {
            return (value1 * value2) / 100;
        }
    }

}
