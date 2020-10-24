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
    public partial class frmSalasPopUpEliminar : Form
    {

        string idEliminar;
             

        public frmSalasPopUpEliminar(string idEliminar, string sala)
        {
            
            InitializeComponent();
            lblSala.Text = sala + "?";
            lblIdSala.Text = idEliminar;
        }

        private void btn_ConfirmarEliminar_Click(object sender, EventArgs e)
        {

            entSala sala = new entSala();
            logSala2 metSala = new logSala2();

            idEliminar = lblIdSala.Text;
            sala.SAL_ID = Convert.ToInt32(idEliminar);
            
            string nombreSala = lblSala.Text.TrimEnd('?');

            string resultado = metSala.EliminarSala(sala);
            if (resultado == "OK")
            {
                MessageBox.Show("Se elimino correctamente la sala: " + nombreSala, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();                
            }
            else
            {
                MessageBox.Show("NO se pudo eliminar la sala: " + nombreSala, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
