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

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;//esto me indica q es el padre frmUsuarios y me deja usar sus metodos
            DialogResult resp = MessageBox.Show("¿Confirma la Modificación?", "Modificar", MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            var usu = new entUsuario();
            if ((resp == DialogResult.Yes))
            {
                usu.USU_USUARIO = lblUSUARIOELIMINAR.Text;
                // usu.USU_FECHA_MOD = metroDateTimeBaja.Value;
                // usu.USU_FECHA_BAJA = metroDateTimeBaja.Value;

                var usumetodo = new metUsuario();
                usumetodo.EliminarUsuario(usu);
                MessageBox.Show("Se actualizo Elimino! ");
                U.CargarGrilla();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrio un problema, contacte con su servidor!");
            }
        }

        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
