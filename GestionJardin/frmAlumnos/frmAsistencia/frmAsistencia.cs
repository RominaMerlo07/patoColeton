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
    public partial class frmAsistencia : Form
    {
        DateTime fechaCalendar;

        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            txtGAs_Buscar.Visible = false;
            dgv_Alumnos.Visible = false;
            btnAsistencia.Visible = false;
            btnInasistencia.Visible = false;
        }

        private void cargar_cbSala()
        {

            cbSala.SelectedValueChanged -= new EventHandler(cbSala_SelectedValueChanged);


            string indexTurno = cbTurno.SelectedIndex.ToString();
            metSalas objMetSalas = new metSalas();
            DataTable Tabla = new DataTable();
            Tabla = objMetSalas.ListarSalas(indexTurno);

            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
            cbSala.DataSource = Tabla;
            cbSala.SelectedItem = null;
            cbSala.Enabled = true;

            cbSala.SelectedValueChanged += new EventHandler(cbSala_SelectedValueChanged);

        }

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaCalendar = monthCalendar1.SelectionStart.Date;
            fechaCalendar.ToShortDateString();                         
            label1.Text = fechaCalendar.ToString();
        }
    }
}
