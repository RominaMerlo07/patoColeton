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
            dtgrdocente.DataSource = objMetPersonas.Mostrardocente();
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


            if (dtgrdocente.SelectedRows.Count > 0)
            {
                frmDocentesPopUpEditar.ShowDialog();

            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro/fila para poder modificar el Docente");

            }


            frmDocentesPopUpEditar.ShowDialog();

        }

        private void btnGD_Eliminar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpEliminar frmDocentesPopUpEliminar = new frmDocentesPopUpEliminar();
            frmDocentesPopUpEliminar.Text = "GESTION DOCENTES / ELIMINAR DOCENTE";
            frmDocentesPopUpEliminar.ShowDialog();
        }

        private void txtGU_Buscar_Click(object sender, EventArgs e)
        {
            AutoCompleteStringCollection traerdocente = new AutoCompleteStringCollection();
            metPersonas metPersonas = new metPersonas();
            traerdocente = metPersonas.traerdocente();

            txtGU_Buscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtGU_Buscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGU_Buscar.AutoCompleteCustomSource = traerdocente;


            string nombreB = "";
            string apellidoB = "";
            string documentoB = "";
            int contador = 0;

            string busqueda = txtGU_Buscar.Text;

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

                entPersona personadocente = new entPersona();
                personadocente = objMetPersonas.BuscaPersona(nombreB, apellidoB, documentoB);


            }
        }

        private void txtGU_Buscar_Enter(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            objMetPersonas.llenarGrilla(docente);
        }

        private void txtGU_Buscar_ButtonClick(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            dtgrdocente.DataSource = objMetPersonas.llenarGrilla(docente);
        }
    }
}
