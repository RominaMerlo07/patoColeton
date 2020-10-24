using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt//GestionJardin
{
    public class entAsistencia
    {
        private Int32 p_asID;
        public Int32 AS_ID
        {
            get { return p_asID; }
            set { p_asID = value; }
        }

        private Int32 p_as_PerID;
        public Int32 AS_PER_ID
        {
            get { return p_as_PerID; }
            set { p_as_PerID = value; }
        }

        private DateTime p_asFECHA;
        public DateTime AS_FECHA
        {
            get { return p_asFECHA; }
            set { p_asFECHA = value; }
        }

        private Int32 p_as_SalID;
        public Int32 AS_SAL_ID
        {
            get { return p_as_SalID; }
            set { p_as_SalID = value; }
        }

        private Int32 p_as_ANO;
        public Int32 AS_ANO
        {
            get { return p_as_ANO; }
            set { p_as_ANO = value; }
        }

        private String p_as_ASISTENCIA;
        public String AS_ASISTENCIA
        {
            get { return p_as_ASISTENCIA; }
            set { p_as_ASISTENCIA = value; }
        }

        private String p_as_JUSTIFICADO;
        public String AS_JUSTIFICADO
        {
            get { return p_as_JUSTIFICADO; }
            set { p_as_JUSTIFICADO = value; }
        }

        private Int32 p_as_SEMESTRE;
        public Int32 AS_SEMESTRE
        {
            get { return p_as_SEMESTRE; }
            set { p_as_SEMESTRE = value; }
        }


        public entAsistencia()
        {

        }

        public class entAsistenciaColeccion : List<entAsistencia>
        { }
    }
}
