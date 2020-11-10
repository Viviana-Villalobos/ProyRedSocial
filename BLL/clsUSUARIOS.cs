using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class clsUSUARIOS
    {

        public List<ConsultarUSUARIOSResult> ConsultarUSUARIOS()
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                List<ConsultarUSUARIOSResult> datos = db.ConsultarUSUARIOS().ToList();
                return datos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ConsultaUSUARIOSResult ConsultaUSUARIOS(int UsuarioID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                ConsultaUSUARIOSResult datos = db.ConsultaUSUARIOS(UsuarioID).FirstOrDefault();
                return datos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool EliminaUSUARIOS(int UsuarioID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.EliminarUSUARIOS(UsuarioID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool ActualizaUSUARIOS(int UsuarioID, string NombreUsuario, string ApellidoUsuario, int TelefonoUsuario, string CorreoUsuario, DateTime FechaNacimiento, string Genero, string PassUsuario, DateTime Fecha_Registro, int Rol_ID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.ActualizarUSUARIOS(UsuarioID, NombreUsuario, ApellidoUsuario, TelefonoUsuario, CorreoUsuario, FechaNacimiento, Genero, PassUsuario, Fecha_Registro, Rol_ID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool CreaUSUARIOS(string NombreUsuario, string ApellidoUsuario, int TelefonoUsuario, string CorreoUsuario, DateTime FechaNacimiento, string Genero, string PassUsuario, DateTime Fecha_Registro, int Rol_ID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.CrearUSUARIOS(NombreUsuario, ApellidoUsuario, TelefonoUsuario, CorreoUsuario, FechaNacimiento, Genero, PassUsuario, Fecha_Registro, Rol_ID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }


    }
}
