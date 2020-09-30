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
            metSala2 metSala = new metSala2();

            idEliminar = lblIdSala.Text;
            sala.SAL_ID = Convert.ToInt32(idEliminar);
            string resultado = metSala.EliminarSala(sala);
            if (resultado == "OK")
            {
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
