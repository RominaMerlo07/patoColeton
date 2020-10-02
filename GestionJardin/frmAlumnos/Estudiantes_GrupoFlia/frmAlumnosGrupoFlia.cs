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

        private void frmAlumnosGrupoFlia_Load(object sender, EventArgs e)
        {
            dgvGrupoFlia.ClearSelection();
            cargar_BuscaAlumnos();

            btnGF_Eliminar.IconColor = Color.Gray;
            btnGF_Eliminar.ForeColor = Color.Gray;
            btnGF_Editar.IconColor = Color.Gray;
            btnGF_Editar.ForeColor = Color.Gray;

        }

        private void cargar_BuscaAlumnos()
        {
            //Autocompletar

            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            metPersonas metPersonas = new metPersonas();
            alumnos = metPersonas.traerPersonasAutocompetar("2");

            txtGF_Buscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtGF_Buscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGF_Buscar.AutoCompleteCustomSource = alumnos;
            
        }


        private void btnGF_Agregar_Click(object sender, EventArgs e)
        {

            frmAlumnosGrupoFliaPopUpAgregar frmAlumnosGrupoFliaPopUpAgregar = new frmAlumnosGrupoFliaPopUpAgregar();
            frmAlumnosGrupoFliaPopUpAgregar.FormClosed += frmAlumnosGrupoFliaPopUpAgregar_FormClosed;
            frmAlumnosGrupoFliaPopUpAgregar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / INGRESAR FAMILIAR";
            frmAlumnosGrupoFliaPopUpAgregar.ShowDialog();
        }

        private void btnGF_Editar_Click(object sender, EventArgs e)
        {
            if (dgvGrupoFlia.SelectedRows.Count > 0) {

                btnGF_Editar.IconColor = Color.Cyan;
                btnGF_Editar.ForeColor = Color.Cyan;

                string idPersonaSelect = dgvGrupoFlia.SelectedRows[0].Cells[0].Value.ToString();
                frmAlumnosGrupoFliaPopUpEditar frmAlumnosGrupoFliaPopUpEditar = new frmAlumnosGrupoFliaPopUpEditar(idPersonaSelect);
                frmAlumnosGrupoFliaPopUpEditar.FormClosed += frmAlumnosGrupoFliaPopUpEditar_FormClosed;
                frmAlumnosGrupoFliaPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / EDITAR O VISUALIZAR DATOS DEL FAMILIAR";
                frmAlumnosGrupoFliaPopUpEditar.ShowDialog();
            } else
            {
                btnGF_Editar.IconColor = Color.Gray;
                btnGF_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de un alumno");
            }
        }

        private void btnGF_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrupoFlia.SelectedRows.Count > 0)
            {
                btnGF_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGF_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string idPersonaSelect = dgvGrupoFlia.SelectedRows[0].Cells[0].Value.ToString();
                string nombreAlumno = dgvGrupoFlia.SelectedRows[0].Cells[1].Value.ToString();
                frmAlumnosGrupoFliaPopUpEliminar frmAlumnosGrupoFliaPopUpEliminar = new frmAlumnosGrupoFliaPopUpEliminar(idPersonaSelect, nombreAlumno);
                frmAlumnosGrupoFliaPopUpEliminar.FormClosed += frmAlumnosGrupoFliaPopUpEliminar_FormClosed; 
                frmAlumnosGrupoFliaPopUpEliminar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / ELIMINAR FAMILIAR";
                frmAlumnosGrupoFliaPopUpEliminar.ShowDialog();
            } else
            {
                btnGF_Eliminar.IconColor = Color.Gray;
                btnGF_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder dar de baja a un alumno");
            }
        }

        private void frmAlumnosGrupoFliaPopUpAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvGrupoFlia.DataSource = null;
            dgvGrupoFlia.Refresh();
        }

        private void frmAlumnosGrupoFliaPopUpEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvGrupoFlia.DataSource = null;
            dgvGrupoFlia.Refresh();
        }

        private void frmAlumnosGrupoFliaPopUpEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvGrupoFlia.DataSource = null;
            dgvGrupoFlia.Refresh();
        }     

        private void txtGF_Buscar_ButtonClick(object sender, EventArgs e)
        {
            string nombreB = "";
            string apellidoB = "";
            string documentoB = "";
            int contador = 0;

            string busqueda = txtGF_Buscar.Text;

            char[] separadores = { ',', '(', ')' };
            string[] palabras = busqueda.Split(separadores);

            foreach (var palabra in palabras)
            {
                contador += 1;
                if (contador == 1)
                {
                    nombreB = palabra.Trim();
                }
                else if (contador == 2)
                {
                    apellidoB = palabra.Trim();
                }
                else if (contador == 3)
                {
                    documentoB = palabra.Trim();
                }
            }

            entPersona personaBuscar = new entPersona();
            metPersonas objMetPersonas = new metPersonas();
            personaBuscar = objMetPersonas.BuscaPersona(nombreB, apellidoB, documentoB);

            String id_persona = Convert.ToString(personaBuscar.PER_ID);

            //rellenar dgv
            dgvGrupoFlia.Refresh();
            DataTable grupoFlia = new DataTable();
            metGrupoFlia objGrupoFlia = new metGrupoFlia();
            grupoFlia = objGrupoFlia.traerPersonasXGrupoFliar2(id_persona);

            if (grupoFlia.Rows.Count > 0)
            {
                dgvGrupoFlia.DataSource = grupoFlia;
                dgvGrupoFlia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvGrupoFlia.Columns["PER_ID"].Visible = false;
                dgvGrupoFlia.ClearSelection();

                //dgvGrupoFlia.Visible = true;
            }
        }

        private void dgvGrupoFlia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrupoFlia.SelectedRows.Count > 0)
            {
                btnGF_Editar.IconColor = Color.Cyan;
                btnGF_Editar.ForeColor = Color.Cyan;
                btnGF_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGF_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

            }
            else
            {
                dgvGrupoFlia.ClearSelection();
                btnGF_Editar.IconColor = Color.Gray;
                btnGF_Editar.ForeColor = Color.Gray;
                btnGF_Eliminar.IconColor = Color.Gray;
                btnGF_Eliminar.ForeColor = Color.Gray;

            }
        }
    }
}
