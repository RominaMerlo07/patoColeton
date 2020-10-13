using GestionJardin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class metAsistencia : Conexion 
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;


        public DataTable GrillaAsistencia(string turno, string sala, string fecha)
        {
            con = generarConexion();
            con.Open();


            string consulta = " SELECT PER_ID, " +
                                      "(PER_NOMBRE + ' ' + PER_APELLIDO) ALUMNO, " +
                                      "PER_DOCUMENTO DOCUMENTO, " +
                                      "SAL_NOMBRE SALA, " +
                                      "CASE SAL_TURNO " +
                                        "WHEN 'MANANA' THEN 'MAÑANA' " +
                                        "ELSE 'TARDE' " +
                                      "END TURNO, " +
                                      "CONVERT(VARCHAR(10), '" + fecha + "', 103) FECHA, " +
                                      "'' ASISTENCIA, " +
                                      "'' JUSTIFICADO " +
                                      "FROM T_PERSONAS , T_SALA , T_GRUPO_SALA " +
                                      "WHERE PER_ID = GRS_PER_ID " +
                                      "AND SAL_ID = GRS_SAL_ID " +
                                      "AND PER_TPE_ID = 2 " +
                                      "AND PER_ESTADO = 'S' " +
                                      "AND SAL_ID = '" + sala + "' " +
                                      "AND SAL_TURNO = '" + turno + "' " +
                                      "AND PER_ID NOT IN(SELECT AS_ID_PERSONA FROM T_ASISTENCIA " +
                                                         "WHERE AS_ID_PERSONA = PER_ID " +
                                                           "AND AS_FECHA = CONVERT(VARCHAR(10), '"+fecha+"', 103))" +
                                "UNION " +
                               "SELECT PER_ID, " +
                                      "(PER_NOMBRE + ' ' + PER_APELLIDO) ALUMNO, " +
                                      "PER_DOCUMENTO DOCUMENTO, " +
                                      "SAL_NOMBRE SALA, " +
                                      "CASE SAL_TURNO " +
                                         "WHEN 'MANANA' THEN 'MAÑANA' " +
                                         "ELSE 'TARDE' " +
                                      "END TURNO, " +
                                      "AS_FECHA, " +
                                      "AS_ASISTENCIA ASISTENCIA, " +
                                      "AS_JUSTIFICADO JUSTIFICADO " +
                                      "FROM T_PERSONAS , T_SALA , T_ASISTENCIA " +
                                      "WHERE AS_ID_PERSONA = PER_ID " +
                                      "AND AS_SAL_ID = SAL_ID " +
                                      "AND PER_TPE_ID = 2 " +
                                      "AND PER_ESTADO = 'S' " +
                                      "AND SAL_ID = '" + sala + "' " +
                                      "AND SAL_TURNO = '" +turno+"' " +
                                      "AND AS_FECHA = CONVERT(VARCHAR(10), '" + fecha + "', 103);";

            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

    }
}
