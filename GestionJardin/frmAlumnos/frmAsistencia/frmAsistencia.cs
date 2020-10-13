using CapaAccesoDatos;
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
            btnAsistencia.Visible = false;
            btnInasistencia.Visible = false;
            labelFechError.Visible = false;
            lblTurno.Visible = false;
            lblSala.Visible = false;
            lblFecha.Visible = false;
            lblJustificado.Visible = false;
            lblAsistencia.Visible = false;
            btn_Injustificado.Visible = false;
            btn_Justificado.Visible = false;
            metroComboBox1.Visible = false; /*****************************************/
            metroComboBox2.Visible = false; /*****************************************/
            btnguardar.Visible = false; /*****************************************/
            btncancelar.Visible = false; /*****************************************/
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
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
                    btnAsistencia.Visible = false; /*****************************************/
                    btnInasistencia.Visible = false; /*****************************************/
                    btn_Injustificado.Visible = false;
                    btnguardar.Visible = true; /*****************************************/
                    btncancelar.Visible = true; /*****************************************/
                    lblJustificado.Visible = true; /*****************************************/
                    btn_Justificado.Visible = false;
                    labelFechError.Visible = false;
                    lblAsistencia.Visible = true;
                    metroComboBox1.Visible = true; /*****************************************/
                    metroComboBox2.Visible = true; /*****************************************/
                    dgv_Alumnos.ClearSelection();

                    
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

                    if (dgv_Alumnos.SelectedRows.Count > 0)
                    {
                        //btnAsistencia.IconColor = Color.Lime;
                        //btnAsistencia.ForeColor = Color.Lime;
                        //btnInasistencia.IconColor = Color.FromArgb(255, 128, 128);
                        //btnInasistencia.ForeColor = Color.FromArgb(255, 128, 128);                                              
                        btn_Justificado.IconColor = Color.Gray;
                        btn_Justificado.ForeColor = Color.Gray;
                        btn_Injustificado.IconColor = Color.Gray;
                        btn_Injustificado.ForeColor = Color.Gray;



                    }
                    else
                    {
                        dgv_Alumnos.ClearSelection();
                        //btnAsistencia.IconColor = Color.Gray;
                        //btnAsistencia.ForeColor = Color.Gray;
                        //btnInasistencia.IconColor = Color.Gray;
                        //btnInasistencia.ForeColor = Color.Gray;                   
                        btn_Justificado.IconColor = Color.Gray;
                        btn_Justificado.ForeColor = Color.Gray;
                        btn_Injustificado.IconColor = Color.Gray;
                        btn_Injustificado.ForeColor = Color.Gray;


                    }

                    
                    


                }
            }           

            //  MessageBox.Show("Por favor verifique los datos ingresados: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void btnInasistencia_Click(object sender, EventArgs e)
        {
            //lblJustificado.Visible = false; /*****************************************/
            //metroComboBox1.Visible = true; /*****************************************/
            //btn_Justificado.IconColor = Color.FromArgb(128, 255, 128);
            //btn_Justificado.ForeColor = Color.FromArgb(128, 255, 128);
            //btn_Injustificado.IconColor = Color.Silver;
            //btn_Injustificado.ForeColor = Color.Silver;

        }

        private void dgv_Alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Alumnos.SelectedRows.Count > 0)
            {
                btnAsistencia.IconColor = Color.Lime;
                btnAsistencia.ForeColor = Color.Lime;
                btnInasistencia.IconColor = Color.FromArgb(255, 128, 128);
                btnInasistencia.ForeColor = Color.FromArgb(255, 128, 128);

            }
            else
            {
                dgv_Alumnos.ClearSelection();
                //btnAsistencia.IconColor = Color.Gray;
                //btnAsistencia.ForeColor = Color.Gray;
                //btnInasistencia.IconColor = Color.Gray;
                //btnInasistencia.ForeColor = Color.Gray;
                btn_Justificado.IconColor = Color.Gray;/*Color.FromArgb(128, 255, 128);*/
                btn_Justificado.ForeColor = Color.Gray;/*Color.FromArgb(128, 255, 128);*/
                btn_Injustificado.IconColor = Color.Gray;/*Color.Silver;*/
                btn_Injustificado.ForeColor = Color.Gray;/*Color.Silver;*/
            }
        }
    }
}
