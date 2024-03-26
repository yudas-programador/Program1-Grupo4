using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Databaseconnection;

namespace CapaNegocio.Acciones
{
    public class AccionSeguridad : Accionesdatabase
    {


        /// Authentication
     public bool AuthenticationUsers(string usuario, string clave)
        {
            bool _access = false;

            try
            {
                var validate = dbturicontext.TM_Usuario
                    .FirstOrDefault(x => x.PasswordUser == clave & x.UserName == usuario);
                
                _access = (validate != null) ? true : false;   
                
            }
            catch
            {
                return false;
            }


            return _access;   

        }


        public string GetProfileUsers(string nomUSERS)
        {
            string perfil = string.Empty;

            try
            {
                perfil = dbturicontext.vw_Usuarios.FirstOrDefault(x => 
                x.nomUsuario == nomUSERS).perfilusuario;


            }
            catch
            {
                return string.Empty;
            }

            return perfil;
        }




        public List<TM_Usuario> GetUsers() 
        {
        return dbturicontext.TM_Usuario.ToList();
        }
    }
}
