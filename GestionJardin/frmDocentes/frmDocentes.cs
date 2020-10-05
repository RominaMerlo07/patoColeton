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
        metSalas objMetSalas = new metSalas();
        AutoCompleteStringCollection traerdocente = new AutoCompleteStringCollection();
        metPersonas metPersonas = new metPersonas();
              

        public frmDocentes()
        {
            InitializeComponent();            
        }
        
        private void frmDocentes_Load(object sender, EventArgs e)
        {
            dgv_Docentes.ClearSelection();
            btnGD_Editar.IconColor = Color.Gray;
            btnGD_Editar.ForeColor = Color.Gray;
            btnGD_Eliminar.IconColor = Color.Gray;
            btnGD_Eliminar.ForeColor = Color.Gray;            
            dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();
            dgv_Docentes.Columns["DOCENTE"].Frozen = true;
            dgv_Docentes.Columns["DOCUMENTO"].Frozen = true;
         //   objMetPersonas.traerdocente(txtGD_Buscar);
        }

        /*  FUNCIONALIDAS BUSCAR, filtra la grilla */

        private void txtGD_Buscar_TextChanged_1(object sender, EventArgs e)
        {

            if (txtGD_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
            }
            else
            {
                txtGD_Buscar.Clear();
                dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();
                dgv_Docentes.Columns["DOCENTE"].Frozen = true;
                dgv_Docentes.Columns["DOCUMENTO"].Frozen = true;
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
            }                                  


            //if (txtGD_Buscar.Text.Length > 0)
            //{
            //    dgv_Docentes.DataSource = objMetPersonas.llenarGrilla(txtGD_Buscar.Text);
            //    btnGD_Editar.IconColor = Color.Gray;
            //    btnGD_Editar.ForeColor = Color.Gray;
            //    btnGD_Eliminar.IconColor = Color.Gray;
            //    btnGD_Eliminar.ForeColor = Color.Gray;
            //}
            //else
            //{
            //    txtGD_Buscar.Clear();
            //    dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();
            //    btnGD_Editar.IconColor = Color.Gray;
            //    btnGD_Editar.ForeColor = Color.Gray;
            //    btnGD_Eliminar.IconColor = Color.Gray;
            //    btnGD_Eliminar.ForeColor = Color.Gray;
            //}
        }

        private void txtGD_Buscar_Click(object sender, EventArgs e)
        {            
            txtGD_Buscar.CharacterCasing = CharacterCasing.Upper;//esto me pone las letras en mayusculas siempre

            if (txtGD_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
            }
            else
            {
                txtGD_Buscar.Clear();
                dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();
                dgv_Docentes.Columns["DOCENTE"].Frozen = true;
                dgv_Docentes.Columns["DOCUMENTO"].Frozen = true;
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
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
                dgv_Docentes.ClearSelection();
            }
        }


        /***************************************************/
        /***************** AGREGAR DOCENTE *****************/
        /***************************************************/

        private void btnGD_Agregar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpAgregar frmDocentesPopUpAgregar = new frmDocentesPopUpAgregar();
            frmDocentesPopUpAgregar.Text = "GESTION DOCENTES / INGRESAR NUEVO DOCENTE";
            frmDocentesPopUpAgregar.ShowDialog();

            dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();

            btnGD_Editar.IconColor = Color.Gray;
            btnGD_Editar.ForeColor = Color.Gray;
            btnGD_Eliminar.IconColor = Color.Gray;
            btnGD_Eliminar.ForeColor = Color.Gray;
            dgv_Docentes.ClearSelection();
        }

        /**************************************************/
        /***************** EDITAR DOCENTE *****************/
        /**************************************************/

        private void btnGD_Editar_Click(object sender, EventArgs e)
        {

            entPersona personaBuscar = new entPersona();
            frmDocentesPopUpEditar frmDocentesPopUpEditar = new frmDocentesPopUpEditar();
            entDomicilio domicilioBuscar = new entDomicilio();
            entSala salaBuscar = new entSala();            
            
            if (dgv_Docentes.SelectedRows.Count > 0)
            {
                btnGD_Editar.IconColor = Color.Cyan;
                btnGD_Editar.ForeColor = Color.Cyan;


                string documento = dgv_Docentes.CurrentRow.Cells[1].Value.ToString();

                personaBuscar = objMetPersonas.BuscaDocente(documento);

                if (personaBuscar.PER_NOMBRE != null)
                {
                    frmDocentesPopUpEditar.txt_id_Docente.Text = Convert.ToString(personaBuscar.PER_ID); // se usara en el editar


                    frmDocentesPopUpEditar.txtNombre.Text = personaBuscar.PER_NOMBRE;
                    frmDocentesPopUpEditar.txtApellidos.Text = personaBuscar.PER_APELLIDO;
                    frmDocentesPopUpEditar.txtDocumento.Text = documento;
                    frmDocentesPopUpEditar.dtNacimiento.Value = personaBuscar.PER_FECHA_NAC;

                    if (personaBuscar.PER_GENERO.StartsWith("M"))
                    {
                        frmDocentesPopUpEditar.cbGenero.SelectedIndex = frmDocentesPopUpEditar.cbGenero.FindStringExact("MASCULINO");
                    }
                    else
                    {
                        frmDocentesPopUpEditar.cbGenero.SelectedIndex = frmDocentesPopUpEditar.cbGenero.FindStringExact("FEMENINO");
                    }

                    domicilioBuscar = objmetDomicilio.buscarDomicilioXPersona(personaBuscar.PER_ID);

                    frmDocentesPopUpEditar.txtCalle.Text = domicilioBuscar.DOM_CALLE;
                    frmDocentesPopUpEditar.txtNumero.Text = Convert.ToString(domicilioBuscar.DOM_NUMERO);
                    frmDocentesPopUpEditar.txtCPostal.Text = Convert.ToString(domicilioBuscar.DOM_CP);
                    frmDocentesPopUpEditar.txtPiso.Text = Convert.ToString(domicilioBuscar.DOM_PISO);
                    frmDocentesPopUpEditar.txtDepto.Text = domicilioBuscar.DOM_DPTO;
                    frmDocentesPopUpEditar.txtBarrio.Text = domicilioBuscar.DOM_BARRIO;
                    frmDocentesPopUpEditar.txtTelefono.Text = personaBuscar.PER_TELEFONO;
                    frmDocentesPopUpEditar.txtCelular.Text = personaBuscar.PER_TELEFONO_2;
                    frmDocentesPopUpEditar.txtEmail.Text = personaBuscar.PER_EMAIL;


                    if (salaBuscar.SALA_TURNO == null)
                    {
                        frmDocentesPopUpEditar.cbTurno.SelectedIndex = frmDocentesPopUpEditar.cbTurno.FindStringExact("");
                    }
                    else
                    {

                        salaBuscar = objMetSalas.buscarSalaXPersona(personaBuscar.PER_ID);


                        if (salaBuscar.SALA_TURNO.Trim() == "TARDE")
                        {
                            frmDocentesPopUpEditar.cbTurno.SelectedIndex = frmDocentesPopUpEditar.cbTurno.FindStringExact("TARDE");
                        }
                        else
                        {
                            frmDocentesPopUpEditar.cbTurno.SelectedIndex = frmDocentesPopUpEditar.cbTurno.FindStringExact("MAÑANA");
                        }

                        string indexTurno = frmDocentesPopUpEditar.cbTurno.SelectedIndex.ToString();
                        frmDocentesPopUpEditar.cbSala.DataSource = objMetSalas.ListarSalas(indexTurno);
                        frmDocentesPopUpEditar.cbSala.DisplayMember = "SAL_NOMBRE";
                        frmDocentesPopUpEditar.cbSala.ValueMember = "SAL_ID";

                        frmDocentesPopUpEditar.cbSala.SelectedIndex = frmDocentesPopUpEditar.cbSala.FindStringExact(salaBuscar.SAL_NOMBRE);
                    }
                }
                frmDocentesPopUpEditar.Text = "GESTION DOCENTES / MODIFICAR/VISUALIZAR DATOS DEL DOCENTE";
                AddOwnedForm(frmDocentesPopUpEditar);
                frmDocentesPopUpEditar.ShowDialog();

                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                dgv_Docentes.ClearSelection();

            }
            
            else
            {
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder visualizar/modificar los datos del Docente");
            }                                 

        }

        /**************************************************/
        /***************** ELIMINAR DOCENTE *****************/
        /**************************************************/

        private void btnGD_Eliminar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpEliminar frmDocentesPopUpEliminar = new frmDocentesPopUpEliminar();
            entPersona personaBuscar = new entPersona();          

            if (dgv_Docentes.SelectedRows.Count > 0)
            {

                btnGD_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGD_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string documento = dgv_Docentes.CurrentRow.Cells[1].Value.ToString();
                personaBuscar = objMetPersonas.BuscaDocente(documento);

                if (personaBuscar.PER_NOMBRE != null)
                {
                    frmDocentesPopUpEliminar.txt_id_Docente.Text = Convert.ToString(personaBuscar.PER_ID); // se usara en el editar                                     
                    frmDocentesPopUpEliminar.lblnombredocente.Text = "'" + dgv_Docentes.CurrentRow.Cells[0].Value.ToString() + "'";
                }

               // frmDocentesPopUpEliminar.lbldnidoc.Text =  dgv_Docentes.CurrentRow.Cells[1].Value.ToString() ;
                frmDocentesPopUpEliminar.Text = "GESTION DOCENTES / ELIMINAR DOCENTE";
                frmDocentesPopUpEliminar.ShowDialog();
                dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();

                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                dgv_Docentes.ClearSelection();

            }
            else
            {
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder dar de baja al Docente");
            }
                
        }


        private void carga_grilla_filtrada()
        {
            DataTable col = new DataTable();
            metPersonas metPersonas = new metPersonas();
            col = metPersonas.Mostrardocente();
            dgv_Docentes.DataSource = col;
            string apellido_nombre = metPersonas.extraerapellido_nombre_alumno(txtGD_Buscar);
            col.DefaultView.RowFilter = String.Format($"DOCENTE LIKE '{apellido_nombre}%'");

        }

    }
}
