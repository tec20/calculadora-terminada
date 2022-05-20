using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_2
{
    public partial class Form1 : Form
    {
        double Primero;
        double Segundo;
        string Operador;
        public Form1()
        {
            InitializeComponent();
        }
        clases.ClsSuma obj = new clases.ClsSuma();
        clases.ClsResta obj2 = new clases.ClsResta();
        clases.ClsMultiplicacion obj3 = new clases.ClsMultiplicacion();
        clases.ClsDivision obj4 = new clases.ClsDivision();
        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operador = "+";
            Primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Segundo = double.Parse(tbxScreen.Text);
            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (Operador)
            {
                case "+":
                    Sum = obj.Sumar((Primero), (Segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar ((Primero), (Segundo));
                    tbxScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar ((Primero), (Segundo));
                    tbxScreen.Text = Mul.ToString();
                    break;
                case "/":
                    if (Segundo == 0) { tbxScreen.Text = "error system";}
                    else
                    {
                        Div = obj4.Division((Primero), (Segundo));
                        tbxScreen.Text = Div.ToString();
                    } 
                    break;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void tbxScreen_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }