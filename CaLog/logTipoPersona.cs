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
    public class logTipoPersona
    {

        metTipoPersona objMetTipoPersona = new metTipoPersona();

        public DataTable ListarTipoPersona()
        {
            
            return objMetTipoPersona.ListarTipoPersona();
        }

        public entTipoPersona.enTipoPersonaColeccion buscarTipoPersonas()
        {
            
            return objMetTipoPersona.buscarTipoPersonas();

        }

    }
}
