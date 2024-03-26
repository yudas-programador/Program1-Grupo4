using CapaNegocio.Acciones;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using Turismoapp.Models;

namespace Turismoapp.Controllers
{
    public class SeguridadController : Controller
    {
        public AccionSeguridad  accionSeguridad = new AccionSeguridad();



        // GET: Seguridad
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult btniniciarseccion(UserInput userInput)
        {
            string vista = string.Empty;
            if (accionSeguridad.AuthenticationUsers(userInput.Usuario, userInput.Clave))
            {
                /// Paso2: validar sus vistas permitidas
                vista = accionSeguridad.GetProfileUsers(userInput.Usuario);
            }
            else 
            {
                ///Paso3: retornar un mensaje de error
                return Json("Usuario y/o Contrasena Incorrecto");

            }

            return View(vista);
        }

        public ActionResult Registro()
        {
            return View();
        }

    }
}