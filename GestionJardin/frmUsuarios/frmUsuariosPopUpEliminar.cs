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
    public partial class frmUsuariosPopUpEliminar : Form
    {
        metUsuario ObjetoUsu = new metUsuario();
        entUsuario Usuario = new entUsuario();
        public frmUsuariosPopUpEliminar()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

                /************* LOAD **************/

        private void frmUsuariosPopUpEliminar_Load(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;
            if (U.dgv_UsuariosActivos.CurrentRow.Cells[5].Value.ToString() == "INACTIVO")
            {
                this.Close();
                MessageBox.Show("NO SE PUEDE ELIMINAR USUARIO INACTIVO!");

            }
        }
            /************* permite mover el form  **************/

        private void frmUsuariosPopUpEliminar_MouseDown(object sender, MouseEventArgs e)
           {
              ReleaseCapture();
              SendMessage(this.Handle, 0x112, 0xf012, 0);
                               }

                      /***************************************/
                      /*************** AGREGAR ***************/
                      /***************************************/

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;//esto me indica q es el padre frmUsuarios y me deja usar sus metodos
           
            var usu = new entUsuario();
            if (lblUSUARIOELIMINAR.Text== " ")
            {
               
            }
            else
            {
                usu.USU_USUARIO = lblUSUARIOELIMINAR.Text;
                var usumetodo = new metUsuario();
                usumetodo.EliminarUsuario(usu);
                MessageBox.Show("SE DIO DE BAJA CORRECTAMENTE" + lblUSUARIOELIMINAR.Text);
                U.dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();

                this.Hide();
            }
        }
        /***************************************/
        /*************** CANCELAR ***************/
        /***************************************/
        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
                 {
                  this.Close();
                  }
    }
}
