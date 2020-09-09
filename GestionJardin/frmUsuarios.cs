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
        
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            btn_EditarUsuario.IconColor = Color.DimGray;
            btn_EliminarUsuario.IconColor = Color.DimGray;            
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(181, 244, 190); //verde
            public static Color color2 = Color.FromArgb(34, 33, 74); // azul fondo
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        
        private void btn_AgregarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpAgregar formAU = new frmUsuariosPopUpAgregar();
            formAU.ShowDialog();
        }

        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEditar formEU = new frmUsuariosPopUpEditar();
            if (dgv_UsuariosActivos.SelectedRows.Count == 1)
            {
                formEU.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro/fila para poder modificar la contraseña"); 
                /*Agregar notificacion con icono de alerta amarillo (Romi)*/
            }
        }

        private void btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEliminar formElU = new frmUsuariosPopUpEliminar();
            if (dgv_UsuariosActivos.SelectedRows.Count >= 1)
            {
                formElU.ShowDialog(); 
                /*Agregar efecto parpadeante al icono de alerta (Romi)*/
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro/fila para poder ELIMINARLO");
                /*Agregar notificacion con icono de alerta amarillo (Romi)*/
            }
        }







        //private void btn_AgregarUsuario_MouseHover(object sender, EventArgs e)
        //{
        //    ((Button)sender).BackColor = RGBColors.color1;
        //    btn_AgregarUsuario.IconColor = Color.Black;

        //}

        //private void btn_AgregarUsuario_MouseLeave(object sender, EventArgs e)
        //{
        //    ((Button)sender).BackColor = RGBColors.color2;
        //    btn_AgregarUsuario.IconColor = RGBColors.color1;
        //}
    }
}
