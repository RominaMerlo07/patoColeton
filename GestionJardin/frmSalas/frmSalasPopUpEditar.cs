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
    public partial class frmSalasPopUpEditar : Form
    {

        string idSalaSelect;
        entSala sala = new entSala();
        metSala2 metSala = new metSala2();

        public frmSalasPopUpEditar()
        {
            InitializeComponent();
        }

        /*Se obtiene el id de la sala elegida en la grilla*/

        public frmSalasPopUpEditar(string idSalaSelect2)
        {
            InitializeComponent();
            idSalaSelect = idSalaSelect2;
            sala = metSala.buscarSalaXid(Convert.ToInt32(idSalaSelect));            
            cargarCampos(sala);
            onOffCampos(false);
        }

        /*Se cargan los datos en el form editar sala segun sala elegida en la grilla*/

        private void cargarCampos(entSala sala)
        {
            idSalaSelect = Convert.ToString(sala.SAL_ID); // se usara en el editar

            txtSala.Text = sala.SAL_NOMBRE;
            txtCantMax.Text = Convert.ToString(sala.SALA_CANT_ALUM);

            if (sala.SALA_TURNO.Trim() == "TARDE")
            {
                cboTurno.SelectedIndex = cboTurno.FindStringExact("TARDE");
            }
            else
            {
                cboTurno.SelectedIndex = cboTurno.FindStringExact("MAÑANA");
            }

            if (sala.SAL_EDAD_MIN == 1)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("1");
            }
            else if (sala.SAL_EDAD_MIN == 2)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("2");
            }
            else if (sala.SAL_EDAD_MIN == 3)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("3");
            }
            else if (sala.SAL_EDAD_MIN == 4)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("4");
            }
            else
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("5");
            }
            
            if (sala.EDAD_SALA_MAX == 1)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("1");
            }
            else if (sala.EDAD_SALA_MAX == 2)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("2");
            }
            else if (sala.EDAD_SALA_MAX == 3)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("3");
            }
            else if (sala.EDAD_SALA_MAX == 4)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("4");
            }
            else
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("5");
            }
        }


        /* Habilita la modificacion de los datos en el form */

        private void btnBloqueo_Click_1(object sender, EventArgs e)
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

        /*Metodos Validacion */

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

        private void onOffCampos(bool onOff)
        {

            txtSala.Enabled = onOff;
            cboTurno.Enabled = onOff;
            cboEdadMin.Enabled = onOff;
            cboEdadMax.Enabled = onOff;
            txtCantMax.Enabled = onOff;            
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

            string salatxt = txtSala.Text;
            string turno;
            string edadMin;
            string edadMax;
            int control = 0;
            int cantMax = 0;
            cantMax = Convert.ToInt32(txtCantMax.Text);
            sala.SALA_ACTIVO = "S";

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
                    sala.SALA_TURNO = "MANANA";
                    control = 0;
                }
                else
                {
                    sala.SALA_TURNO = "TARDE";
                    control = 0;
                }
            }

            if (salatxt != sala.SAL_NOMBRE)
            {
                sala.SAL_NOMBRE = salatxt;
                string result = metSala.ValidarSala(sala.SAL_NOMBRE, sala.SALA_TURNO);

                if (result == "SI")
                {
                    MessageBox.Show("El nombre de la sala ingresado: " + sala.SAL_NOMBRE + " ya se encuentra registrado en el turno " + turno);
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
                        sala.SAL_EDAD_MIN = Convert.ToInt32(edadMin);
                        control = 0;

                        if (cboEdadMax.SelectedItem == null)
                        {
                            edadMax = "";
                            control = 1;
                        }
                        else
                        {
                            edadMax = cboEdadMax.SelectedItem.ToString();
                            sala.EDAD_SALA_MAX = Convert.ToInt32(edadMax);
                            control = 0;

                            if (sala.EDAD_SALA_MAX >= sala.SAL_EDAD_MIN)
                            {
                                control = 0;

                                if (cantMax >= 0 && cantMax <= 30)
                                {
                                    sala.SALA_CANT_ALUM = cantMax;
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
                    sala.SAL_EDAD_MIN = Convert.ToInt32(edadMin);
                    control = 0;

                    if (cboEdadMax.SelectedItem == null)
                    {
                        edadMax = "";
                        control = 1;
                    }
                    else
                    {
                        edadMax = cboEdadMax.SelectedItem.ToString();
                        sala.EDAD_SALA_MAX = Convert.ToInt32(edadMax);
                        control = 0;

                        if (sala.EDAD_SALA_MAX >= sala.SAL_EDAD_MIN)
                        {
                            control = 0;

                            if (cantMax >= 0 && cantMax <= 30)
                            {
                                sala.SALA_CANT_ALUM = cantMax;
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

            if (control == 0)
            {
                metSala.EditarSala(sala);
                MessageBox.Show("Se actualizaron correctamente los datos de la sala: " + sala.SAL_NOMBRE);
                this.Close();
            }
            else
            {
                MessageBox.Show("NO SE PUDO REGISTRAR LA SALA: " + sala.SAL_NOMBRE);
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
