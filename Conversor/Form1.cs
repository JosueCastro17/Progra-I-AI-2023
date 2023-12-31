﻿using System;
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
        String[][] TiposConversores =  new string [][] {
       new string[] {"Dolar", "Euro", "Quetzales", "Lempiras", "Colón Salvadoreño", "Cordoba", "Pesos Costarricenses", "Yen Japones", "Libras esterlina", "Rupia India" }, //monedas 
       new String[] {"Tonelada", "Kilogramo", "Gramo", "Miligramo", "Microgramo", "Tonelada larga", "Tonelada corta", "Stone", "Libra", "Onza"}, //Masa
       new string [] {"Metro Cubico", "Galón", "Cuarto", "Taza americana", "Onza Liquida", "Litro", "Mililitro", "Pulgada Cubica", "Pie Cubico"}, //Volumen
       new string [] {"Kilometro", "Metro", "Centimetro", "Milímetro", "Micrometro", "Nanometro", "Milla", "Yarda", "Pie", "Pulgada"} , //Longitud
       new string [] {"Bits", "Bytes", "Kilobytes", "Megabytes", "Gigabytes", "Terabytes", "Petabytes", "Exabytes", "Zettabytes", "Yottabytes"}, //Almacenamiento
       new string [] {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Mes", "Año" }, //Tiempo 
        };

     
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = CboDeConversor.SelectedIndex;
            a = CboAConversores.SelectedIndex;

            cantidad = double.Parse(TxtCantidadConversores.Text);

            double[][] monedas = {
            new double []{1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29},
            new double [] {1, 1000, 1000000, 1000000000.00, 00, 0.984207,  1.10231, 157.473, 2204.62, 35274},
            new double [] {1, 264.172, 1056.69, 4166.67, 33814, 1000, 1000000, 61023.7, 35.3147},
            new double [] {1, 1000, 100000, 1000000, 0, 0, 0.621371, 1093.61, 3280.84, 39370.1},
            new double [] {1, 0.125, 0.000125, 0, 0, 0, 0, 0, 0, 0},
            new double [] {1, 0.001, 0.000001, 0.000000001, 0.00000000001666667, 0.00000000000027778, 0.00000000000001157407, 0.00000000000000165344, 0.00000000000000038056, 0.0000000000000000317098 } //tiempo
            };
            respuesta = monedas[CboTipoConversor.SelectedIndex][a] / monedas[CboTipoConversor.SelectedIndex][de] * cantidad;
        
            LblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta,2);
        }

        private void CboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            CboDeConversor.Items.Clear();
            CboDeConversor.Items.AddRange(TiposConversores[CboTipoConversor.SelectedIndex]);

            CboAConversores.Items.Clear();
            CboAConversores.Items.AddRange(TiposConversores[CboTipoConversor.SelectedIndex]);
           
        }
    }
}
