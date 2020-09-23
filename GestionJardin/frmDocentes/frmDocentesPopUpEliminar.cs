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
    
    public partial class frmDocentesPopUpEliminar : Form
    {

        metPersonas objetopersona = new metPersonas();
        entPersona Docentes = new entPersona();
        int documento;
        int idPersonaBuscar;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        public frmDocentesPopUpEliminar()
        {
            InitializeComponent();
        }

        private void frmDocentesPopUpEliminar_Load(object sender, EventArgs e)
        {

        }

        private void frmDocentesPopUpEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_sieliminar_Click(object sender, EventArgs e)
        {
            frmDocentes Fdocentes= Owner as frmDocentes;
            
            
            
            if (lbldnidoc.Text== " ")
            {
                }
            else
            {
                
                idPersonaBuscar = Convert.ToInt32(txt_id_Docente.Text);
                entPersona personaEditar = new entPersona();
                personaEditar.PER_ID = idPersonaBuscar;

                //entPersona doc = new entPersona();
                //doc.PER_DOCUMENTO = Convert.ToInt32(documentoE);
                
                var usumetodo = new metUsuario();
                string resultadoE = objetopersona.EliminarDocente(personaEditar);
                MessageBox.Show("SE DIO DE BAJA CORRECTAMENTE" + lblnombredocente.Text);
                Fdocentes.dgv_Docentes.DataSource = objetopersona.Mostrardocente();
                this.Hide();
            }

        }

        private void btn_noeliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
