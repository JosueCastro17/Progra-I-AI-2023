﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace SistemaInventarioFerreteria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            List<Usuarios> TEST = new CN_Usuario().Listar();

            Usuarios ousuario = new CN_Usuario().Listar().Where(u => u.Usuario == txtUsuarioLogin.Text && u.Password == txtContrasenaLogin.Text).FirstOrDefault(); 

            if (ousuario != null)
            {
                Inicio form = new Inicio();
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
               
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuarioLogin.Text = "";
            txtContrasenaLogin.Text = "";
            this.Show();
           
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        }
    }

    



