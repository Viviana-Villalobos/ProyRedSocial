using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using RedSocial.Models;

namespace RedSocial.Controllers
{
    public class ComentariosController : Controller
    {
        clsCOMENTARIOS ObjCOMENTARIOS = new clsCOMENTARIOS();
        // GET: COMENTARIOS
        public ActionResult Index()
        {
            try
            {
                var datos = ObjCOMENTARIOS.ConsultarCOMENTARIOS();

                List<COMENTARIOS> ListaCOMENTARIOS = new List<COMENTARIOS>();

                foreach (var item in datos)
                {
                    COMENTARIOS comentario = new COMENTARIOS();

                    comentario.ComentarioID = item.ComentarioID;
                    comentario.Comentario = item.Comentario;
                    comentario.FechaEnviado = item.FechaEnviado;
                    comentario.Usuario_ID = item.Usuario_ID;
                    comentario.Reaccion_ID = item.Reaccion_ID;
        
                    ListaCOMENTARIOS.Add(comentario);
                }
                return View(ListaCOMENTARIOS);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        public ActionResult Editar(int id)
        {
            try
            {
                var dato = ObjCOMENTARIOS.ConsultaCOMENTARIOS(id);

                COMENTARIOS comentario = new COMENTARIOS();

                comentario.ComentarioID = dato.ComentarioID;
                comentario.Comentario = dato.Comentario;
                comentario.FechaEnviado = dato.FechaEnviado;
                comentario.Usuario_ID = dato.Usuario_ID;
                comentario.Reaccion_ID = dato.Reaccion_ID;

                return View(comentario);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Editar(COMENTARIOS comentario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ObjCOMENTARIOS.ActualizaCOMENTARIOS(comentario.ComentarioID, comentario.Comentario, comentario.FechaEnviado, comentario.Usuario_ID, comentario.Reaccion_ID))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(comentario);
                    }
                }
                else
                {
                    return View(comentario);
                }
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        public ActionResult Detalles(int id)
        {
            try
            {
                var dato = ObjCOMENTARIOS.ConsultaCOMENTARIOS(id);

                COMENTARIOS comentario = new COMENTARIOS();

                comentario.ComentarioID = dato.ComentarioID;
                comentario.Comentario = dato.Comentario;
                comentario.FechaEnviado = dato.FechaEnviado;
                comentario.Usuario_ID = dato.Usuario_ID;
                comentario.Reaccion_ID = dato.Reaccion_ID;

                return View(comentario);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }

        public ActionResult Crear()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Crear(COMENTARIOS comentario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ObjCOMENTARIOS.CreaCOMENTARIOS(comentario.Comentario, comentario.FechaEnviado, comentario.Usuario_ID, comentario.Reaccion_ID))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(comentario);
                    }
                }
                else
                {
                    return View(comentario);
                }
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar la orden");
            }
        }
        public ActionResult Eliminar(int id)
        {
            try
            {
                var dato = ObjCOMENTARIOS.ConsultaCOMENTARIOS(id);

                COMENTARIOS comentario = new COMENTARIOS();

                comentario.ComentarioID = dato.ComentarioID;
                comentario.Comentario = dato.Comentario;
                comentario.FechaEnviado = dato.FechaEnviado;
                comentario.Usuario_ID = dato.Usuario_ID;
                comentario.Reaccion_ID = dato.Reaccion_ID;

                return View(comentario);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Eliminar(COMENTARIOS comentario)
        {
            try
            {

                if (ObjCOMENTARIOS.EliminaCOMENTARIOS(comentario.ComentarioID))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }

    }
}