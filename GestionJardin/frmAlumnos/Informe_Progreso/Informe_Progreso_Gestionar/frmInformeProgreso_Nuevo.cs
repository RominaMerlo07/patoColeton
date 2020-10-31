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
    public partial class frmInformeProgreso_Nuevo : Form
    {
        public frmInformeProgreso_Nuevo()
        {
            InitializeComponent();
        }

        private void frmInformeProgreso_Nuevo_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void cbAsignatura_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbAsignatura.Text.Trim()) == false)
            {
                lblEstado.Visible = true;
                panelDescripcion.Visible = true;
                lblDescripcion.Text = "DESCRIPCIÓN DEL APRENDIZAJE"; /*ESTO SE DEBE MODIFICAR POR LO QUE HOY TENGA EL JARDIN*/
                                                                     /*ROMI, va consultar a mi madrina dicha info o se la pediremos a Cristian Farias*/
                txtObservacion.Visible = true;
                btnguardar.Visible = true;
                btncancelar.Visible = true;
                btnBloqueo.Visible = true;
            }
           
        }

        private void Inicializar()
        {
            lblEstado.Visible = false;
            panelDescripcion.Visible = false;
            txtObservacion.Visible = false;
            btnguardar.Visible = false;
            btncancelar.Visible = false;
            btnBloqueo.Visible = false;
        }

        
    }
}
