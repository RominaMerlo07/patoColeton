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
        metSalas MetSalas = new metSalas();
        string resultadoValidacion;


        public frmDocentesPopUpAgregar()
        {
            InitializeComponent();
        }

        /* Valiación GLOBAL */

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
                             

        /* Valiación INDIVIDUAL */

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
            string dni = txtDocumento.Text;
            metPersonas ObjMetPersonas = new metPersonas();
            string resultado = ObjMetPersonas.ValidarDni(dni);
            if (resultado == "SI")
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                MessageBox.Show("El docente ya se encuentra registrado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string email = txtEmail.Text;

            metPersonas objMetPersonas = new metPersonas();
            objMetPersonas.ValidarEmail(email);


            bool resultado = true;//= ObjMetPersonas.ValidarEmail(txtEmail.Text);

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {

            }
            else
            {
                resultado = objMetPersonas.ValidarEmail(email);
            }

            if (resultado == false)
            {
                MessageBox.Show("Ingrese un Email Válido");
                txtEmail.Clear();
                txtEmail.Focus();

            }
        }


        /* Metodos tipeo */

        private void Solonumeros(object sender, KeyPressEventArgs e)
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


        private void cbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            metPersonas Objmetpersonas = new metPersonas();
            Objmetpersonas.Llenar_Combo_Salas(cbTurno, cbSala);
        }


        /*********************************************************/
        /***************** GUARDAR NUEVO DOCENTE *****************/
        /*********************************************************/

        private void btnguardar_Click(object sender, EventArgs e)
        {
            metPersonas ObjMetOersonas = new metPersonas();
            objMetPersonas.EdadDocente(dtNacimiento.Value);

            string resultado;
               
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
                string estado = "S";

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
                personaInsert.PER_ESTADO = estado;

                metPersonas metPersona = new metPersonas();
                resultado = metPersona.Insertar(personaInsert);

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
                        string turno;


                        if (cbTurno.SelectedItem == null)
                        {
                            turno = "";
                        }
                        else
                        {
                            turno = cbTurno.SelectedItem.ToString();

                            if (turno == "MAÑANA")
                            {
                                turno = "MANANA";
                            }
                            else
                            {
                                turno = "TARDE";
                            }

                        }

                        string id_sala;
                        if (cbSala.SelectedItem == null)
                        {
                            id_sala = "";
                        }
                        else
                        {
                            id_sala = cbSala.SelectedValue.ToString();
                        }

                        if (turno == "" && id_sala =="")
                        {
                            MessageBox.Show("Se ha ingresado el registro con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else { //cambiar!!!
                            if (MetSalas.ValidarDocSala(id_sala, turno) == 0)
                            {
                                entGrupoSala grupoSalaInsertar = new entGrupoSala();
                                grupoSalaInsertar.GRS_PER_ID = Convert.ToInt32(id_persona);
                                grupoSalaInsertar.GRS_SAL_ID = Convert.ToInt32(id_sala);

                                resultado = MetSalas.insertarGrupoSala(grupoSalaInsertar);

                                if (resultado == "OK")
                                {
                                    MessageBox.Show("Se ha ingresado el registro con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ya existe un docente en la sala y turno seleccionados");

                                objMetPersonas.EliminarDocenteDomicilio(personaInsert);
                                objMetPersonas.EliminarDocentePersona(personaInsert);

                                MessageBox.Show("NO Se ha ingresado el registro.");
                            }
                        }

                    }
                }                
              
            }

            else
            {
                MessageBox.Show("No olvide ingresar " + validacion + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /***************** CANCELAR *****************/

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            string dni = txtDocumento.Text;
            metPersonas ObjMetPersonas = new metPersonas();
            string resultado = ObjMetPersonas.ValidarDni(dni);
            if (resultado == "SI")
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                MessageBox.Show("El docente ya se encuentra registrado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


