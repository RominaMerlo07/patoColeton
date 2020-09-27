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

        public frmAlumnosPopUpAgregar()
        {
            InitializeComponent();
        }

        private string validaCampos()
        {
            string resultadoValidacion = "";


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
            else if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()) == true)
            {
                txtCelular.Style = MetroFramework.MetroColorStyle.Red;
                txtCelular.Focus();
                resultadoValidacion = "un Celular de contacto";

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


            cbSala.SelectedItem = null; ;
            cbTurno.SelectedItem = null; ;
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
            // Función que valide todos los campos

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

                //cbTurno.SelectedItem; no se agrega en ninguna tabla

                string id_sala;
                if (cbSala.SelectedItem == null)
                {
                    id_sala = "";
                }
                else
                {
                    id_sala = cbSala.SelectedValue.ToString();
                }

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
                //personaInsert.PER_TPE_ID = cbTipoPersona2.SelectedValue.ToString();
                personaInsert.PER_LEGAJO = legajo;
                personaInsert.PER_ESTADO = "1";


                metPersonas metPersona = new metPersonas();
                string resultado = metPersona.Insertar(personaInsert); // INSERTA PERSONA
                //nombre = "RAMON";
                //apellidos = "LOPEZ";
                //documento = "25654987";

                if (resultado == "OK")
                { // entra a insertar el domicilio de la persona solo si inserto la persona correctamente

                    personaInsert = metPersona.BuscaPersona(nombre, apellidos, documento); // TRAE EL ID RECIEN INSERTADO
                    Int32 id_persona = personaInsert.PER_ID;

                    // popUp del familiar
                    //if ((cbTipoPersona2.SelectedValue.ToString() != "1") && (cbTipoPersona2.SelectedValue.ToString() != "2"))
                    //{
                    //    frmPopUpFlia frmFlia = new frmPopUpFlia();
                    //    frmFlia.ShowDialog();

                    //    string LegajoAsociado = frmFlia.Legajo; // familiar al que se asocia al ingresado

                    //    metGrupoFlia objGrpFlia = new metGrupoFlia();

                    //    string resulta3 = objGrpFlia.insertaEnGrupoFlia(Convert.ToInt32(id_persona), LegajoAsociado);
                    //}
                    //else if (cbTipoPersona2.SelectedValue.ToString() == "2")
                    //{
                    //    metGrupoFlia objGrpFlia = new metGrupoFlia();
                    //    string resulta3 = objGrpFlia.insertaEnGrupoFlia(Convert.ToInt32(id_persona), legajo);

                    //}
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

                    //INSERTA GRUPO SALA SOLO SI ES DOCENTE O ALUMNO
                    //if ((cbTipoPersona2.SelectedValue.ToString() == "2") || (cbTipoPersona2.SelectedValue.ToString() == "1"))
                    //{
                    //    entGrupoSala grupoSalaInsertar = new entGrupoSala();

                    //    grupoSalaInsertar.GRS_PER_ID = Convert.ToInt32(id_persona);
                    //    grupoSalaInsertar.GRS_SAL_ID = Convert.ToInt32(id_sala);

                    //    metSalas metSalas = new metSalas();
                    //    resultado = metSalas.insertarGrupoSala(grupoSalaInsertar);


                    //}

                    //al terminar de insertar Borra todos los campos
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
            DataRow[] rows = gruposSalas.Select("GRS_SAL_ID = " + id_sala);
            int CANTIDAD = Convert.ToInt16(rows[0]["CANTIDAD"].ToString());
            int MAXIMO = Convert.ToInt16(rows[0]["MAXIMO"].ToString());
            int VACANTES = MAXIMO - CANTIDAD;

            txtVacantes.Text = VACANTES.ToString();
        }
    }
}
