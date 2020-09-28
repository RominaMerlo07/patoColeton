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
            frmAlumnosPopUpAgregar.FormClosed += frmAlumnosPopUpAgregar_FormClosed;
            frmAlumnosPopUpAgregar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / INGRESAR ALUMNO NUEVO";
            frmAlumnosPopUpAgregar.ShowDialog();
        }

        private void btnGA_Editar_Click(object sender, EventArgs e)
        {
            string idPersonaSelect = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString();
            frmAlumnosPopUpEditar frmAlumnosPopUpEditar = new frmAlumnosPopUpEditar(idPersonaSelect);
            frmAlumnosPopUpEditar.FormClosed += frmAlumnosPopUpEditar_FormClosed;
            frmAlumnosPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / MODIFICAR DATOS ALUMNO";
            frmAlumnosPopUpEditar.ShowDialog();


        }

        private void btnGA_Eliminar_Click(object sender, EventArgs e)
        {
            string idPersonaSelect = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString();
            string nombreAlumno = dgvAlumnos.SelectedRows[0].Cells[1].Value.ToString();
            frmAlumnosPopUpEliminar frmAlumnoPopUpEliminar = new frmAlumnosPopUpEliminar(idPersonaSelect, nombreAlumno);
            frmAlumnoPopUpEliminar.FormClosed += frmAlumnoPopUpEliminar_FormClosed;
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
            dgvAlumnos.Columns["PER_ID"].Visible = false;

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

        private void frmAlumnosPopUpEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_dgvAlumnos();
        }

        private void frmAlumnoPopUpEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_dgvAlumnos();
        }

        private void frmAlumnosPopUpAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_dgvAlumnos();
        }
  
    }
}
