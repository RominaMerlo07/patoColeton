using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CaAD;
using CaEnt;

namespace CaLog
{
    public class logDomicilio
    {
        metDomicilio objMetDomicilio = new metDomicilio();

        public string Insertar(entDomicilio domicilio)
        {

            return objMetDomicilio.Insertar(domicilio);

        }

        public entDomicilio buscarDomicilioXPersona(Int32 idPersona)
        {

            return objMetDomicilio.buscarDomicilioXPersona(idPersona);

        }

        public string editarDomicilio(entDomicilio domicilioEditar)
        {

            return objMetDomicilio.editarDomicilio(domicilioEditar);

        }

    }
}
