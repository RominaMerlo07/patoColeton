using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaEnt;
using CaLog;

namespace GestionJardin
{
    public partial class frmInformeProgreso_AgregarMateria : Form
    {

        string id_sala;

        logAsistencia logAsistencia = new logAsistencia(); // ver si es necesario generar uno nuevo por informe??

        public frmInformeProgreso_AgregarMateria()
        {
            InitializeComponent();
        }

        private void frmInformeProgreso_AgregarMateria_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            //cbTurno.SelectedIndex = -1;
            cbTurno.Focus();
            cbSala.SelectedIndex = -1;            
            lbl_panelInforme.Visible = true;
            lblTurno.Visible = false;
            lblSala.Visible = false;
            txtGA_Buscar.Visible = false;
            dgvAsignatura.Visible = false;
            lblInfoAsignatura.Visible = false;
            btn_Agregar.Visible = false;
            btn_Editar.Visible = false;
            btn_Eliminar.Visible = false;            
        }

        private void cargar_cbSala()
        {

            cbSala.SelectedValueChanged -= new EventHandler(cbSala_SelectedValueChanged);


            string indexTurno = cbTurno.SelectedIndex.ToString();
            logSalas objlogSalas = new logSalas();
            DataTable Tabla = new DataTable();
            Tabla = objlogSalas.ListarSalas(indexTurno);

            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
            cbSala.DataSource = Tabla;
            cbSala.SelectedItem = null;
            cbSala.Enabled = true;

            cbSala.SelectedValueChanged += new EventHandler(cbSala_SelectedValueChanged);

        }

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            id_sala = cbSala.SelectedValue.ToString(); //.ToString(); 

            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == false)
            { 

                lbl_panelInforme.Visible = false;             
                txtGA_Buscar.Visible = true;
                dgvAsignatura.Visible = true;
                lblInfoAsignatura.Visible = true;
                btn_Agregar.Visible = true;
                btn_Editar.Visible = true;
                btn_Eliminar.Visible = true;

                lblSala.Visible = false;

            }

        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();
        }

        private void cbTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                lblTurno.BringToFront();
                lblTurno.Text = "Por favor seleccione un turno";
            }
            else
            {
                lblTurno.Visible = false;
            }
        }

        private void cbSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor seleccione una sala";
            }
            else
            {
                lblSala.Visible = false;
            }
        }

       
    }
}
