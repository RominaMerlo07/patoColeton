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
using System.Data.SqlClient;

namespace GestionJardin
{
    public partial class frmAlumnosGrupoFliaPopUpAgregar : Form
    {

        int idAlumno;

        public frmAlumnosGrupoFliaPopUpAgregar()
        {
            InitializeComponent();
            metroPanel3.Focus();
        }

        private void frmAlumnosGrupoFliaPopUpAgregar_Load(object sender, EventArgs e)
        {
            //Autocompletar BuscarHermanos

            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            logPersonas logPersonas = new logPersonas();
            //--
            DataTable dt = logPersonas.traerPersonasAutocompetar("2");


            foreach (DataRow row in dt.Rows)
            {
                txtBuscaAlumno.AutoCompleteCustomSource.Add(row[0].ToString()); 
            }
            //SqlDataReader dr = logPersonas.traerPersonasAutocompetar("2");
            //while (dr.Read())
            //{
            //    alumnos.Add(dr.GetString(0));
            //};


            txtBuscaAlumno.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscaAlumno.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtBuscaAlumno.AutoCompleteCustomSource = alumnos;

            //--
        }

        private string validaCampos()
        {
            string resultadoValidacion = "";

            //txtParentesco
            if (string.IsNullOrWhiteSpace(txtParentesco.Text.Trim()) == true)
            {
                txtParentesco.Style = MetroFramework.MetroColorStyle.Red;
                txtParentesco.Focus();
                resultadoValidacion = "el Parentesco";

            }
            else if (string.IsNullOrWhiteSpace(txtDocumento.Text.Trim()) == true)
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                resultadoValidacion = "el Documento";

            }
            else if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()) == true)
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
            else if (string.IsNullOrWhiteSpace(txtCalle.Text.Trim()) == true)
            {
                txtCalle.Style = MetroFramework.MetroColorStyle.Red;
                txtCalle.Focus();
                resultadoValidacion = "la Calle del domicilio";

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
            else if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()) == true)
            {
                txtCelular.Style = MetroFramework.MetroColorStyle.Red;
                txtCelular.Focus();
                resultadoValidacion = "un Celular de contacto";

            }
            else if ((string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == true) || (validarEmail() == false))
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

        private void limpiarCampos()
        {
            txtParentesco.Text = "";
            txtParentesco.Style = MetroFramework.MetroColorStyle.Default;
            txtNombre.Text = "";
            txtNombre.Style = MetroFramework.MetroColorStyle.Default;
            txtApellidos.Text = "";
            txtApellidos.Style = MetroFramework.MetroColorStyle.Default;
            txtDocumento.Text = "";
            txtDocumento.Style = MetroFramework.MetroColorStyle.Default;

            dtNacimiento.Value = dtNacimiento.MaxDate;
            cbGenero.SelectedItem = null;


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

        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private bool validarEmail()
        {
            logPersonas ObjlogPersonas = new logPersonas();
            bool resultado = true;

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {

            }
            else
            {
                resultado = ObjlogPersonas.ValidarEmail(txtEmail.Text);
            }
            return resultado;
        }

        private void txtBuscaAlumno_ButtonClick(object sender, EventArgs e)
        {
            string nombreB = "";
            string apellidoB = "";
            string documentoB = "";
            int contador = 0;

            string busqueda = txtBuscaAlumno.Text;

            char[] separadores = { ',', '(', ')' };
            string[] palabras = busqueda.Split(separadores);

            foreach (var palabra in palabras)
            {
                contador += 1;
                if (contador == 1)
                {
                    nombreB = palabra.Trim();
                }
                else if (contador == 2)
                {
                    apellidoB = palabra.Trim();
                }
                else if (contador == 3)
                {
                    documentoB = palabra.Trim();
                }
            }

            entPersona personaBuscar = new entPersona();
            logPersonas objlogPersonas = new logPersonas();
            logDomicilio objlogDomicilio = new logDomicilio();
            personaBuscar = objlogPersonas.BuscaPersona(nombreB, apellidoB, documentoB);
            entDomicilio domicilioBuscar = new entDomicilio();
            domicilioBuscar = objlogDomicilio.buscarDomicilioXPersona(personaBuscar.PER_ID);

            if (personaBuscar.PER_NOMBRE != null)
            {
                idAlumno = personaBuscar.PER_ID; // se usara en el agregarGrupoFlia


                txtCalle.Text = domicilioBuscar.DOM_CALLE;
                txtNumero.Text = Convert.ToString(domicilioBuscar.DOM_NUMERO);
                txtCPostal.Text = Convert.ToString(domicilioBuscar.DOM_CP);
                txtPiso.Text = Convert.ToString(domicilioBuscar.DOM_PISO);
                txtDepto.Text = domicilioBuscar.DOM_DPTO;
                txtBarrio.Text = domicilioBuscar.DOM_BARRIO;
                txtTelefono.Text = personaBuscar.PER_TELEFONO;
                txtCelular.Text = personaBuscar.PER_TELEFONO_2;
                txtEmail.Text = personaBuscar.PER_EMAIL;

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string validacion = validaCampos();

            if (validacion == "OK")
            {

                // Preparo la info de todos los campos

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


                //-- Termina de preparar todos los datos

                entPersona personaInsert = new entPersona();

                personaInsert.PER_NOMBRE = nombre;
                personaInsert.PER_APELLIDO = apellidos;
                personaInsert.PER_DOCUMENTO = Convert.ToInt32(documento);
                personaInsert.PER_GENERO = genero; //revisar
                personaInsert.PER_FECHA_NAC = nacimiento;
                personaInsert.PER_TELEFONO = telefono;
                personaInsert.PER_TELEFONO_2 = celular;
                personaInsert.PER_EMAIL = email;
                personaInsert.PER_TPE_ID = "2";
                personaInsert.PER_LEGAJO = null;
                personaInsert.PER_ESTADO = "S";

                // INSERTA PERSONA
                logPersonas metPersona = new logPersonas();
                string resultado = metPersona.Insertar(personaInsert);
                // -----

                if (resultado == "OK")
                { // entra solo si inserto la persona correctamente

                    personaInsert = metPersona.BuscaPersona(nombre, apellidos, documento); // TRAE EL ID RECIEN INSERTADO
                    Int32 id_persona = personaInsert.PER_ID;

                    // INSERTA GRUPO FAMILIAR
                    
                    logGrupoFlia objGrpFlia = new logGrupoFlia();
                    entGrupoFlia grpFlia = new entGrupoFlia();
                
                    grpFlia.GRF_PER_ID = id_persona;
                    grpFlia.GRF_PER_LEGAJO = Convert.ToString(idAlumno);

                    string autorizado;
                    if (checkAutorizacion.Checked)
                    {
                        autorizado = "S";
                    } else
                    {
                        autorizado = "N";
                    }
                    grpFlia.GRF_AUTORIZADO = autorizado; // N or S

                    string tutor;
                    if (checkTutor.Checked)
                    {
                        tutor = "S";
                    }
                    else
                    {
                        tutor = "N";
                    }
                    grpFlia.GRF_TUTOR = tutor; // N or S
                    grpFlia.GRF_OBSERVACION = txtParentesco.Text;

                    string resulta3 = objGrpFlia.insertaEnGrupoFlia2(grpFlia); // antes se pasaba el legajo como segundo parametro, ahora pasamos el id_persona del alumno
                    
                    // -----

                    //INSERTA DOMICILIO
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

                    logDomicilio logDomicilio = new logDomicilio();
                    resultado = logDomicilio.Insertar(domicilioInsertar);
                    // -----

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Se ha ingresado el registro con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        //limpiarCampos();

                    }
                }
            }
            else
            {
                MessageBox.Show("No olvide ingresar " + validacion + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtParentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtBuscaAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtCPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            logPersonas objlogPersonas = new logPersonas();
            objlogPersonas.ValidarEmail(email);


            bool resultado = true;//= ObjlogPersonas.ValidarEmail(txtEmail.Text);

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {

            }
            else
            {
                resultado = objlogPersonas.ValidarEmail(email);
            }

            if (resultado == false)
            {
                MessageBox.Show("Ingrese un Email Válido");
                txtEmail.Clear();
                txtEmail.Focus();

            }
        }
    }
}
