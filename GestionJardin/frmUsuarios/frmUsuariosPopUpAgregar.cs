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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        public frmUsuariosPopUpAgregar()
        {
            InitializeComponent();
            lblNvoUsu.Visible = false;

        }

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;//esto me indica q es el padre frmUsuarios y me deja usar sus metodos

            ObjetoUsu.Ingresar_Usuario(txtSeleccionarDocente, txt_nombre_usuario, txt_contra_usu);
            MessageBox.Show(" Registro de Usuario Exitoso ");
            U.dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();
            this.Close();
            
        }

        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuariosPopUpAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtSeleccionarDocente_ButtonClick(object sender, EventArgs e)
        {
            ObjetoUsu.CrearUsuario(txtSeleccionarDocente, txt_nombre_usuario);
          
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
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y numeros!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
