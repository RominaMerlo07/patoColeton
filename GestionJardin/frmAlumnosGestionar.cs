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
    public partial class frmAlumnosGestionar : Form
    {
        public frmAlumnosGestionar()
        {
            InitializeComponent();
        }

        private void frmAlumnosGestionar_Load(object sender, EventArgs e)
        {
              
        }

        private void btnGA_Agregar_Click(object sender, EventArgs e)
        {
            frmAlumnosPopUpAgregar frmAlumnosPopUpAgregar = new frmAlumnosPopUpAgregar();
            frmAlumnosPopUpAgregar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / INGRESAR ALUMNO NUEVO";
            frmAlumnosPopUpAgregar.ShowDialog();
        }

        private void btnGA_Editar_Click(object sender, EventArgs e)
        {
            frmAlumnosPopUpEditar frmAlumnosPopUpEditar = new frmAlumnosPopUpEditar();
            frmAlumnosPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / MODIFICAR DATOS ALUMNO";
            frmAlumnosPopUpEditar.ShowDialog();

        }

        private void btnGA_Eliminar_Click(object sender, EventArgs e)
        {
            frmAlumnosPopUpEliminar frmAlumnoPopUpEliminar = new frmAlumnosPopUpEliminar();
            frmAlumnoPopUpEliminar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / ELIMINAR ALUMNO";
            frmAlumnoPopUpEliminar.ShowDialog();
        }

        
    }
}
