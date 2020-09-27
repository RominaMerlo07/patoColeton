using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    class metSala2 : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        public DataTable Grilla()
        {
            con = generarConexion();
            con.Open();


            string consulta = "WITH t1 AS (" +
                                       "SELECT COUNT(*) ACTIVOS, " +
                                              "SAL_NOMBRE, " +
                                              "SAL_TURNO, " +
                                              "SAL_CANT_ALUM, " +
                                              "SAL_ID " +
                                        "FROM T_GRUPO_SALA, T_SALA " +
                                        "WHERE GRS_SAL_ID = SAL_ID " +
                                        "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID " +
                                      "UNION " +
                                       "SELECT 0 , " +
                                              "SAL_NOMBRE, " +
                                              "SAL_TURNO, " +
                                              "SAL_CANT_ALUM, " +
                                              "SAL_ID " +
                                       "FROM T_SALA s " +
                                       "WHERE SAL_ID not in (SELECT GRS_SAL_ID FROM T_GRUPO_SALA ) " +
                                       "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID) " +
                               "SELECT t1.SAL_NOMBRE NOMBRE_SALA, " +
                                      "(CASE t1.SAL_TURNO WHEN 'MANANA' THEN 'MAÑANA' ELSE 'TARDE' END) TURNO, " +
                                      "CONCAT(S.SAL_EDAD_MIN, ' años', ' - ', S.SAL_EDAD_MAX, ' años') RANGO, " +
                                      "t1.SAL_CANT_ALUM CUPO_TOTAL, " +
                                      "t1.ACTIVOS CUPOS_ACTIVOS, " +
                                      "((t1.SAL_CANT_ALUM - t1.ACTIVOS)) CUPOS_VACANTES " +
                                "FROM t1, T_SALA S " +
                                "WHERE T1.SAL_ID = S.SAL_ID " +
                                "ORDER BY RANGO, t1.SAL_NOMBRE, t1.SAL_TURNO;";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }
    }
}
