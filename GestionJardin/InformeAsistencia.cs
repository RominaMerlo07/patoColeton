using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;
using System.IO;

using CaLog;

namespace GestionJardin
{
    public partial class InformeAsistencia : Form
    {

        logAsistencia logAsistencia = new logAsistencia();

        public InformeAsistencia(string idSala, string turno, DateTime fecha) 
        {
            InitializeComponent();
            InformeAsistenciaBindingSource.DataSource = logAsistencia.InformeAsistencia(turno, idSala, fecha.ToShortDateString());
            //ver con Gas porque no me muestra lo mismo que en la tabla porque???????????????
            this.reportViewer1.RefreshReport();          

        }

       

        
    }
}
