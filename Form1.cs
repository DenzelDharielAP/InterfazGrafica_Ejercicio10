using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto, montoneto, itbis;
            double descuento = 0;

            monto = Convert.ToDouble(txtMontoTotal.Text);

            itbis = (monto * 0.18);
            Math.Round(monto, 3);
            

            if (monto <= 5000)
            {
                txtDescuento.Text = "No aplica para descuento.";
            }

            else if (monto >= 5001 && monto <= 10000)
            {
                descuento = (monto * 0.03);
                txtDescuento.Text = descuento.ToString();
            }

            else if (monto >= 10001 && monto <= 15000)
            {
                descuento = (monto * 0.05);
                txtDescuento.Text = descuento.ToString();
            }

            else if (monto >= 15001 && monto <= 20000)
            {
                descuento = (monto * 0.08);
                txtDescuento.Text = descuento.ToString();
            }

            else if (monto >= 20001)
            {
                descuento = (monto * 0.10);
                txtDescuento.Text = descuento.ToString();
            }


            Math.Round(descuento, 3);
            montoneto = (monto - descuento) + itbis;
            txtMontoNeto.Text = montoneto.ToString();
            txtITBIS.Text = itbis.ToString();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMontoTotal.Clear();
            txtDescuento.ResetText();
            txtITBIS.Clear();
            txtMontoNeto.Clear();
        }
    }
}
