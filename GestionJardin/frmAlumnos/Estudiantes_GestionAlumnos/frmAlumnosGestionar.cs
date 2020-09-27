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

            cargar_dgvAlumnos();
            btnGA_Editar.Visible = false;
            btnGA_Eliminar.Visible = false;
            txtGA_Buscar.Visible = false; //MOMENTANEO. Hacer busqueda sobre datos de grilla.
            //dgvAlumnos.ClearSelection();
            btnGA_Filtrar.Visible = false;
            btnGA_Excel.Visible = false;
            btnGA_Pdf.Visible = false;
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGA_Filtrar_Click(object sender, EventArgs e)
        {

        }

        private void btnGA_Excel_Click(object sender, EventArgs e)
        {

        }

        private void btnGA_Pdf_Click(object sender, EventArgs e)
        {

        }

        private void txtGA_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void cargar_dgvAlumnos()
        {
            DataTable col = new DataTable();
            metPersonas metPersonas = new metPersonas();
            col = metPersonas.TraerAlumnos();
            dgvAlumnos.DataSource = col;

        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dgvAlumnos.SelectedRows.Count;

            if (rowsCount > 0)
            {
                btnGA_Editar.Visible = true;
                btnGA_Eliminar.Visible = true;

            } else
            {
                btnGA_Editar.Visible = false;
                btnGA_Eliminar.Visible = false;
            }
        }
    }
}
