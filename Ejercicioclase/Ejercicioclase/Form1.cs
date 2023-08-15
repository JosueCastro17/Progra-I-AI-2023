using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicioclase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convertirconvensores_Click(object sender, EventArgs e)
        {

        }

        private void lbla_conversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = Cbo_Conversores.SelectedIndex;
            a = cbo_aconversores.SelectedIndex;

            cantidad = double.Parse(txt_cantidad.Text);
            //Dolar, Euro, Quetzales, Lempiras, Colon SV, Cordoba, Colo CR, Yen, Libras esterlinas, Rupia india

            double[] monedas = { 1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29 };
            respuesta = monedas[a] / monedas[de] * cantidad;

            lbl_respuesta.Text = "Respuesta" + Math.Round(respuesta, 3);


        }


        }
    }

