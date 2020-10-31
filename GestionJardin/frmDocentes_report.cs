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
    public partial class frmDocentes_report : Form
    {
        public frmDocentes_report()
        {
            InitializeComponent();
        }

        private void frmDocentes_report_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetdoc.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetdoc.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
