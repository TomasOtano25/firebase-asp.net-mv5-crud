using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDFIREBASE.Models;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Newtonsoft.Json;


namespace BDFIREBASE.Controllers
{
    public class MantenedorController : Controller
    {
        IFirebaseClient cliente;

        public MantenedorController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "rmmocgBMPsU0G2IwU6EXOUpiVPLEP4U3FAFP4P71",
                BasePath = "https://bdfirebase-net-mvc-5-default-rtdb.firebaseio.com/"
            };


            cliente = new FirebaseClient(config);
        }

        public ActionResult Inicio()
        {
            return View();
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Contacto oContacto)
        {
            string IdGenerado = Guid.NewGuid().ToString("N");

            SetResponse response = cliente.Set("contactos/" + IdGenerado, oContacto);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return View();
            } 
            else 
            { 
                return View(); 
            }
        }
    }
}