using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionJardin
{
    public partial class frmDocentes : Form
    {
        metPersonas objMetPersonas = new metPersonas();
        entPersona objPersona = new entPersona();
        metDomicilio objmetDomicilio = new metDomicilio();

        AutoCompleteStringCollection traerdocente = new AutoCompleteStringCollection();
        metPersonas metPersonas = new metPersonas();
                        
        public frmDocentes()
        {
            InitializeComponent();           
            CargarGrilla();            
        }
        public void CargarGrilla()
        {
            dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();
        }


        private void btnGD_Agregar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpAgregar frmDocentesPopUpAgregar = new frmDocentesPopUpAgregar();
            frmDocentesPopUpAgregar.Text = "GESTION DOCENTES / INGRESAR NUEVO DOCENTE";
            frmDocentesPopUpAgregar.ShowDialog();
        }

        private void btnGD_Editar_Click(object sender, EventArgs e)
        {
                        
            if (dgv_Docentes.SelectedRows.Count > 0)
            {
                btnGD_Editar.IconColor = Color.Cyan;
                btnGD_Editar.ForeColor = Color.Cyan;
                frmDocentesPopUpEditar frmDocentesPopUpEditar = new frmDocentesPopUpEditar();
                frmDocentesPopUpEditar.Text = "GESTION DOCENTES / MODIFICAR/VISUALIZAR DATOS DEL DOCENTE";
                frmDocentesPopUpEditar.ShowDialog();
            }
            else
            {
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder visualizar/modificar los datos del Docente");
            }
                                  

        }

        private void btnGD_Eliminar_Click(object sender, EventArgs e)
        {

            if (dgv_Docentes.SelectedRows.Count > 0)
            {

                btnGD_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGD_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
                frmDocentesPopUpEliminar frmDocentesPopUpEliminar = new frmDocentesPopUpEliminar();
                frmDocentesPopUpEliminar.Text = "GESTION DOCENTES / ELIMINAR DOCENTE";
                frmDocentesPopUpEliminar.ShowDialog();
            }
            else
            {
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder dar de baja al Docente");
            }
                
        }
                   
        private void dgv_Docentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Docentes.SelectedRows.Count > 0)
            {
                btnGD_Editar.IconColor = Color.Cyan;
                btnGD_Editar.ForeColor = Color.Cyan;
                btnGD_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGD_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
            }
        }

        private void txtGD_Buscar_Enter(object sender, EventArgs e)
        {
            string docente = txtGD_Buscar.Text;
            dgv_Docentes.DataSource = objMetPersonas.llenarGrilla(docente);
        }

        private void txtGD_Buscar_ButtonClick(object sender, EventArgs e)
        {
            string docente = txtGD_Buscar.Text;
            dgv_Docentes.DataSource = objMetPersonas.llenarGrilla(docente);

        }

        private void txtGD_Buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
