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
    public partial class frmAlumnosGrupoFlia : Form
    {
        public frmAlumnosGrupoFlia()
        {
            InitializeComponent();
        }

        private void btnGF_Agregar_Click(object sender, EventArgs e)
        {
            frmAlumnosGrupoFliaPopUpAgregar frmAlumnosGrupoFliaPopUpAgregar = new frmAlumnosGrupoFliaPopUpAgregar();
            frmAlumnosGrupoFliaPopUpAgregar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / INGRESAR FAMILIAR";
            frmAlumnosGrupoFliaPopUpAgregar.ShowDialog();
        }

        private void btnGF_Editar_Click(object sender, EventArgs e)
        {
            frmAlumnosGrupoFliaPopUpEditar frmAlumnosGrupoFliaPopUpEditar = new frmAlumnosGrupoFliaPopUpEditar();
            frmAlumnosGrupoFliaPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / EDITAR O VISUALIZAR DATOS DEL FAMILIAR";
            frmAlumnosGrupoFliaPopUpEditar.ShowDialog();
        }

        private void btnGF_Eliminar_Click(object sender, EventArgs e)
        {
            frmAlumnosGrupoFliaPopUpEliminar frmAlumnosGrupoFliaPopUpEliminar = new frmAlumnosGrupoFliaPopUpEliminar();
            frmAlumnosGrupoFliaPopUpEliminar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / ELIMINAR FAMILIAR";
            frmAlumnosGrupoFliaPopUpEliminar.ShowDialog();
        }
    }
}
