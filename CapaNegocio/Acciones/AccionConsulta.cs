﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Databaseconnection;
using System.Runtime.Remoting.Messaging;



namespace CapaNegocio.Acciones
{
    public class AccionConsulta : Accionesdatabase
    {
        #region Listados Genericos
        public List<TM_Proveedores> Listcategory() 
        {
            return dbturicontext.TM_Proveedores.ToList();
        }
        public List<TM_Paquete> Listpaquete()
        {
            return dbturicontext.TM_Paquete.ToList();
        }
        public List<TM_Cliente> Listcliente()
        {
            return dbturicontext.TM_Cliente.ToList();
        }
        public List<TM_Tours> Listtours ()
        {
            return dbturicontext .TM_Tours.ToList();
        }
        #endregion

        #region filtros relacionales 

        public List <TM_Proveedores> _getListProvedoresType(int typeID)
        {
            return dbturicontext.TM_Proveedores.Where(x => x.ID_Proveedor == typeID).ToList();
        }



        #endregion
    }
}
