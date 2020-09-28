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
        }

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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            entSala.SAL_NOMBRE = txtSala.Text;
            entSala.SALA_ACTIVO = "S";          
            string turno;
            int control = 0;

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

            string edadMin;
            string edadMax;

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
            }

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
            }

            int cantMax = Convert.ToInt32(txtCantMax.Text);

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

            if(control == 0)
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
