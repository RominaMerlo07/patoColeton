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
    public partial class frmUsuariosPopUpEditar : Form
    {
        metUsuario ObjetoUsu = new metUsuario();
        entUsuario Usuario = new entUsuario();
        public frmUsuariosPopUpEditar()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void btn_GuardarUsuMod_Click(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;//esto me indica q es el padre frmUsuarios y me deja usar sus metodos
            DialogResult resp = MessageBox.Show("¿Confirma la Modificación?", "Modificar", MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            var usu = new entUsuario();
            if ((resp == DialogResult.Yes))
            {
                usu.USU_USUARIO = lblEditarUsu.Text;
                usu.USU_CLAVE = metroTextBoxContrasenaEdit.Text;
                var usumetodo = new metUsuario();
                usumetodo.EditarUsuario(usu);
                MessageBox.Show("Se actualizo Correctamente! ");
                this.Close();
                U.CargarGrilla();
            }
            else
            {
                MessageBox.Show("Ocurrio un problema, contacte con su servidor!");
            }
        }

        private void btn_CancelarUsuMod_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Seguro desea salir?", "salir", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            if ((resp == DialogResult.Yes))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Escriba una contraseña");
            }
        }

        private void frmUsuariosPopUpEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void metroTextBoxContrasenaEdit_KeyPress(object sender, KeyPressEventArgs e)
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
