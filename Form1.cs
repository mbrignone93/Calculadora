using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Calculadora Por Maximiliano Brignone//
//Jueves 19 de Julio, 12:49 pm. Todos los derechos reservados//
//WinuE 2012//

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int x = 0;

        bool detectaoperacion = true;
        
        string operacion;
        string CopiarTexto;
        
        decimal resultado;
        decimal numero1;
        decimal numero2;
        decimal porcentaje;
        
        double raiz;
        double potencia;
        double seno;
        double coseno;
        double tangente;

        public Form1()
        {
            InitializeComponent();
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encendido_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                encendido.Text = "ON";
                encendido.BackColor = Color.Green;
                retroceso.Enabled = true;
                botonCE.Enabled = true;
                botonX3.Enabled = true;
                botonPI.Enabled = true;
                boton0.Enabled = true;
                boton1.Enabled = true;
                boton2.Enabled = true;
                boton3.Enabled = true;
                boton4.Enabled = true;
                boton5.Enabled = true;
                boton6.Enabled = true;
                boton7.Enabled = true;
                boton8.Enabled = true;
                boton9.Enabled = true;
                botonmasmenos.Enabled = true;
                botoncoma.Enabled = true;
                botondividir.Enabled = true;
                botonmultiplicar.Enabled = true;
                botonrestar.Enabled = true;
                botonsumar.Enabled = true;
                botonraiz.Enabled = true;
                botonporcentaje.Enabled = true;
                boton1x.Enabled = true;
                botonresultado.Enabled = true;
                botonSeno.Enabled = true;
                botonCoseno.Enabled = true;
                botonTangente.Enabled = true;
                botonMR.Enabled = true;
                x = 1;
            }
            else
            {
                if (x == 1)
                {
                    encendido.Text = "OFF";
                    encendido.BackColor = Color.Red;
                    retroceso.Enabled = false;
                    botonCE.Enabled = false;
                    botonX3.Enabled = false;
                    botonPI.Enabled = false;
                    boton0.Enabled = false;
                    boton1.Enabled = false;
                    boton2.Enabled = false;
                    boton3.Enabled = false;
                    boton4.Enabled = false;
                    boton5.Enabled = false;
                    boton6.Enabled = false;
                    boton7.Enabled = false;
                    boton8.Enabled = false;
                    boton9.Enabled = false;
                    botonmasmenos.Enabled = false;
                    botoncoma.Enabled = false;
                    botondividir.Enabled = false;
                    botonmultiplicar.Enabled = false;
                    botonrestar.Enabled = false;
                    botonsumar.Enabled = false;
                    botonraiz.Enabled = false;
                    botonporcentaje.Enabled = false;
                    boton1x.Enabled = false;
                    botonresultado.Enabled = false;
                    botonSeno.Enabled = false;
                    botonCoseno.Enabled = false;
                    botonTangente.Enabled = false;
                    botonMR.Enabled = false;
                    txtDisplay.Text = "0";
                    x = 0;
                }
            }
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                return;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "1";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "2";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "3";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "4";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "5";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "6";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "7";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "8";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtDisplay.Text = "";
                txtDisplay.Text = "9";
                detectaoperacion = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void botonCE_Click(object sender, EventArgs e)
        {
            detectaoperacion = true;
            txtDisplay.Text = "0";
        }

        private void botonC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void retroceso_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                detectaoperacion = true;
            }
        }

        private void botonsumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            detectaoperacion = true;
            numero1 = decimal.Parse(txtDisplay.Text);
        }

        private void botonrestar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            detectaoperacion = true;
            numero1 = decimal.Parse(txtDisplay.Text);
        }

        private void botonmultiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            detectaoperacion = true;
            numero1 = decimal.Parse(txtDisplay.Text);
        }

        private void botondividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            detectaoperacion = true;
            numero1 = decimal.Parse(txtDisplay.Text);
        }

        private void botonresultado_Click(object sender, EventArgs e)
        {
            numero2 = decimal.Parse(txtDisplay.Text);
            detectaoperacion = true;
            
            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    txtDisplay.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    txtDisplay.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    txtDisplay.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    txtDisplay.Text = resultado.ToString();
                    break;
            }
        }

        private void botoncoma_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ",";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmsecundario = new Form2();
            frmsecundario.Show();
        }

        private void botonraiz_Click(object sender, EventArgs e)
        {
            raiz = double.Parse(txtDisplay.Text);
            raiz = Math.Sqrt(raiz);
            txtDisplay.Text = raiz.ToString();
        }

        private void boton1x_Click(object sender, EventArgs e)
        {
            potencia = double.Parse(txtDisplay.Text);
            potencia = Math.Pow(potencia, 2);
            txtDisplay.Text = potencia.ToString();
        }

        private void botonPI_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3,1415926535897932384626433832795";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                CopiarTexto = txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = "No se puede copiar un valor menor a cero";
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = CopiarTexto;
        }

        private void botonmasmenos_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "-";
        }

        private void botonX3_Click(object sender, EventArgs e)
        {
            potencia = double.Parse(txtDisplay.Text);
            potencia = Math.Pow(potencia, 3);
            txtDisplay.Text = potencia.ToString();
        }

        private void botonMR_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                CopiarTexto = txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = "No se puede guardar en memoria ningun valor que sea menor a cero";
                if (CopiarTexto != null)
                {
                    txtDisplay.Text = CopiarTexto.ToString();
                }
            }
        }

        private void botonporcentaje_Click(object sender, EventArgs e)
        {
            numero2 = decimal.Parse(txtDisplay.Text);
            porcentaje = numero1 / 100 * numero2;
            txtDisplay.Text = porcentaje.ToString();
        }

        private void botonSeno_Click(object sender, EventArgs e)
        {
            seno = double.Parse(txtDisplay.Text);
            seno = Math.Sin(seno);
            txtDisplay.Text = seno.ToString();
        }

        private void botonCoseno_Click(object sender, EventArgs e)
        {
            coseno = double.Parse(txtDisplay.Text);
            coseno = Math.Cos(coseno);
            txtDisplay.Text = coseno.ToString();
        }

        private void botonTangente_Click(object sender, EventArgs e)
        {
            tangente = double.Parse(txtDisplay.Text);
            tangente = Math.Tan(tangente);
            txtDisplay.Text = tangente.ToString();
        }
    }
}