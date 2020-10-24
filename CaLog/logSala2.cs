using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CaAD;
using CaEnt;


namespace CaLog
{
    public class logSala2
    {
        metSala2 objMetSala2 = new metSala2();

        public DataTable GrillaSalas()
        {            

            return objMetSala2.GrillaSalas();

        }

        public DataTable FiltrarSala(string sala, string turno)
        {
            
            return objMetSala2.FiltrarSala(sala, turno);
        }


        public DataTable BuscarSala()
        {            

            return objMetSala2.BuscarSala();
        }

        public string InsertarSala(entSala sala)
        {            

            return objMetSala2.InsertarSala(sala);
        }

        public entSala buscarSalaXid(Int32 idSala)
        {           

            return objMetSala2.buscarSalaXid(idSala);

        }

        public string EditarSala(entSala sala)
        {           

            return objMetSala2.EditarSala(sala);
        }

        public string EliminarSala(entSala sala)
        {
            
            return objMetSala2.EliminarSala(sala);
        }

        public string ValidarSala(string nombre, string turno)
        {           

            return objMetSala2.ValidarSala(nombre, turno);

        }
    }
}
