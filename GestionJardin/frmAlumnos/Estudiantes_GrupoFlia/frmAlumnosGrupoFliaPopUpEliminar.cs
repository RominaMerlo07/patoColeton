using System;
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
    public partial class frmAlumnosGrupoFliaPopUpEliminar : Form
    {
        string idEliminar;

        public frmAlumnosGrupoFliaPopUpEliminar(string idEliminar, string alumno)
        {
            InitializeComponent();

            label2.Text = alumno + "?";
            lblId.Text = idEliminar;
        }

        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            idEliminar = lblId.Text;
            entPersona eliminaPersona = new entPersona();
            logPersonas metPersona = new logPersonas();
            eliminaPersona.PER_ID = Convert.ToInt32(idEliminar);
            string resultado = metPersona.EliminarDocente(eliminaPersona);
            if (resultado == "OK")
            {
                this.Close();
            }
        }
    }
}
