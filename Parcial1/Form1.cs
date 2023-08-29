using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        String[][] TiposSuperficie = new string[][] {
       new string[] {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzanas", "Hectareas",}, //Areas
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = CboDeArea.SelectedIndex;
            a = CboAarea.SelectedIndex;

            cantidad = double.Parse(TxtCantidadArea.Text);

            double[][] superficie = {
            new double []{0.09290304, 0.698896, 0.836127, 1, 437.5, 7000, 10.000,},
            };
            respuesta = superficie[CboTipoArea.SelectedIndex][de] / superficie[CboTipoArea.SelectedIndex][a] * cantidad;
        
            LblRespuestaArea.Text = "Respuesta: " + Math.Round(respuesta,3);
        }

        private void CboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            CboDeArea.Items.Clear();
            CboDeArea.Items.AddRange(TiposSuperficie[CboTipoArea.SelectedIndex]);

            CboAarea.Items.Clear();
            CboAarea.Items.AddRange(TiposSuperficie[CboTipoArea.SelectedIndex]);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CboTipoArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboDeArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
