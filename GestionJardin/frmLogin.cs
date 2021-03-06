﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaLog;
using CaEnt;

namespace GestionJardin
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = lblAcceso;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logUsuario ingresaUsuario = new logUsuario();

            bool ingreso = ingresaUsuario.ingresar(txtUsuario.Text, txtContrasena.Text);

            if (ingreso == true)
            {

                lblAccesoDenegado.Visible = false;

                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
                this.Hide();

                txtUsuario.Text = "";
                txtContrasena.Text = "";


            } else
            {
                lblAccesoDenegado.Visible = true;
            }
        }

        // Eventos

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.Text = "";
            txtContrasena.isPassword = true;
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text) == true)
            {
                txtContrasena.Text = "";
                txtContrasena.isPassword = false;
            } 

        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                btnIngresar_Click(sender, e);
            }
        }
    }
}
