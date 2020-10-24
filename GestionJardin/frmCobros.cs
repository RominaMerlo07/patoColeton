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
    public partial class frmCobros : Form
    {
        logCobros ObjMetCobro = new logCobros();
        public frmCobros()
        {
            InitializeComponent();
        }
        
    
        private void cboCuotas_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (panlBtnAnular.Visible == false) { 

                if (cboCuotas.SelectedIndex == 0)
                {
                    logCobros ObjlogCobros = new logCobros();
                    ObjlogCobros.ExtraerImporte(cboCuotas.Text);

                    string importecuotaextraida = ObjlogCobros.ExtraerImporte(cboCuotas.Text);

                    txtImporte.Text = importecuotaextraida;
                    dtCobro.Value = DateTime.Today;
                    cboMediodepago.SelectedItem = cboMediodepago.SelectedIndex = 0;
                    dtCobro.Enabled = false;
                    txtImporte.Enabled = false;
                    cboMediodepago.Enabled = false;

                }

                else
                {
                    MessageBox.Show("Debe seleccionar la cuota pendiente con mayor fecha de vencmiento");
                }
            } else
            {
                logCobros ObjlogCobros = new logCobros();
                ObjlogCobros.ExtraerImporte(cboCuotas.Text);

                string importecuotaextraida = ObjlogCobros.ExtraerImporte(cboCuotas.Text);

                txtImporte.Text = importecuotaextraida;
                dtCobro.Value = DateTime.Today;
                cboMediodepago.SelectedItem = cboMediodepago.SelectedIndex = 0;
                dtCobro.Enabled = false;
                txtImporte.Enabled = false;
                cboMediodepago.Enabled = false;
            }
        }

        private void frmCobros_Load_1(object sender, EventArgs e)
        {
            panelBotones.Visible = false;
            panelBusqueda.Visible = false;
            panelCobro.Visible = false;
            panlBtnAnular.Visible = false;
            panelDatos.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
            panelBusqueda.Visible = true;
            panelBotones.Visible = true;
            panelCobro.Visible = true;
            panelDatos.Visible = true;
            panelBotones.Visible = false;
            txtBuscarCobroIngresar.Clear();
            txtDocumento.Clear();
            txtLegajo.Clear();
            txtNombreyApellido.Clear();
            panlBtnAnular.Visible = true;
            txtBuscarCobroIngresar.Visible = false;
            txtBuscarDatos.Visible = true;

            btnEditar.Visible = false;
            //---
            //ObjMetCobro.AutocompletarenCobros(txtBuscarDatos);
            DataTable dt = ObjMetCobro.AutocompletarenCobros(/*txtBuscarDatos*/);
            foreach (DataRow row in dt.Rows)
            {
                txtBuscarDatos.AutoCompleteCustomSource.Add(row["NOMBRE"].ToString());
            }
            //----

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            limpiar();
            panelBusqueda.Visible = true;
            panelBotones.Visible = true;
            panelCobro.Visible = true;
            panelDatos.Visible = true;
            txtBuscarCobroIngresar.Clear();
            txtDocumento.Clear();
            txtLegajo.Clear();
            txtNombreyApellido.Clear();
            panelBotones.Visible = true;
            panlBtnAnular.Visible = false;
            txtBuscarCobroIngresar.Visible = true;
            txtBuscarDatos.Visible = false;
            //---
            DataTable dt = ObjMetCobro.AutocompletarenCobros(/*txtBuscarCobroIngresar*/);
            foreach (DataRow row in dt.Rows)
            {
                txtBuscarCobroIngresar.AutoCompleteCustomSource.Add(row["NOMBRE"].ToString());
            }
            //----
        }
   
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //--
            logCobros ObjlogCobros = new logCobros();

            string fechaEncontrada = ObjlogCobros.ExtraerFechaVenc(cboCuotas.Text);
            string DniEncontrado = ObjlogCobros.ExtraerDni(txtBuscarCobroIngresar.Text);

            DataTable dt = ObjlogCobros.ModificarEstadoCuota(fechaEncontrada, txtLegajo.Text, DniEncontrado);

            cboCuotas.DataSource = dt;
            cboCuotas.DisplayMember = "INFO_CUOTA";
            cboCuotas.SelectedItem = null;
            //--

            string fechaEncontrada2 = ObjlogCobros.ExtraerFechaVenc(cboCuotas.Text);
            string cuoID = ObjlogCobros.ExtraercoutaId(fechaEncontrada2, txtLegajo.Text);
            string resultado = ObjlogCobros.InsertarenTCobros(cuoID);

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtBuscarCobroIngresar.Clear();
            txtDocumento.Clear();
            txtLegajo.Clear();
            txtNombreyApellido.Clear();
            txtImporte.Clear();
            cboCuotas.SelectedIndex = -1;
            dtCobro.Value = DateTime.Today;
            cboMediodepago.SelectedIndex = -1;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idCobro = Convert.ToInt32(cboCuotas.SelectedValue.ToString());

            logCobros ObjlogCobros = new logCobros();
            string resultado = ObjlogCobros.AnularCobro(idCobro);

            if (resultado == "OK") { 

                MessageBox.Show("La Cuota ha sido anulada con éxito.", "Cuota anulada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ObjlogCobros.ExtraerDni(txtBuscarDatos.Text);
                //----
                DataTable dt = ObjlogCobros.InsetarDatosCobrosenformBuscar(txtBuscarDatos.Text/*, txtNombreyApellido, txtDocumento, txtLegajo, cboCuotas, txtImporte, cboMediodepago*/);

                cboCuotas.DataSource = dt;
                cboCuotas.DisplayMember = "INFO_CUOTA";
                cboCuotas.ValueMember = "COB_ID";
                cboCuotas.SelectedItem = null;

                foreach (DataRow row in dt.Rows)
                {
                    txtBuscarCobroIngresar.AutoCompleteCustomSource.Add(row["NOMBRE"].ToString());
                    txtNombreyApellido.Text = row["NOMBRE_APELLIDO"].ToString();
                    txtDocumento.Text = row["PER_DOCUMENTO"].ToString();
                    txtLegajo.Text = row["PER_LEGAJO"].ToString();
                }
                //---
                ObjlogCobros.ExtraerImporte(cboCuotas.Text);

            }
        }

        private void txtBuscarCobroIngresar_ButtonClick(object sender, EventArgs e)
        {
            logCobros ObjlogCobros = new logCobros();
            ObjlogCobros.ExtraerDni(txtBuscarCobroIngresar.Text);

            //---
            DataTable dt = ObjlogCobros.InsertarDatosCobrosenformAgregar(txtBuscarCobroIngresar.Text/*, txtNombreyApellido, txtDocumento, txtLegajo, cboCuotas,*/ /*txtImporte, cboMediodepago*/);

            cboCuotas.DataSource = dt;
            cboCuotas.DisplayMember = "INFO_CUOTA";
            cboCuotas.SelectedItem = null;

            foreach (DataRow row in dt.Rows)
            {
                txtNombreyApellido.Text = row["NOMBRE_APELLIDO"].ToString();
                txtDocumento.Text = row["PER_DOCUMENTO"].ToString();
                txtLegajo.Text = row["PER_LEGAJO"].ToString();
            }
            //---
            ObjlogCobros.ExtraerImporte(cboCuotas.Text);
        }

        private void txtBuscarDatos_ButtonClick(object sender, EventArgs e)
        {
            logCobros ObjlogCobros = new logCobros();
            //if txtBuscarCobro is null no entra
            ObjlogCobros.ExtraerDni(txtBuscarDatos.Text);

            //ObjlogCobros.InsetarDatosCobrosenformBuscar(txtBuscarDatos, txtNombreyApellido, txtDocumento, txtLegajo, cboCuotas, txtImporte, cboMediodepago);
            //----
            DataTable dt = ObjlogCobros.InsetarDatosCobrosenformBuscar(txtBuscarDatos.Text/*, txtNombreyApellido, txtDocumento, txtLegajo, cboCuotas, txtImporte, cboMediodepago*/);

            cboCuotas.DataSource = dt;
            cboCuotas.DisplayMember = "INFO_CUOTA";
            cboCuotas.ValueMember = "COB_ID";
            cboCuotas.SelectedItem = null;

            foreach (DataRow row in dt.Rows)
            {
                txtBuscarCobroIngresar.AutoCompleteCustomSource.Add(row["NOMBRE"].ToString());
                txtNombreyApellido.Text = row["NOMBRE_APELLIDO"].ToString();
                txtDocumento.Text = row["PER_DOCUMENTO"].ToString();
                txtLegajo.Text = row["PER_LEGAJO"].ToString();
            }
            //---


            ObjlogCobros.ExtraerImporte(cboCuotas.Text);
            btnEditar.Visible = true;
        }
    }
}
