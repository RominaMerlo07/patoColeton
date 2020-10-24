﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CaAD;
using CaEnt;
using System.Data.SqlClient;

namespace CaLog
{
    public class logPersonas
    {

        metPersonas objMetPersonas = new metPersonas();

        public SqlDataReader traerPersonasAutocompetar(string tipo_persona) //FILTRA POR TIPO DE PERSONA. "0" TRAE TODOS. 
        {
            
            return objMetPersonas.traerPersonasAutocompetar(tipo_persona);

        }


        //public string Autocompletar_Alumno(MetroFramework.Controls.MetroTextBox pbarrabuscar)
        //{           

        //    return objMetPersonas.Autocompletar_Alumno(pbarrabuscar);

        //}

        public DataTable TraerAlumnos()
        //public entPersona BuscaAlumnos(string nombre, string apellido, string documento)
        {

            return objMetPersonas.TraerAlumnos();

        }


        public entPersona BuscaPersonaxID(string idPersona)
        {

            return objMetPersonas.BuscaPersonaxID(idPersona);

        }


        /*****************************************************************/
        /************ METODOS COMUNES PARA TODAS LAS PERSONAS ************/
        /*****************************************************************/

        /************************************************* INSERTAR UNA PERSONA ***************************************************/

        public string Insertar(entPersona persona)
        {

            return objMetPersonas.Insertar(persona);
        }


        /************************************************* EDITAR UNA PERSONA ***************************************************/

        public string editarPersona(entPersona personaEditar)
        {

            return objMetPersonas.editarPersona(personaEditar);
        }

        // Devuelve la entidad persona luego de buscar una persona, el de docente tiene su propio metodo

        public entPersona BuscaPersona(string nombre, string apellido, string documento)
        {

            return objMetPersonas.BuscaPersona(nombre, apellido, documento);

        }

        // Valida que el dni no se encuentre repetido

        public string ValidarDni(string pDNI)
        {            

            return objMetPersonas.ValidarDni(pDNI);

        }

        // Valida que EL MAIL sea ingresado con su estructura correcta

        public bool ValidarEmail(String pEmail)
        {
            return objMetPersonas.ValidarEmail(pEmail);

        }


        public string extraerapellido_nombre_alumno(String pbarrabuscar)
        {
            {
                string alumno = pbarrabuscar;
                char delimitador = (',');
                string[] apellido_nombre = alumno.Split(delimitador);
                return apellido_nombre[0];
            }

        }

        public string extraer_dni_alumno(String pbarrabuscar)
        {

            string alumno = pbarrabuscar;

            string[] dni_alumno = alumno.Split('(', ')');

            return dni_alumno[0];
            

        }



        /**************************************************/
        /******************** DOCENTES ********************/
        /**************************************************/

        //Muestra datos en la grilla de DOCENTES

        public DataTable Mostrardocente()
        {
            
            return objMetPersonas.Mostrardocente();
        }

        // UPDATEA EL ESTADO DEL DOCENTE

        public string EliminarDocente(entPersona eli_Docente)
        {
            
            return objMetPersonas.EliminarDocente(eli_Docente);

        }

        // ELIMINA EL DOCENTE DE LA GRUPO_SALAS

        public string EliminarDocenteGrupoSala(entPersona eli_Docente)//metodo que elimina docente, le coloca fecha de baja no elimina de la base 
        {
            
            return objMetPersonas.EliminarDocenteGrupoSala(eli_Docente);

        }

        //Llena el buscar de docentes

        public SqlDataReader traerdocente()
        {

            return objMetPersonas.traerdocente();

        }


        //Llena el cbo_salas en el form Docentes

        public DataTable Llenar_Combo_Salas(Int32 pcomboboxturno/*, MetroFramework.Controls.MetroComboBox pcomboboxsalas*/)
        {

            return objMetPersonas.Llenar_Combo_Salas(pcomboboxturno/*, pcomboboxsalas*/);
        }

        // Permite el filtro en en la grilla de docentes

        public DataTable llenarGrilla(string docente)
        {
            
            return objMetPersonas.llenarGrilla(docente);
        }

        //Metodo que devuelve la entidad Persona para un docente permitiendo pasar los datos de la grilla a los form editar y eliminar


        public entPersona BuscaDocente(string documento)
        {
 

            return objMetPersonas.BuscaDocente(documento);
        }


        // Validacion edad form docente agregar y editar

        public int EdadDocente(DateTime pfechaNacimiento)
        {

            return objMetPersonas.EdadDocente(pfechaNacimiento);

        }

        //Extrae dni Docente

        public string extraer_dni_docente(String pbarrabuscar)
        {

            string docente = pbarrabuscar;

            string[] dni_docente = docente.Split('(', ')');

            return dni_docente[0];
            
        }

        public string EliminarDocenteDomicilio(entPersona eli_Docente)//metodo que elimina docente en domicilio cuando ya existe un docente con sala y turno en la t_grupo_sala
        {

            return objMetPersonas.EliminarDocenteDomicilio(eli_Docente);

        }

        public string EliminarDocentePersona(entPersona eli_Docente)//metodo que elimina docente en persona cuando ya existe un docente con sala y turno en la t_grupo_sala
        {
            
            return objMetPersonas.EliminarDocentePersona(eli_Docente);

        }
    }
}
