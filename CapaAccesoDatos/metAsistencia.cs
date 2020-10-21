using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace GestionJardin
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


            string consulta = "SELECT PER_ID, " +
                                     "'' AS_ID, " +
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
                                "AND PER_ID NOT IN (SELECT AS_ID_PERSONA " +
                                                     "FROM T_ASISTENCIA " +
                                                    "WHERE AS_ID_PERSONA = PER_ID " +
                                                      "AND AS_FECHA = CONVERT(VARCHAR(10), '" + fecha + "', 103)) " +
                            "UNION " +
                            "SELECT PER_ID, " +
                                   "AS_ID AS_ID, " +
                                  "(PER_NOMBRE + ' ' + PER_APELLIDO) ALUMNO, " +
                                  "PER_DOCUMENTO DOCUMENTO, " +
                                  "SAL_NOMBRE SALA, " +
                                  "CASE SAL_TURNO " +
                                    "WHEN 'MANANA' THEN 'MAÑANA' " +
                                    "ELSE 'TARDE' " +
                                  "END TURNO, " +
                                  "AS_FECHA, " +
                                  "CASE AS_ASISTENCIA " +
                                    "WHEN '0' THEN 'P' " +
                                    "WHEN '1' THEN 'A' " +
                                  "END ASISTENCIA, " +
                                  "CASE  AS_JUSTIFICADO " +
                                    "WHEN '0' THEN 'SI' " +
                                    "WHEN '1' THEN 'NO' " +
                                    "ELSE '' " +
                                  "END JUSTIFICADO " +
                            "FROM T_PERSONAS, T_SALA, T_ASISTENCIA " +
                           "WHERE AS_ID_PERSONA = PER_ID " +
                             "AND AS_SAL_ID = SAL_ID " +
                             "AND PER_TPE_ID = 2 " +
                             "AND PER_ESTADO = 'S' " +
                             "AND SAL_ID = '" + sala + "' " +
                             "AND SAL_TURNO = '" + turno + "' " +
                             "AND AS_FECHA = CONVERT(VARCHAR(10), '" + fecha + "', 103)";

            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

        public void AgregarAsistencia(entAsistencia asistencia)
        {
            con = generarConexion();
            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("INSERT INTO T_ASISTENCIA " +
                                                            "(AS_ID_PERSONA ," +
                                                            " AS_FECHA, " +
                                                            " AS_SAL_ID, " +
                                                            " AS_ANO, " +
                                                            " AS_ASISTENCIA, " +
                                                            " AS_JUSTIFICADO, " +
                                                            " AS_SEMESTRE ) " +
                                                "VALUES " +
                                                        "(" + asistencia.AS_PER_ID + ", " +
                                                        " '" + asistencia.AS_FECHA + "'," +
                                                        " " + asistencia.AS_SAL_ID + ", " +
                                                        " " + asistencia.AS_ANO + ", " +
                                                        "'" + asistencia.AS_ASISTENCIA + "', " +
                                                        "'" + asistencia.AS_JUSTIFICADO + "', " +
                                                        " " + asistencia.AS_SEMESTRE + ")", con);
                
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                
            }
        }

        public void EditarAsistencia(entAsistencia asistencia)
        {
            con = generarConexion();

            string justificado;

            if(asistencia.AS_ASISTENCIA == "0")
            {
                justificado = null;
            }
            else
            {
                justificado = asistencia.AS_JUSTIFICADO;
            }

            try
            {

                con.Open();
                
                cmd = new SqlCommand("UPDATE T_ASISTENCIA SET " +
                                                            "AS_ASISTENCIA = " + "'" + asistencia.AS_ASISTENCIA + "', " +
                                                            " AS_JUSTIFICADO = " + "'" + justificado + "' " +
                                                "WHERE AS_ID = "+ asistencia.AS_ID + ";", con);

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                
            }
        }

        public string infoAusencias(string sala, string fecha)
        {
            string resultado = "";
            con = generarConexion();        
            con.Open();

            string consulta = "WITH T1 AS " +
                                        "(SELECT COUNT(*) TOTAL_ALUMNOS, " +
                                                "0 PRESENTES," +
                                                "0 AUSENTES_JUSTIFICADOS," +
                                                "0 AUSENTES_INJUSTIFICADOS " +
                                          "FROM T_GRUPO_SALA, T_PERSONAS " +
                                         "WHERE PER_ID = GRS_PER_ID " +
                                           "AND PER_TPE_ID = 2 " +
                                           "AND GRS_SAL_ID = '" + sala + "' " +
                                         "UNION " +
                                         "SELECT 0, " +
                                                "COUNT(AS_ASISTENCIA), " +
                                                "0, " +
                                                "0 " +
                                          "FROM T_ASISTENCIA " +
                                         "WHERE AS_FECHA = CONVERT(VARCHAR(10), '" + fecha + "', 103) " +
                                           "AND AS_ASISTENCIA = 0 " +
                                           "AND AS_SAL_ID = '" + sala + "' " +
                                        "UNION " +
                                        "SELECT 0," +
                                               "0," +
                                               "COUNT(AS_ASISTENCIA), " +
                                               "0 " +
                                         "FROM T_ASISTENCIA " +
                                        "WHERE AS_FECHA = CONVERT(VARCHAR(10), '" + fecha + "', 103) " +
                                          "AND AS_ASISTENCIA = 1 " +
                                          "AND AS_JUSTIFICADO = 0 " +
                                          "AND AS_SAL_ID = '" + sala + "'" +
                                       "UNION " +
                                       "SELECT 0," +
                                              "0," +
                                              "0, " +
                                              "COUNT(AS_ASISTENCIA) " +
                                       "FROM T_ASISTENCIA " +
                                       "WHERE AS_FECHA = CONVERT(VARCHAR(10), '" + fecha + "', 103) " +
                                       "AND AS_ASISTENCIA = 1 " +
                                       "AND AS_JUSTIFICADO = 1 " +
                                       "AND AS_SAL_ID = '" + sala + "')" +
                               "SELECT SUM(TOTAL_ALUMNOS) TOTAL_ALUMNOS, " +
                                      "SUM(PRESENTES) PRESENTES, " +
                                      "SUM(AUSENTES_JUSTIFICADOS) AUSENTES_JUSTIFICADOS," +
                                      "SUM(AUSENTES_INJUSTIFICADOS) AUSENTES_INJUSTIFICADOS " +
                                      "FROM T1;";
            
            cmd = new SqlCommand(consulta, con);

            
                dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {

                    resultado = "TOTAL DE ALUMNOS: " + dr["TOTAL_ALUMNOS"].ToString() + " - TOTAL PRESENTES: " + dr["PRESENTES"].ToString() + " - TOTAL AUSENCIAS JUSTIFICADAS: " + dr["AUSENTES_JUSTIFICADOS"].ToString() + " - TOTAL AUSENCIAS INJUSTIFICADAS: " + dr["AUSENTES_INJUSTIFICADOS"].ToString();
                }
                else
                {
                resultado = "No se visualizan registros de asistencias";
                }                           

            return resultado;
        }

    }
}
