﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaEnt;
using CaLog;

namespace GestionJardin
{
    public partial class frmInformeProgreso_AgregarMateria : Form
    {
              
        public frmInformeProgreso_AgregarMateria()
        {
            InitializeComponent();
        }

        private void frmInformeProgreso_AgregarMateria_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            //cbTurno.SelectedIndex = -1;
         
            cbSala.SelectedIndex = -1;            
            lbl_panelInforme.Visible = true;         
            lblSala.Visible = false;
            txtGA_Buscar.Visible = false;
            dgvAsignatura.Visible = false;
            lblInfoAsignatura.Visible = false;
            btn_Agregar.Visible = false;
            btn_Editar.Visible = false;
            btn_Eliminar.Visible = false;            
        }               
        

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == false)
            { 

                lbl_panelInforme.Visible = false;             
                txtGA_Buscar.Visible = true;
                dgvAsignatura.Visible = true;
                lblInfoAsignatura.Visible = true;
                btn_Agregar.Visible = true;
                btn_Editar.Visible = true;
                btn_Eliminar.Visible = true;

                lblSala.Visible = false;

            }

        }
       
       
        private void cbSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor seleccione una sala";
            }
            else
            {
                lblSala.Visible = false;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmInformeProgreso_GestAsig_Agregar frmInformeProgreso_GestAsig_Agregar = new frmInformeProgreso_GestAsig_Agregar();
            frmInformeProgreso_GestAsig_Agregar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / AGREGAR ";
            frmInformeProgreso_GestAsig_Agregar.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            frmInformeProgreso_GestAsig_Editar frmInformeProgreso_GestAsig_Editar = new frmInformeProgreso_GestAsig_Editar();
            frmInformeProgreso_GestAsig_Editar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / MODIFICAR ";
            frmInformeProgreso_GestAsig_Editar.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            frmInformeProgreso_GestAsig_Eliminar frmInformeProgreso_GestAsig_Eliminar = new frmInformeProgreso_GestAsig_Eliminar();
            frmInformeProgreso_GestAsig_Eliminar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / ELIMINAR ";
            frmInformeProgreso_GestAsig_Eliminar.ShowDialog();
        }
    }
}
