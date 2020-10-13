//using CapaAccesoDatos;
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
        string id_sala;

        metAsistencia metAsistencia = new metAsistencia();

        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            txtGAs_Buscar.Visible = false;
            dgv_Alumnos.Visible = false;

            labelFechError.Visible = false;
            lblTurno.Visible = false;
            lblSala.Visible = false;
            lblFecha.Visible = false;
            lblAsistencia.Visible = false;
            cboAsistencia.Visible = false;
            lblJustificado.Visible = false;
            cboJustificado.Visible = false;

            btnguardar.Visible = false;
            btncancelar.Visible = false;
            dgv_Alumnos.ClearSelection();
            cbTurno.Focus();
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
            id_sala = cbSala.SelectedValue.ToString(); //.ToString();            
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


        private string ValidaCampos()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                result = "Por favor seleccione un turno";
                lblTurno.Text = result;
            }
            else if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                result = "Por favor seleccione una sala";
                lblSala.Text = result;
            }
            else
            {
                result = "OK";
            }

            return result;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string validacion = ValidaCampos();

            fechaCalendar = monthCalendar1.SelectionStart.Date;
            fechaCalendar.ToShortDateString();
            lblFecha.Text = fechaCalendar.ToString();
            lblFecha.Visible = true;

            if (lblFecha.Text.Length > 0)
            {
                if (validacion == "OK")
                {
                    dgv_Alumnos.Visible = true;
                    txtGAs_Buscar.Visible = true;
                    lblAsistencia.Visible = true;
                    cboAsistencia.Visible = true;
                    lblJustificado.Visible = true;
                    cboJustificado.Visible = true;
                    btnguardar.Visible = true;
                    btncancelar.Visible = true;
                    dgv_Alumnos.ClearSelection();

                    labelFechError.Visible = false;


                    string turno = cbTurno.SelectedItem.ToString();

                    if (turno == "MAÑANA")
                    {
                        turno = "MANANA";
                    }
                    else
                    {
                        turno = "TARDE";
                    }

                    dgv_Alumnos.DataSource = metAsistencia.GrillaAsistencia(turno, id_sala, lblFecha.Text);

                    dgv_Alumnos.Columns["PER_ID"].Visible = false;

                }
            }

            //  MessageBox.Show("Por favor verifique los datos ingresados: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void cboAsistencia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboAsistencia.Text.Trim()) == true)
            {
                cboAsistencia.Style = MetroFramework.MetroColorStyle.Red;
                cboAsistencia.Focus();
                lbl_ErrorAsistencia.Visible = true;
                lbl_ErrorAsistencia.Text = "Seleccione un valor para asistencia";

            }
            else
            {
                lbl_ErrorAsistencia.Visible = false;
                if(cboAsistencia.SelectedItem.ToString() == "PRESENTE")
                {
                    cboJustificado.Enabled = false;
                    lblJustificado.ForeColor = Color.Gray;
                }
                else
                {
                    cboJustificado.Enabled = true;
                    lblJustificado.ForeColor = Color.Aqua;
                }

            }
        }

        private void cboJustificado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboJustificado.Text.Trim()) == true)
            {
                cboJustificado.Style = MetroFramework.MetroColorStyle.Red;
                cboJustificado.Focus();
                lblErrorJustificado.Visible = true;
                lblErrorJustificado.Text = "Seleccione un valor para justificado";

            }
            else
            {
                lblErrorJustificado.Visible = false;
            }
        }

        private string validaCamposGuardar()
        { 
            string resultado = "OK";

            if (string.IsNullOrWhiteSpace(cboAsistencia.Text.Trim()) == true)
            {
                cboAsistencia.Style = MetroFramework.MetroColorStyle.Red;
                cboAsistencia.Focus();
                lbl_ErrorAsistencia.Visible = true;
                resultado = "Seleccione un valor para asistencia";
                lbl_ErrorAsistencia.Text = resultado;

            }
            else if (string.IsNullOrWhiteSpace(cboAsistencia.Text.Trim()) == false)
            {
                if (cboAsistencia.SelectedItem.ToString() == "PRESENTE")
                {
                    lbl_ErrorAsistencia.Visible = false;
                    cboJustificado.Enabled = false;
                    lblJustificado.ForeColor = Color.Gray;
                }
                else
                {
                    cboJustificado.Enabled = true;
                    lblJustificado.ForeColor = Color.Aqua;
                }
            }
            else if (string.IsNullOrWhiteSpace(cboJustificado.Text.Trim()) == true)
            {
                cboJustificado.Style = MetroFramework.MetroColorStyle.Red;
                cboJustificado.Focus();
                lblErrorJustificado.Visible = true;
                resultado = "Seleccione un valor para justificado";
                lblErrorJustificado.Text = resultado;
            }
            else
            {
                resultado = "OK";
            }

            return resultado;

        }

        private void cboAsistencia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboAsistencia.SelectedItem.ToString() == "PRESENTE")
            {
                lbl_ErrorAsistencia.Visible = false;
                cboJustificado.Enabled = false;
                lblJustificado.ForeColor = Color.Gray;
            }
            else
            {
                cboJustificado.Enabled = true;
                lblJustificado.ForeColor = Color.Aqua;
            }
        }
    }
}
