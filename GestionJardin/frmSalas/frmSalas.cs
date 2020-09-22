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
    public partial class frmSalas : Form
    {

        metSala2 metSala = new metSala2();

        public frmSalas()
        {
            InitializeComponent();
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
            dgv_Salas.DataSource = metSala.Grilla();
            dgv_Salas.ClearSelection();          
        }

        private void btnGS_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Salas.SelectedRows.Count > 0)
            {
                btnGS_Editar.IconColor = Color.Cyan;
                btnGS_Editar.ForeColor = Color.Cyan;
            }
            else
            {
                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de la sala");
            }
        }

     
        private void dgv_Salas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Salas.SelectedRows.Count > 0)
            {
                btnGS_Editar.IconColor = Color.Cyan;
                btnGS_Editar.ForeColor = Color.Cyan;
                btnGS_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGS_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;
               
            }
        }

        private void btnGS_Eliminar_Click(object sender, EventArgs e)
        {            
            if (dgv_Salas.SelectedRows.Count > 0)
            {
                btnGS_Eliminar.IconColor = Color.FromArgb(255,128,0);
                btnGS_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de la sala");
            }
        }
    }
}
