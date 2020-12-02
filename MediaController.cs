using BLL;
using DAL;
using RedSocial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedSocial.Controllers
{
    public class MediaController : Controller
    {
         clsMedia ObjMedia = new clsMedia();
        // GET: Media
        public ActionResult Index()
        {
            try
            {
                var datos = ObjMedia.ConsultarMedia();

                List<Media> ListaMedia = new List<Media>();

                foreach (var item in datos)
                {
                    Media medi = new Media();

                    medi.IdMedia = item.IdMedia;
                    medi.NombreFoto = item.NombreFoto;
                    medi.ArchivoURL = item.ArchivoURL;
                    medi.NomArchivoFoto = item.NomArchivoFoto;
                    medi.DetalleFoto = item.DetalleFoto;
                    medi.IdUsuario = item.IdUsuario;
                 

                    ListaMedia.Add(medi);
                }
                return View(ListaMedia);
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
                var dato = ObjMedia.ConsultaMedia(id);

                Media medi = new Media();

                medi.IdMedia = dato.IdMedia;
                medi.NombreFoto = dato.NombreFoto;
                medi.ArchivoURL = dato.ArchivoURL;
                medi.NomArchivoFoto = dato.NomArchivoFoto;
                medi.DetalleFoto = dato.DetalleFoto;
                medi.IdUsuario = dato.IdUsuario;
                

                return View(medi);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Editar(Media medi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ObjMedia.ActualizaMedia(medi.IdMedia, medi.NombreFoto, medi.ArchivoURL, medi.NomArchivoFoto, medi.DetalleFoto, medi.IdUsuario))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(medi);
                    }
                }
                else
                {
                    return View(medi);
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
                var dato = ObjMedia.ConsultaMedia(id);

                Media medi = new Media();

                medi.IdMedia = dato.IdMedia;
                medi.NombreFoto = dato.NombreFoto;
                medi.ArchivoURL = dato.ArchivoURL;
                medi.NomArchivoFoto = dato.NomArchivoFoto;
                medi.DetalleFoto = dato.DetalleFoto;
                medi.IdUsuario = dato.IdUsuario;
               

                return View(medi);
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
        public ActionResult Crear(Media medi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ObjMedia.CreaMedia(medi.NombreFoto, medi.ArchivoURL, medi.NomArchivoFoto, medi.DetalleFoto,medi.IdUsuario))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(medi);
                    }
                }
                else
                {
                    return View(medi);
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
                var dato = ObjMedia.ConsultaMedia(id);

                Media medi = new Media();

                medi.IdMedia = dato.IdMedia;
                medi.NombreFoto = dato.NombreFoto;
                medi.ArchivoURL = dato.ArchivoURL;
                medi.NomArchivoFoto = dato.NomArchivoFoto;
                medi.DetalleFoto = dato.DetalleFoto;
                medi.IdUsuario = dato.IdUsuario;
               


                return View(medi);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Eliminar(Media medi)
        {
            try
            {

                if (ObjMedia.EliminaMedia(medi.IdMedia))
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