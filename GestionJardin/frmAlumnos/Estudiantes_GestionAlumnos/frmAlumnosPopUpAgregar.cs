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
    public partial class frmAlumnosPopUpAgregar : Form
    {

        frmAlumnos alumnos = new frmAlumnos();

        // Variables
        int idHmno;

        public frmAlumnosPopUpAgregar()
        {
            InitializeComponent();
        }

        private void frmAlumnosPopUpAgregar_Load(object sender, EventArgs e)
        {
            cbHrmDomicilio.Enabled = false;
            txtBuscaHmno.Enabled = false;


            //Autocompletar BuscarHermanos

            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            metPersonas metPersonas = new metPersonas();
            alumnos = metPersonas.traerPersonasAutocompetar("2");

            txtBuscaHmno.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscaHmno.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscaHmno.AutoCompleteCustomSource = alumnos;          

        }

        private string validaCampos()
        {
            string resultadoValidacion = "";


            if (string.IsNullOrWhiteSpace(txtDocumento.Text.Trim()) == true)
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
            else if ((string.IsNullOrWhiteSpace(txtVacantes.Text.Trim()) == true) || (Convert.ToInt32(txtVacantes.Text) <= 0 ))
            {

                txtVacantes.Style = MetroFramework.MetroColorStyle.Red;
                txtVacantes.Focus();
                resultadoValidacion = "la Sala";

            }
            else
            {
                resultadoValidacion = "OK";
            }

            return resultadoValidacion;

        }

        private void limpiarCampos()
        {
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


            //cbSala.SelectedItem = null;
            //cbTurno.SelectedItem = null;

            cbHrmDomicilio.Enabled = false;
            txtBuscaHmno.Enabled = false;
            //txtLegajo.Text = "--";
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

                string id_sala;
                if (cbSala.SelectedItem == null)
                {
                    id_sala = "";
                }
                else
                {
                    id_sala = cbSala.SelectedValue.ToString();
                }

                //-- Termina de preparar todos los datos

                //--- Secuenciador de Legajo
                metParametricas metParametricas = new metParametricas();
                string legajo = metParametricas.secuenciadorLegajoAlumnos(); // lo genera solo
                //--------

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
                personaInsert.PER_LEGAJO = legajo;
                personaInsert.PER_ESTADO = "1";

                // INSERTA PERSONA
                metPersonas metPersona = new metPersonas();
                string resultado = metPersona.Insertar(personaInsert);
                // -----

                if (resultado == "OK")
                { // entra solo si inserto la persona correctamente

                    personaInsert = metPersona.BuscaPersona(nombre, apellidos, documento); // TRAE EL ID RECIEN INSERTADO
                    Int32 id_persona = personaInsert.PER_ID;

                    // INSERTA GRUPO FAMILIAR
                    string valor = cbHrmDomicilio.SelectedItem.ToString();
                    if (valor.StartsWith("SI"))
                    {
                        metGrupoFlia objGrpFlia = new metGrupoFlia();
                        string resulta3 = objGrpFlia.insertaEnGrupoFlia(Convert.ToInt32(id_persona), Convert.ToString(idHmno)); // antes se pasaba el legajo como segundo parametro, ahora pasamos el id_persona del hermano
                    }
                    else
                    {
                        metGrupoFlia objGrpFlia = new metGrupoFlia();
                        string resulta3 = objGrpFlia.insertaEnGrupoFlia(Convert.ToInt32(id_persona), Convert.ToString(id_persona));
                    }
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

                    metDomicilio metDomicilio = new metDomicilio();
                    resultado = metDomicilio.Insertar(domicilioInsertar);
                    // -----

                    //INSERTA GRUPO SALA 
                    
                    entGrupoSala grupoSalaInsertar = new entGrupoSala();

                    grupoSalaInsertar.GRS_PER_ID = Convert.ToInt32(id_persona);
                    grupoSalaInsertar.GRS_SAL_ID = Convert.ToInt32(id_sala);

                    metSalas metSalas = new metSalas();
                    resultado = metSalas.insertarGrupoSala(grupoSalaInsertar);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            this.Close();
        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();
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
            string id_sala;

            id_sala = cbSala.SelectedValue.ToString(); //.ToString();
            metSalas objMetSalas = new metSalas();
            DataTable gruposSalas = new DataTable();
            gruposSalas = objMetSalas.traerSalasCupo();
            DataRow[] rows = gruposSalas.Select("SAL_ID = " + id_sala);
            int CANTIDAD = Convert.ToInt16(rows[0]["CANTIDAD"].ToString());
            int MAXIMO = Convert.ToInt16(rows[0]["MAXIMO"].ToString());
            int VACANTES = MAXIMO - CANTIDAD;

            txtVacantes.Text = VACANTES.ToString();
        }

        private void cbHermanos_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = cbHermanos.SelectedItem.ToString();
            if (valor.StartsWith("SI"))
            {
                cbHrmDomicilio.Enabled = true;
                cbHrmDomicilio.SelectedValueChanged += new EventHandler(cbHrmDomicilio_SelectedValueChanged);
            }
            else
            {
                cbHrmDomicilio.Enabled = false;
                cbHrmDomicilio.SelectedValueChanged -= new EventHandler(cbHrmDomicilio_SelectedValueChanged);
                cbHrmDomicilio.SelectedValue = null;
                
            }
        }

        private void cbHrmDomicilio_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = cbHrmDomicilio.SelectedItem.ToString();
            if (valor.StartsWith("SI"))
            {
                txtBuscaHmno.Enabled = true;
            }
            else
            {
                txtBuscaHmno.Enabled = false;
                txtBuscaHmno.Text = null;
            }
        }

        private void txtBuscaHmno_ButtonClick(object sender, EventArgs e)
        {
            string nombreB = "";
            string apellidoB = "";
            string documentoB = "";
            int contador = 0;

            string busqueda = txtBuscaHmno.Text;

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
            metPersonas objMetPersonas = new metPersonas();
            metDomicilio objmetDomicilio = new metDomicilio();
            personaBuscar = objMetPersonas.BuscaPersona(nombreB, apellidoB, documentoB);
            entDomicilio domicilioBuscar = new entDomicilio();
            domicilioBuscar = objmetDomicilio.buscarDomicilioXPersona(personaBuscar.PER_ID);

            if (personaBuscar.PER_NOMBRE != null)
            {
                idHmno = personaBuscar.PER_ID; // se usara en el agregarGrupoFlia


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

        //-- EVENTOS QUE VALIDAN DATOS INGRESADOS

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

        private bool validarEmail()
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
            return resultado;
        }
    }
}
