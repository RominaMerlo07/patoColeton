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
    public partial class frmConcepto : Form
    {
        public frmConcepto()
        {
            InitializeComponent();
        }

        private void btnCon_Agregar_Click(object sender, EventArgs e)
        {
            frmConcepto_Agregar frmConcepto_Agregar = new frmConcepto_Agregar();
            frmConcepto_Agregar.Text = "GESTIÓN COBROS / CONCEPTOS / GESTIONAR / AGREGAR";
            frmConcepto_Agregar.ShowDialog();
        }
    }
}
