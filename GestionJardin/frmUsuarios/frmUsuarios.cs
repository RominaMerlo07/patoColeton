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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnGU_Agregar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpAgregar frmUsuariosPopUpAgregar = new frmUsuariosPopUpAgregar();
            frmUsuariosPopUpAgregar.Text = "GESTION USUARIOS / GENERAR NUEVO USUARIO";
            frmUsuariosPopUpAgregar.ShowDialog();
        }

        private void btnGU_Editar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEditar frmUsuariosPopUpEditar = new frmUsuariosPopUpEditar();
            frmUsuariosPopUpEditar.Text = "GESTION USUARIOS / MODIFICAR CONTRASEÑA";
            frmUsuariosPopUpEditar.ShowDialog();
        }

        private void btnGU_Eliminar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEliminar frmUsuariosPopUpEliminar = new frmUsuariosPopUpEliminar();
            frmUsuariosPopUpEliminar.Text = "GESTION USUARIOS / ELIMINAR USUARIO";
            frmUsuariosPopUpEliminar.ShowDialog();
        }
    }
}
