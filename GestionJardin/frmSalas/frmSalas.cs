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
    public partial class frmSalas : Form
    {

        metSala2 metSala = new metSala2();

        public frmSalas()
        {
            InitializeComponent();
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
            dgv_Salas.DataSource = metSala.Grilla();
        }
    }
}
