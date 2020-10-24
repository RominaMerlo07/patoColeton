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
    public partial class frmAlumnosGrupoFliaPopUpEditar : Form
    {
        string idPersonaSelect;
        Int32 idGrpFlia;
        entPersona persona = new entPersona();
        entDomicilio domicilio = new entDomicilio();
        entGrupoFlia grFlia = new entGrupoFlia();
        logPersonas metPers = new logPersonas();
        logDomicilio metDomic = new logDomicilio();
        logGrupoFlia metGrf = new logGrupoFlia();

        public frmAlumnosGrupoFliaPopUpEditar(string idPersonaSelect2)
        {
            InitializeComponent();

            idPersonaSelect = idPersonaSelect2;
            persona = metPers.BuscaPersonaxID(idPersonaSelect);
            domicilio = metDomic.buscarDomicilioXPersona(Convert.ToInt32(idPersonaSelect));
            grFlia = metGrf.traerGrpFlia(Convert.ToInt32(idPersonaSelect));

            cargarCampos(persona, domicilio, grFlia);
            onOffCampos(false);
        }

        private void cargarCampos(entPersona persona, entDomicilio domicilio, entGrupoFlia grFlia)
        {
            idPersonaSelect = Convert.ToString(persona.PER_ID); // se usara en el editar
            idGrpFlia = grFlia.GRF_ID; // se usara en el editar

            txtNombre.Text = persona.PER_NOMBRE;
            txtApellidos.Text = persona.PER_APELLIDO;
            txtDocumento.Text = Convert.ToString(persona.PER_DOCUMENTO);

            dtNacimiento.Value = persona.PER_FECHA_NAC;


            if (persona.PER_GENERO.StartsWith("M"))
            {
                cbGenero.SelectedIndex = cbGenero.FindStringExact("MASCULINO");
            }
            else
            {
                cbGenero.SelectedIndex = cbGenero.FindStringExact("FEMENINO");
            }


            txtCalle.Text = domicilio.DOM_CALLE;
            txtNumero.Text = Convert.ToString(domicilio.DOM_NUMERO);
            txtCPostal.Text = Convert.ToString(domicilio.DOM_CP);
            txtPiso.Text = Convert.ToString(domicilio.DOM_PISO);
            txtDepto.Text = domicilio.DOM_DPTO;
            txtBarrio.Text = domicilio.DOM_BARRIO;
            txtTelefono.Text = persona.PER_TELEFONO;
            txtCelular.Text = persona.PER_TELEFONO_2;
            txtEmail.Text = persona.PER_EMAIL;

            txtParentesco.Text = grFlia.GRF_OBSERVACION;

            if (grFlia.GRF_TUTOR.Trim() == "S")
            {
                checkTutor.Checked = true;
            } else
            {
                checkTutor.Checked = false;
            }

            if (grFlia.GRF_AUTORIZADO.Trim() == "S")
            {
                checkAutorizado.Checked = true;
            } else
            {
                checkAutorizado.Checked = false;
            }
            

        }

        private void onOffCampos(bool onOff)
        {

            txtNombre.Enabled = onOff;
            txtApellidos.Enabled = onOff;
            txtDocumento.Enabled = onOff;

            dtNacimiento.Enabled = onOff;
            cbGenero.Enabled = onOff;

            txtCalle.Enabled = onOff;
            txtNumero.Enabled = onOff;
            txtCPostal.Enabled = onOff;
            txtPiso.Enabled = onOff;
            txtDepto.Enabled = onOff;
            txtBarrio.Enabled = onOff;
            txtTelefono.Enabled = onOff;
            txtCelular.Enabled = onOff;
            txtEmail.Enabled = onOff;

            txtParentesco.Enabled = onOff;
            checkTutor.Enabled = onOff;
            checkAutorizado.Enabled = onOff;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBloqueo_Click(object sender, EventArgs e)
        {
            if (this.btnBloqueo.IconChar == FontAwesome.Sharp.IconChar.Lock)
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                onOffCampos(true);
            }
            else
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Lock;
                onOffCampos(false);
            }
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

        private void txtParentesco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string validacionE = validaCampos();

            if (validacionE == "OK")
            {

                //-------- EDITA PERSONA

                string nombreE = txtNombre.Text.Trim();
                string apellidosE = txtApellidos.Text.Trim();
                string documentoE = txtDocumento.Text.Trim();
                DateTime nacimientoE = dtNacimiento.Value.Date;
                string generoE;
                if (cbGenero.SelectedItem == null)
                {
                    generoE = "";
                }
                else
                {
                    generoE = cbGenero.SelectedItem.ToString();
                }

                string calleE = txtCalle.Text.Trim();
                string numeroE = txtNumero.Text.Trim();
                string cpostalE = txtCPostal.Text.Trim();
                string pisoE = txtPiso.Text.Trim();
                string dptoE = txtDepto.Text.Trim();
                string barrioE = txtBarrio.Text.Trim();
                string telefonoE = txtTelefono.Text.Trim();
                string celularE = txtCelular.Text.Trim();
                string emailE = txtEmail.Text.Trim();


                entPersona personaEditar = new entPersona();

                personaEditar.PER_ID = Convert.ToInt32(idPersonaSelect);
                personaEditar.PER_NOMBRE = nombreE;
                personaEditar.PER_APELLIDO = apellidosE;
                personaEditar.PER_DOCUMENTO = Convert.ToInt32(documentoE);
                personaEditar.PER_GENERO = generoE; //revisar
                personaEditar.PER_FECHA_NAC = nacimientoE;
                personaEditar.PER_TELEFONO = telefonoE;
                personaEditar.PER_TELEFONO_2 = celularE;
                personaEditar.PER_EMAIL = emailE;

                string resultadoE = metPers.editarPersona(personaEditar);

                //-------- EDITA DOMICILIO
                entDomicilio domicilioEditar = new entDomicilio();

                domicilioEditar.DOM_PER_ID = Convert.ToInt32(idPersonaSelect);
                domicilioEditar.DOM_CALLE = calleE;
                domicilioEditar.DOM_NUMERO = Convert.ToInt32(numeroE);
                if (string.IsNullOrWhiteSpace(pisoE.Trim()) == true)
                {

                }
                else
                {
                    domicilioEditar.DOM_PISO = Convert.ToInt32(pisoE);
                }


                domicilioEditar.DOM_DPTO = dptoE;
                domicilioEditar.DOM_BARRIO = barrioE;
                domicilioEditar.DOM_CP = Convert.ToInt32(cpostalE);

                resultadoE = metDomic.editarDomicilio(domicilioEditar);

                //-------- EDITA GRUPO FLIA
                entGrupoFlia grpFliaEditar = new entGrupoFlia();

                grpFliaEditar.GRF_ID = idGrpFlia;

                string autorizado;
                if (checkAutorizado.Checked)
                {
                    autorizado = "S";
                }
                else
                {
                    autorizado = "N";
                }
                grpFliaEditar.GRF_AUTORIZADO = autorizado; // N or S

                string tutor;
                if (checkTutor.Checked)
                {
                    tutor = "S";
                }
                else
                {
                    tutor = "N";
                }
                grpFliaEditar.GRF_TUTOR = tutor; // N or S

                grpFliaEditar.GRF_OBSERVACION = txtParentesco.Text;

                resultadoE = metGrf.editaGrFlia(grpFliaEditar);


                if (resultadoE == "OK")
                {
                    MessageBox.Show("Se han editado los datos con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No olvide ingresar " + validacionE + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
