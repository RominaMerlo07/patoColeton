using System;
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
        }
        /*************LOAD **************/

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
          dgv_UsuariosActivos.ClearSelection();
          Settooltip();
          ObjetoUsu.AutocompletarenDocente(txtGU_Buscar);
          dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();
          btnGU_Editar.IconColor = Color.Gray;
          btnGU_Editar.ForeColor = Color.Gray;
          btnGU_Eliminar.IconColor = Color.Gray;
          btnGU_Eliminar.ForeColor = Color.Gray;            
        }
        

                /******  buscar datos Grilla ******/

        private void txtGU_Buscar_ButtonClick(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            dgv_UsuariosActivos.DataSource = ObjetoUsu.llenarGrilla(docente);
        }

        private void txtGU_Buscar_Enter(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            dgv_UsuariosActivos.DataSource = ObjetoUsu.llenarGrilla(docente);
        }

                     /******  Filtro Grilla ******/

        private void txtGU_Buscar_TextChanged(object sender, EventArgs e)
        {
            
            if (txtGU_Buscar.Text.Length > 0)
            {
                dgv_UsuariosActivos.DataSource = ObjetoUsu.llenarGrilla(txtGU_Buscar.Text);
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
            }
            else
            {
                txtGU_Buscar.Clear();
                dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
            }
        }
        /************* COLOCA LAS LETRAS EN MAYUSCULAS **************/

        private void txtGU_Buscar_Click(object sender, EventArgs e)
         {
           txtGU_Buscar.CharacterCasing = CharacterCasing.Upper;//esto me pone las letras en mayusculas siempre 
         }

        /************* Mensaje evento hover boton  **************/

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnGU_Eliminar, "SELECCIONE UN REGISTRO PARA PODER ELIMINAR");           
            Tip.SetToolTip(this.btnGU_Editar, "SELECCIONE UN REGISTRO PARA PODER EDITAR");
        }


        
        /************* Habilitacion de botones segun seleccion de registro en grilla  **************/
       

        private void dgv_UsuariosActivos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {
                btnGU_Editar.IconColor = Color.Cyan;
                btnGU_Editar.ForeColor = Color.Cyan;
                btnGU_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGU_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
                dgv_UsuariosActivos.ClearSelection();
            }
        }

        /***************************************/
        /*************** AGREGAR ***************/
        /***************************************/

        private void btnGU_Agregar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpAgregar frmUsuariosPopUpAgregar = new frmUsuariosPopUpAgregar();
            frmUsuariosPopUpAgregar.Text = "GESTION USUARIOS / GENERAR NUEVO USUARIO";
            AddOwnedForm(frmUsuariosPopUpAgregar);
            ObjetoUsu.AutocompletarAgregarDocente(frmUsuariosPopUpAgregar.txtSeleccionarDocente);
            frmUsuariosPopUpAgregar.ShowDialog();

            btnGU_Editar.IconColor = Color.Gray;
            btnGU_Editar.ForeColor = Color.Gray;
            btnGU_Eliminar.IconColor = Color.Gray;
            btnGU_Eliminar.ForeColor = Color.Gray;
        }

        /***************************************/
        /*************** EDITAR ***************/
        /***************************************/

        private void btnGU_Editar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEditar frmUsuariosPopUpEditar = new frmUsuariosPopUpEditar();
            frmUsuariosPopUpEditar.Text = "GESTION USUARIOS / MODIFICAR CONTRASEÑA";
            AddOwnedForm(frmUsuariosPopUpEditar);//lo declara como padre de for EU a frmUsuario
            frmUsuariosPopUpEditar.lblEditarUsu.Text = "'" + dgv_UsuariosActivos.CurrentRow.Cells[1].Value.ToString() + "'";

            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {

                btnGU_Editar.IconColor = Color.Cyan;
                btnGU_Editar.ForeColor = Color.Cyan;
                frmUsuariosPopUpEditar.ShowDialog();

                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
            }
            else
            {
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder modificar la contraseña");
               
            }

        }


        /****************************************/
        /*************** ELIMINAR ***************/
        /****************************************/

        private void btnGU_Eliminar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEliminar frmUsuariosPopUpEliminar = new frmUsuariosPopUpEliminar();
            frmUsuariosPopUpEliminar.Text = "GESTION USUARIOS / ELIMINAR USUARIO";
            AddOwnedForm(frmUsuariosPopUpEliminar);
            
            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {

                btnGU_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGU_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
                frmUsuariosPopUpEliminar.lblUSUARIOELIMINAR.Text = "'" + dgv_UsuariosActivos.CurrentRow.Cells[1].Value.ToString() + "'";
                frmUsuariosPopUpEliminar.ShowDialog();

                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;

            }
            else
            {

                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder ELIMINARLO");
                
            }
        }

        

       
    }
}
