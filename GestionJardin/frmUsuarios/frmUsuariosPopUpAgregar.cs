using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestionJardin
{
    public partial class frmUsuariosPopUpAgregar : Form
    {
        metUsuario ObjetoUsu = new metUsuario();
        entUsuario Usuario = new entUsuario();

        public frmUsuariosPopUpAgregar()
        {
            InitializeComponent();

        }
        
        private void frmUsuariosPopUpAgregar_Load_1(object sender, EventArgs e)
        {
            /***Coloco el foco en textbox principal***/
            txtSeleccionarDocente.Focus();
            /***habilito solo para leer el textbox***/
            txt_nombre_usuario.ReadOnly = true;
            txt_contra_usu.ReadOnly = true;
            /***coloco en gris el textbox***/
            txt_contra_usu.BackColor = Color.DarkGray;
            txt_nombre_usuario.BackColor = Color.DarkGray;
            txt_contra_usu.ForeColor = MetroFramework.MetroColors.Silver;
            txt_contra_usu.WaterMarkColor = MetroFramework.MetroColors.Silver;
            
        }
/************* seleccion de Docente y habilitacion de ingreso de contraseña  **************/

        private void txtSeleccionarDocente_ButtonClick(object sender, EventArgs e)
        {
            if (txtSeleccionarDocente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un docente primero! ");
                txtSeleccionarDocente.Focus();
            }
            else
            {
                ObjetoUsu.CrearUsuario(txtSeleccionarDocente, txt_nombre_usuario);
                /***me habilita para poder escribir***/
                txt_contra_usu.ReadOnly = false;
                /***me devuelve  los colores originales del textbox***/
                txt_contra_usu.BackColor = Color.FromArgb(34, 33, 74);
                txt_nombre_usuario.BackColor = Color.FromArgb(34, 33, 74);
                txt_contra_usu.WaterMarkColor = Color.Lime;
                txt_contra_usu.ForeColor = Color.Lime;
                txt_contra_usu.Focus();
            }
                }
        
                /***************************************/
                /*************** AGREGAR ***************/
                /***************************************/

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;//esto me indica q es el padre frmUsuarios y me deja usar sus metodos

            if (txtSeleccionarDocente.Text== "")
            {
                MessageBox.Show("Seleccione un docente! ");
                txt_contra_usu.Focus();
            }
           if(txt_contra_usu.Text== "")
            {
                MessageBox.Show("Debe ingresar una contraseña! ");
                txt_contra_usu.Focus();
            }
            else
            {
                ObjetoUsu.Ingresar_Usuario(txtSeleccionarDocente, txt_nombre_usuario, txt_contra_usu);
                MessageBox.Show(" Registro de Usuario Exitoso ");
                U.dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();
                this.Close();
            }
            
        }
        /***************************************/
        /*************** CANCELAR ***************/
        /***************************************/
        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_contra_usu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            { e.Handled = false; }

            else if (char.IsSeparator(e.KeyChar))//no dejaq escriba espacios
            {
                e.Handled = true;
                MessageBox.Show("No puede ingresar espacios! ");
            }
            else if (char.IsControl(e.KeyChar))//permite q pueda borrar 
            {
               // e.Handled = false;
                txt_nombre_usuario.Clear();
                
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtSeleccionarDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))//permite q pueda borrar 
            {
                // e.Handled = false;
                txt_nombre_usuario.Clear();

            }
        }
    }
}
