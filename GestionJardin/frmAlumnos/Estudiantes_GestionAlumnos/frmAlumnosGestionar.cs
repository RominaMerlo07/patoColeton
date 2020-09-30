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

            dgvAlumnos.ClearSelection();

            cargar_dgvAlumnos();
            btnGA_Eliminar.IconColor = Color.Gray;
            btnGA_Eliminar.ForeColor = Color.Gray;
            btnGA_Editar.IconColor = Color.Gray;
            btnGA_Editar.ForeColor = Color.Gray;
            
            txtGA_Buscar.Visible = false; //MOMENTANEO. Hacer busqueda sobre datos de grilla.            
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

            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                btnGA_Editar.IconColor = Color.Cyan;
                btnGA_Editar.ForeColor = Color.Cyan;
                string idPersonaSelect = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                frmAlumnosPopUpEditar frmAlumnosPopUpEditar = new frmAlumnosPopUpEditar(idPersonaSelect);
                frmAlumnosPopUpEditar.FormClosed += frmAlumnosPopUpEditar_FormClosed;
                frmAlumnosPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / MODIFICAR DATOS ALUMNO";
                frmAlumnosPopUpEditar.ShowDialog();
            }
            else
            {
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de un alumno");
            }

        }

        private void btnGA_Eliminar_Click(object sender, EventArgs e)
        {

            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                btnGA_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGA_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string idPersonaSelect = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                string nombreAlumno = dgvAlumnos.SelectedRows[0].Cells[1].Value.ToString();
                frmAlumnosPopUpEliminar frmAlumnoPopUpEliminar = new frmAlumnosPopUpEliminar(idPersonaSelect, nombreAlumno);
                frmAlumnoPopUpEliminar.FormClosed += frmAlumnoPopUpEliminar_FormClosed;
                frmAlumnoPopUpEliminar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / ELIMINAR ALUMNO";
                frmAlumnoPopUpEliminar.ShowDialog();
            }
            else
            {
                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder dar de baja a un alumno");
            }

        }         

        private void btnGA_Pdf_Click(object sender, EventArgs e)
        {
            DataTable col = new DataTable();
            metPersonas metPersonas = new metPersonas();
            col = metPersonas.TraerAlumnos();
            dgvAlumnos.DataSource = col;
            dgvAlumnos.Columns["PER_ID"].Visible = false;
        }
               

        private void cargar_dgvAlumnos()
        {
            DataTable col = new DataTable();
            metPersonas metPersonas = new metPersonas();
            col = metPersonas.TraerAlumnos();
            dgvAlumnos.DataSource = col;
            dgvAlumnos.Columns["PER_ID"].Visible = false;

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

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                btnGA_Editar.IconColor = Color.Cyan;
                btnGA_Editar.ForeColor = Color.Cyan;
                btnGA_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGA_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

            }
            else
            {
                dgvAlumnos.ClearSelection();
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
                
            }
        }
    }
}
