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
    public partial class frmSalasPopUpAgregar : Form
    {
        metSala2 metSala = new metSala2();
        entSala entSala = new entSala();
        

        public frmSalasPopUpAgregar()
        {
            InitializeComponent();
            panelDatos.Focus();
        }

        /*Metodos*/
        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        public string Validacion()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(txtSala.Text.Trim()) == true)
            {
                txtSala.Style = MetroFramework.MetroColorStyle.Red;
                txtSala.Focus();
                result = " el nombre de la sala. Por ejemplo: 'AZUL'";

            }
            else if (string.IsNullOrWhiteSpace(cboTurno.Text.Trim()) == true)
            {
                cboTurno.Style = MetroFramework.MetroColorStyle.Red;
                cboTurno.Focus();
                result = " el turno";

            }
            else if (string.IsNullOrWhiteSpace(cboEdadMin.Text.Trim()) == true)
            {
                cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMin.Focus();
                result = " la edad mínima";

            }
            else if (string.IsNullOrWhiteSpace(cboEdadMax.Text.Trim()) == true)
            {
                cboEdadMax.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMax.Focus();
                result = " la edad máxima";

            }
            else if (string.IsNullOrWhiteSpace(txtCantMax.Text.Trim()) == true)
            {
                txtCantMax.Style = MetroFramework.MetroColorStyle.Red;
                txtCantMax.Focus();
                result = " la cantidad máxima de alumnos";
            }
            else
            {
                result = "OK";
            }

            return result;
        }


        private void txtSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtCantMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        /*******************/
        /** BOTON GUARDAR **/
        /*******************/

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            string validacion = Validacion();
            if (validacion == "OK")
            {

                entSala.SAL_NOMBRE = txtSala.Text;
                   
            string turno;
            int control;
            string edadMin;
            string edadMax;
            int cantMax = 0;

            

            if (cboTurno.SelectedItem == null)
            {
                turno = "";
                control = 1;
            }
            else 
            {
                turno = cboTurno.SelectedItem.ToString();

                if (turno == "MAÑANA")
                {
                    entSala.SALA_TURNO = "MANANA";
                    control = 0;
                }
                else
                {
                    entSala.SALA_TURNO = "TARDE";
                    control = 0;
                }
            }

            string result = metSala.ValidarSala(entSala.SAL_NOMBRE, entSala.SALA_TURNO);            

            if (result == "SI")
            {
                MessageBox.Show("El nombre de la sala ingresado: " + entSala.SAL_NOMBRE + " ya se encuentra registrado en el turno " + turno);
                control = 1;
            }
            else
            {
                control = 0;
                if (cboEdadMin.SelectedItem == null)
                {
                    edadMin = "";
                    control = 1;
                }
                else
                {
                    edadMin = cboEdadMin.SelectedItem.ToString();
                    entSala.SAL_EDAD_MIN = Convert.ToInt32(edadMin);
                    control = 0;

                    if (cboEdadMax.SelectedItem == null)
                    {
                        edadMax = "";
                        control = 1;
                    }
                    else
                    {
                        edadMax = cboEdadMax.SelectedItem.ToString();
                        entSala.EDAD_SALA_MAX = Convert.ToInt32(edadMax);
                        control = 0;

                        if (entSala.EDAD_SALA_MAX >= entSala.SAL_EDAD_MIN)
                        {
                            control = 0;

                            if (cantMax >= 0 && cantMax <= 30)
                            {
                                entSala.SALA_CANT_ALUM = cantMax;
                                control = 0;
                            }
                            else
                            {
                                MessageBox.Show("La cantidad máxima de alumnos, debe estar comprendida entre 0 y 30 alumnos");
                                control = 1;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La edad minima no puede superar a la edad maxima");
                            control = 1;
                        }
                    }
                }
            }                
                     
            entSala.SALA_ACTIVO = "S";

            if (control == 0)
            {
                metSala.InsertarSala(entSala);
                MessageBox.Show("Se registro correctamente la sala: " + entSala.SAL_NOMBRE);
                this.Close();
            }
            else
            {
                MessageBox.Show("NO SE PUDO REGISTRAR LA SALA: " + entSala.SAL_NOMBRE);                
            }
        }
        else
        {
          MessageBox.Show("No olvide ingresar " + validacion + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        }

        /********************/
        /** BOTON CANCELAR **/
        /********************/

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
