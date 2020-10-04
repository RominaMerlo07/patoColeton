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
                       
              entSala.SAL_NOMBRE = txtSala.Text;

                string turno;
                int control;
                string edadMin;
                string edadMax;
              //  int cantMax = 0;
                        
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

                                if (Convert.ToInt32(txtCantMax.Text) > 0 || Convert.ToInt32(txtCantMax.Text) <= 30)
                                {
                                entSala.SALA_CANT_ALUM = Convert.ToInt32(txtCantMax.Text);
                                control = 0;
                                }
                                else
                                {
                                    MessageBox.Show("La cantidad máxima de alumnos, debe estar comprendida entre 1 y 30 alumnos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    //   MessageBox.Show("La cantidad máxima de alumnos, debe estar comprendida entre 0 y 30 alumnos");
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

        /********************/
        /** BOTON CANCELAR **/
        /********************/

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSala.Text.Trim()) == true)
            {
                txtSala.Style = MetroFramework.MetroColorStyle.Red;
                txtSala.Focus();
                MessageBox.Show(" Por favor ingrese el nombre de la sala. Por ejemplo: 'AZUL'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTurno.Text.Trim()) == true)
            {
                cboTurno.Style = MetroFramework.MetroColorStyle.Red;
                cboTurno.Focus();
                MessageBox.Show(" Por favor seleccione un turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string turno;               
             
                    turno = cboTurno.SelectedItem.ToString();

                    if (turno == "MAÑANA")
                    {
                    turno = "MANANA";
                        
                    }
                    else
                    {
                    turno = "TARDE";
                        
                    }                                 

                    string result = metSala.ValidarSala(txtSala.Text, turno);

                    if (result == "SI")
                    {
                        txtSala.Clear();
                        txtSala.Style = MetroFramework.MetroColorStyle.Red;
                        txtSala.Focus();
                        MessageBox.Show("El nombre de la sala ingresado: " + txtSala.Text + " ya se encuentra registrado en el turno " + turno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private void cboEdadMin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboEdadMin.Text.Trim()) == true)
            {
                cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMin.Focus();
                MessageBox.Show(" Por favor seleccione un valor para 'edad mínima'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEdadMax_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboEdadMax.Text.Trim()) == true)
            {
                cboEdadMax.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMax.Focus();
                MessageBox.Show(" Por favor seleccione un valor para 'edad máxima'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(cboEdadMax.SelectedItem) < Convert.ToInt32(cboEdadMin.SelectedItem))
            {
                cboEdadMin.SelectedIndex = -1;                
                cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMin.Focus();
                MessageBox.Show(" La edad máxima no puede ser menor a la edad minima", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEdadMax.SelectedIndex = -1;
            }           
        
        }

        private void txtCantMax_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCantMax.Text.Trim()) == true)
            {
                txtCantMax.Style = MetroFramework.MetroColorStyle.Red;
                txtCantMax.Focus();
                MessageBox.Show(" Por favor ingrese un valor para 'Cantidad máxima de alumnos'. El mismo debe tener un valor mayor a 0 y no superar los 30 alumnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtCantMax.Text) < 0 || Convert.ToInt32(txtCantMax.Text) > 30)
            {
                txtCantMax.Style = MetroFramework.MetroColorStyle.Red;
                txtCantMax.Focus();
                MessageBox.Show("La 'Cantidad de alumnos máxima' debe tener un valor mayor a 0 y no superar los 30 alumnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
