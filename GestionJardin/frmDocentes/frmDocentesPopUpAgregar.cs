using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace GestionJardin
{
    public partial class frmDocentesPopUpAgregar : Form
    {

        metPersonas objMetPersonas = new metPersonas();
        entPersona objPersona = new entPersona();
        metDomicilio objmetDomicilio = new metDomicilio();
        string resultadoValidacion;
        int idPersonaBuscar;
        int EdadAnos;
               

        public frmDocentesPopUpAgregar()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            metPersonas ObjMetOersonas = new metPersonas();
            objMetPersonas.EdadDocente(dtNacimiento.Value);


            string validacion = validaCampos();

            if (validacion == "OK")
            {
                string nombre = txtNombre.Text.Trim();
                string apellidos = txtApellidos.Text.Trim();
                string documento = txtDocumento.Text.Trim();
                DateTime nacimiento = dtNacimiento.Value.Date;
                string genero;

                if (cbGenero.SelectedItem == null)
                {
                    genero = "";
                }
                else
                {
                    genero = cbGenero.SelectedItem.ToString();
                }

                string calle = txtCalle.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string cpostal = txtCPostal.Text.Trim();
                string piso = txtPiso.Text.Trim();
                string dpto = txtDepto.Text.Trim();
                string barrio = txtBarrio.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string email = txtEmail.Text.Trim();

                entPersona personaInsert = new entPersona();

                personaInsert.PER_DOCUMENTO = Convert.ToInt32(documento);
                personaInsert.PER_NOMBRE = nombre;
                personaInsert.PER_APELLIDO = apellidos;
                personaInsert.PER_GENERO = genero;
                personaInsert.PER_FECHA_NAC = nacimiento;
                personaInsert.PER_TELEFONO = telefono;
                personaInsert.PER_TELEFONO_2 = celular;
                personaInsert.PER_EMAIL = email;
                personaInsert.PER_TPE_ID = "1";

                metPersonas metPersona = new metPersonas();
                string resultado = metPersona.Insertar(personaInsert);

                if (resultado == "OK")
                {
                    personaInsert = metPersona.BuscaPersona(nombre, apellidos, documento);
                    Int32 id_persona = personaInsert.PER_ID;

                    entDomicilio domicilioInsertar = new entDomicilio();

                    domicilioInsertar.DOM_PER_ID = id_persona;
                    domicilioInsertar.DOM_CALLE = calle;
                    domicilioInsertar.DOM_NUMERO = Convert.ToInt32(numero);
                    if (string.IsNullOrWhiteSpace(piso.Trim()) == true)
                    {
                    }
                    else
                    {
                        domicilioInsertar.DOM_PISO = Convert.ToInt32(piso);
                    }

                    domicilioInsertar.DOM_DPTO = dpto;
                    domicilioInsertar.DOM_BARRIO = barrio;
                    domicilioInsertar.DOM_CP = Convert.ToInt32(cpostal);

                    metDomicilio metDomicilio = new metDomicilio();
                    resultado = metDomicilio.Insertar(domicilioInsertar);



                    if (resultado == "OK")
                    {
                        MessageBox.Show("Se ha ingresado el registro con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        limpiarCampos();
                    }
                }
            }

            else
            {
                MessageBox.Show("No olvide ingresar " + validacion + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpiarCampos()
        {

            txtNombre.Text = "";
            txtNombre.Style = MetroFramework.MetroColorStyle.Default;
            txtApellidos.Text = "";
            txtApellidos.Style = MetroFramework.MetroColorStyle.Default;
            txtDocumento.Text = "";
            txtDocumento.Style = MetroFramework.MetroColorStyle.Default;
            cbGenero.SelectedItem = null;
            dtNacimiento.Value = DateTime.Today;
            txtCalle.Text = "";
            txtCalle.Style = MetroFramework.MetroColorStyle.Default;
            txtNumero.Text = "";
            txtNumero.Style = MetroFramework.MetroColorStyle.Default;
            txtCPostal.Text = "";
            txtCPostal.Style = MetroFramework.MetroColorStyle.Default;
            txtPiso.Text = "";
            txtPiso.Style = MetroFramework.MetroColorStyle.Default;
            txtDepto.Text = "";
            txtDepto.Style = MetroFramework.MetroColorStyle.Default;
            txtBarrio.Text = "";
            txtBarrio.Style = MetroFramework.MetroColorStyle.Default;
            txtTelefono.Text = "";
            txtTelefono.Style = MetroFramework.MetroColorStyle.Default;
            txtCelular.Text = "";
            txtCelular.Style = MetroFramework.MetroColorStyle.Default;
            txtEmail.Text = "";
            txtEmail.Style = MetroFramework.MetroColorStyle.Default;
            AutoCompleteStringCollection traerdocente = new AutoCompleteStringCollection();
            metPersonas metPersonas = new metPersonas();
            //traerdocente = metPersonas.traerdocente();

            // txtBuscarDocente.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtBuscarDocente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtBuscarDocente.AutoCompleteCustomSource = traerdocente;
        }
        private string validaCampos()
        {
            metPersonas ObjMetOersonas = new metPersonas();
            objMetPersonas.EdadDocente(dtNacimiento.Value);

            resultadoValidacion = "";

            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()) == true)
            {
                txtNombre.Style = MetroFramework.MetroColorStyle.Red;
                txtNombre.Focus();
                resultadoValidacion = "el Nombre";
            }
            else if (string.IsNullOrWhiteSpace(txtApellidos.Text.Trim()) == true)
            {
                txtApellidos.Style = MetroFramework.MetroColorStyle.Red;
                txtApellidos.Focus();
                resultadoValidacion = "el Apellido";
            }
            else if (string.IsNullOrWhiteSpace(txtDocumento.Text.Trim()) == true)
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                resultadoValidacion = "el Documento";
            }
           
            else if (string.IsNullOrWhiteSpace(txtCalle.Text.Trim()) == true)
            {
                txtCalle.Style = MetroFramework.MetroColorStyle.Red;
                txtCalle.Focus();
                resultadoValidacion = "la Calle del domicilio";
            }
            else if (string.IsNullOrWhiteSpace(txtNumero.Text.Trim()) == true)
            {
                txtNumero.Style = MetroFramework.MetroColorStyle.Red;
                txtNumero.Focus();
                resultadoValidacion = "el Numero del domicilio";
            }
            else if (string.IsNullOrWhiteSpace(txtCPostal.Text.Trim()) == true)
            {
                txtCPostal.Style = MetroFramework.MetroColorStyle.Red;
                txtCPostal.Focus();
                resultadoValidacion = "el Código Postal";
            }
            else if (string.IsNullOrWhiteSpace(txtBarrio.Text.Trim()) == true)
            {
                txtBarrio.Style = MetroFramework.MetroColorStyle.Red;
                txtBarrio.Focus();
                resultadoValidacion = "el Barrio";
            }
            else if (string.IsNullOrWhiteSpace(txtTelefono.Text.Trim()) == true)
            {
                txtTelefono.Style = MetroFramework.MetroColorStyle.Red;
                txtTelefono.Focus();
                resultadoValidacion = "un telefono de emergencia";
            }
            else if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()) == true)
            {
                txtCelular.Style = MetroFramework.MetroColorStyle.Red;
                txtCelular.Focus();
                resultadoValidacion = "un celular de contacto";
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == true)
            {
                txtEmail.Style = MetroFramework.MetroColorStyle.Red;
                txtEmail.Focus();
                resultadoValidacion = "el E-mail";
            }
            else
            {
                resultadoValidacion = "OK";
            }
            return resultadoValidacion;
        }

        private void Solonumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }

        private void txtCPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);

        }

        private void dtNacimiento_Leave(object sender, EventArgs e)
        {
            metPersonas ObjMetOersonas = new metPersonas();
            objMetPersonas.EdadDocente(dtNacimiento.Value);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            metPersonas ObjMetPersonas = new metPersonas();
            bool resultado = true;

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {

            }
            else
            {
                resultado = ObjMetPersonas.ValidarEmail(txtEmail.Text);
            }

            if (resultado == false)
            {
                MessageBox.Show("Ingrese un Email Válido");
                txtEmail.Clear();
                txtEmail.Focus();

            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


