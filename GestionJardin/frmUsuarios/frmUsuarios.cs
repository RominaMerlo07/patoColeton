﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    public partial class frmUsuarios : Form
    {
        metUsuario ObjetoUsu = new metUsuario();
        public frmUsuarios()
        {
            InitializeComponent();
            Settooltip();
            ObjetoUsu.AutocompletarenDocente(txtGU_Buscar);
            CargarGrilla();
        }
        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnGU_Eliminar, "SELECCIONE UN REGISTRO PARA PODER ELIMINAR");
            Tip.SetToolTip(this.btnGU_Agregar, "AGREGAR USUARIO");
            Tip.SetToolTip(this.btnGU_Editar, "SELECCIONE UN REGISTRO PARA PODER EDITAR");
        }

        private void btnGU_Agregar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpAgregar frmUsuariosPopUpAgregar = new frmUsuariosPopUpAgregar();
            frmUsuariosPopUpAgregar.Text = "GESTION USUARIOS / GENERAR NUEVO USUARIO";
            AddOwnedForm(frmUsuariosPopUpAgregar);
            ObjetoUsu.AutocompletarAgregarDocente(frmUsuariosPopUpAgregar.txtSeleccionarDocente);
            frmUsuariosPopUpAgregar.ShowDialog();

        }

        private void btnGU_Editar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEditar frmUsuariosPopUpEditar = new frmUsuariosPopUpEditar();
            frmUsuariosPopUpEditar.Text = "GESTION USUARIOS / MODIFICAR CONTRASEÑA";
            AddOwnedForm(frmUsuariosPopUpEditar);//lo declara como padre de for EU a frmUsuario
            frmUsuariosPopUpEditar.lblEditarUsu.Text = "'" + dgv_UsuariosActivos.CurrentRow.Cells[1].Value.ToString() + "'";

            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {

                frmUsuariosPopUpEditar.ShowDialog();
            }
            else
            {

                MessageBox.Show("Por favor seleccione un registro/fila para poder modificar la contraseña");
                /*Agregar notificacion con icono de alerta amarillo (Romi)*/
            }

        }

        private void btnGU_Eliminar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEliminar frmUsuariosPopUpEliminar = new frmUsuariosPopUpEliminar();
            frmUsuariosPopUpEliminar.Text = "GESTION USUARIOS / ELIMINAR USUARIO";
            AddOwnedForm(frmUsuariosPopUpEliminar);
            
            if (dgv_UsuariosActivos.SelectedRows.Count >= 1)
            {
                frmUsuariosPopUpEliminar.lblUSUARIOELIMINAR.Text = "'" + dgv_UsuariosActivos.CurrentRow.Cells[1].Value.ToString() + "'";
                frmUsuariosPopUpEliminar.ShowDialog();
                /*Agregar efecto parpadeante al icono de alerta (Romi)*/
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro/fila para poder ELIMINARLO");
                /*Agregar notificacion con icono de alerta amarillo (Romi)*/
            }
        }
        public void CargarGrilla()
        {
            dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();

        }

        private void txtGU_Buscar_ButtonClick(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            dgv_UsuariosActivos.DataSource = ObjetoUsu.llenarGrilla(docente);
        }

        private void txtGU_Buscar_Enter(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            ObjetoUsu.llenarGrilla(docente);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgv_UsuariosActivos.ClearSelection();
            //btnGU_Editar.Enabled = false;
            //btnGU_Eliminar.Enabled = false;
        }

        private void dgv_UsuariosActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {
               /* MessageBox.Show("entre!");
                btnGU_Editar.Enabled = true;
                btnGU_Eliminar.Enabled = true;*/

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor!");
            }
        }
    }
}
