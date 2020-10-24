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
    public partial class frmAlumnosPopUpEliminar : Form
    {
        string idEliminar;
        //string alumno;

        public frmAlumnosPopUpEliminar(string idEliminar, string alumno)
        {
            InitializeComponent();
            //idEliminar = idEliminar;
            //alumno = alumno;

            label2.Text = alumno + "?";
            lblidPersona.Text = idEliminar;
        }

        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            idEliminar = lblidPersona.Text;
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
