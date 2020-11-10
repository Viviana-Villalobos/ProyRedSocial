using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
using RedSocial.Models;

namespace RedSocial.Controllers
{
    public class UsuarioController : Controller
    {
        clsUSUARIOS ObjUSUARIOS = new clsUSUARIOS();
        clsRol objROL = new BLL.clsRol();
        // GET: USUARIOS
        public ActionResult Index()
        {
            try
            {
                var datos = ObjUSUARIOS.ConsultarUSUARIOS();

                List<USUARIOS> ListaUSUARIOS = new List<USUARIOS>();

                foreach (var item in datos)
                {
                    USUARIOS usuario = new USUARIOS();

                    usuario.UsuarioID = item.UsuarioID;
                    usuario.NombreUsuario = item.NombreUsuario;
                    usuario.ApellidoUsuario = item.ApellidoUsuario;
                    usuario.TelefonoUsuario = item.TelefonoUsuario;
                    usuario.CorreoUsuario = item.CorreoUsuario;
                    usuario.FechaNacimiento = item.FechaNacimiento;
                    usuario.Genero = item.Genero;
                    usuario.PassUsuario = item.PassUsuario;
                    usuario.Fecha_Registro = item.Fecha_Registro;
                    usuario.Rol_ID = item.Rol_ID;
              

                    ListaUSUARIOS.Add(usuario);

                  
                }
                return View(ListaUSUARIOS);
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
                var dato = ObjUSUARIOS.ConsultaUSUARIOS(id);

                USUARIOS usuario = new USUARIOS();

                usuario.UsuarioID = dato.UsuarioID;
                usuario.NombreUsuario = dato.NombreUsuario;
                usuario.ApellidoUsuario = dato.ApellidoUsuario;
                usuario.TelefonoUsuario = dato.TelefonoUsuario;
                usuario.CorreoUsuario = dato.CorreoUsuario;
                usuario.FechaNacimiento = dato.FechaNacimiento;
                usuario.Genero = dato.Genero;
                usuario.PassUsuario = dato.PassUsuario;
                usuario.Fecha_Registro = dato.Fecha_Registro;
                usuario.Rol_ID = dato.Rol_ID;

                ViewBag.Roles = objROL.ConsultarROL();

                return View(usuario);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Editar(USUARIOS usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ObjUSUARIOS.ActualizaUSUARIOS(usuario.UsuarioID, usuario.NombreUsuario, usuario.ApellidoUsuario, usuario.TelefonoUsuario, usuario.CorreoUsuario, usuario.FechaNacimiento, usuario.Genero, usuario.PassUsuario, usuario.Fecha_Registro, usuario.Rol_ID))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(usuario);
                    }
                }
                else
                {
                    return View(usuario);
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
                var dato = ObjUSUARIOS.ConsultaUSUARIOS(id);

                USUARIOS usuario = new USUARIOS();

                usuario.UsuarioID = dato.UsuarioID;
                usuario.NombreUsuario = dato.NombreUsuario;
                usuario.ApellidoUsuario = dato.ApellidoUsuario;
                usuario.TelefonoUsuario = dato.TelefonoUsuario;
                usuario.CorreoUsuario = dato.CorreoUsuario;
                usuario.FechaNacimiento = dato.FechaNacimiento;
                usuario.Genero = dato.Genero;
                usuario.PassUsuario = dato.PassUsuario;
                usuario.Fecha_Registro = dato.Fecha_Registro;
                usuario.Rol_ID = dato.Rol_ID;

                return View(usuario);
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
                ViewBag.Roles = objROL.ConsultarROL();
                return View();
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Crear(USUARIOS usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ObjUSUARIOS.CreaUSUARIOS(usuario.NombreUsuario, usuario.ApellidoUsuario, usuario.TelefonoUsuario, usuario.CorreoUsuario, usuario.FechaNacimiento, usuario.Genero, usuario.PassUsuario, usuario.Fecha_Registro, usuario.Rol_ID))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(usuario);
                    }
                }
                else
                {
                    return View(usuario);
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
                var dato = ObjUSUARIOS.ConsultaUSUARIOS(id);

                USUARIOS usuario = new USUARIOS();

                usuario.UsuarioID = dato.UsuarioID;
                usuario.NombreUsuario = dato.NombreUsuario;
                usuario.ApellidoUsuario = dato.ApellidoUsuario;
                usuario.TelefonoUsuario = dato.TelefonoUsuario;
                usuario.CorreoUsuario = dato.CorreoUsuario;
                usuario.FechaNacimiento = dato.FechaNacimiento;
                usuario.Genero = dato.Genero;
                usuario.PassUsuario = dato.PassUsuario;
                usuario.Fecha_Registro = dato.Fecha_Registro;
                usuario.Rol_ID = dato.Rol_ID;


                return View(usuario);
            }
            catch (Exception ex)
            {
                return new HttpNotFoundResult("Error al consultar");
            }
        }
        [HttpPost]
        public ActionResult Eliminar(USUARIOS usuario)
        {
            try
            {

                if (ObjUSUARIOS.EliminaUSUARIOS(usuario.UsuarioID))
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