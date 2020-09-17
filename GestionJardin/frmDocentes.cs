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
    public partial class frmDocentes : Form
    {
        public frmDocentes()
        {
            InitializeComponent();
        }

        private void btnGD_Agregar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpAgregar frmDocentesPopUpAgregar = new frmDocentesPopUpAgregar();
            frmDocentesPopUpAgregar.Text = "GESTION DOCENTES / INGRESAR NUEVO DOCENTE";
            frmDocentesPopUpAgregar.ShowDialog();
        }

        private void btnGD_Editar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpEditar frmDocentesPopUpEditar = new frmDocentesPopUpEditar();
            frmDocentesPopUpEditar.Text = "GESTION DOCENTES / MODIFICAR/VISUALIZAR DATOS DEL DOCENTE";
            frmDocentesPopUpEditar.ShowDialog();
        }

        private void btnGD_Eliminar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpEliminar frmDocentesPopUpEliminar = new frmDocentesPopUpEliminar();
            frmDocentesPopUpEliminar.Text = "GESTION DOCENTES / ELIMINAR DOCENTE";
            frmDocentesPopUpEliminar.ShowDialog();
        }
    }
}
