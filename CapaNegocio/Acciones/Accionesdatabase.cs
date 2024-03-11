using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Databaseconnection;
using System.Data;


namespace CapaNegocio
{
    public class Accionesdatabase
    {
        public DbTurismoentityDataContext dbturicontext = new DbTurismoentityDataContext ();
    }
}
