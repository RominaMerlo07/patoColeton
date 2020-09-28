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

        public DataTable GrillaSalas()
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

        public DataTable FiltrarSala(string sala, string turno)
        {            

            con = generarConexion();
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = this.con;
            cmd.CommandText = "WITH t1 AS (SELECT COUNT(*) ACTIVOS, " +
                                                  "SAL_NOMBRE, " +
                                                  "SAL_TURNO, " +
                                                  "SAL_CANT_ALUM, " +
                                                  "SAL_ID" +
                                           " FROM T_GRUPO_SALA, T_SALA " +
                                           "WHERE GRS_SAL_ID = SAL_ID " +
                                           "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID " +
                                           "UNION " +
                                           "SELECT 0 , " +
                                           "SAL_NOMBRE, " +
                                           "SAL_TURNO, " +
                                           "SAL_CANT_ALUM, " +
                                           "SAL_ID " +
                                           "FROM T_SALA s " +
                                           "WHERE SAL_ID not in (SELECT GRS_SAL_ID " +
                                                                  "FROM T_GRUPO_SALA ) " +
                                           "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID) " +
                                           "SELECT t1.SAL_NOMBRE NOMBRE_SALA, " +
                                           "(CASE t1.SAL_TURNO WHEN 'MANANA' THEN 'MAÑANA' ELSE 'TARDE' END) TURNO, " +
                                           "CONCAT(S.SAL_EDAD_MIN, ' años', ' - ', S.SAL_EDAD_MAX, ' años') RANGO, " +
                                           "t1.SAL_CANT_ALUM CUPO_TOTAL, " +
                                           "t1.ACTIVOS CUPOS_ACTIVOS, " +
                                           "((t1.SAL_CANT_ALUM - t1.ACTIVOS)) CUPOS_VACANTES " +
                                           "FROM t1, T_SALA S " +
                                           "WHERE t1.SAL_ID = S.SAL_ID " +
                                           "AND UPPER(t1.SAL_NOMBRE) LIKE UPPER('" + sala + "%') " +
                                           "AND UPPER(t1.SAL_TURNO) LIKE UPPER('" + turno + "%') " +
                                           "ORDER BY RANGO, t1.SAL_NOMBRE, t1.SAL_TURNO; ";


            dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }


        public string BuscarSala(MetroFramework.Controls.MetroTextBox pbarrabuscar)
        {
            con = generarConexion();
            con.Open();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();


            string consulta = "SELECT (SAL_NOMBRE + '-' + (CASE SAL_TURNO WHEN 'MANANA' THEN 'MAÑANA ' ELSE 'TARDE ' END)) SALA " +
                                "FROM T_SALA " +
                               "WHERE SAL_ACTIVO = 'S';"; 


            cmd = new SqlCommand(consulta, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pbarrabuscar.AutoCompleteCustomSource.Add(dr["SALA"].ToString());
            }
            dr.Close();

            con.Close();

            return consulta;
        }

        public string InsertarSala(entSala sala)
        {
            string result;
                       

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_SALA " +
                                                    "(SAL_NOMBRE, " +
                                                    "SAL_TURNO, " +
                                                    "SAL_EDAD_MIN, " +
                                                    "SAL_EDAD_MAX, " +
                                                    "SAL_CANT_ALUM, " +
                                                    "SAL_ACTIVO) " +
                                           "VALUES( '"+sala.SAL_NOMBRE+"','" +
                                                    ""+sala.SALA_TURNO+"'," +
                                                    ""+sala.SAL_EDAD_MIN+"," +
                                                    ""+sala.EDAD_SALA_MAX+"," +
                                                    ""+sala.SALA_CANT_ALUM+",'" +
                                                    ""+sala.SALA_ACTIVO+"');";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch (Exception ex)
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error-" + ex.ToString());

            }

            return result;
        }

    }
}
