using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class clsCOMENTARIOS
    {
        public List<ConsultarCOMENTARIOSResult> ConsultarCOMENTARIOS()
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                List<ConsultarCOMENTARIOSResult> datos = db.ConsultarCOMENTARIOS().ToList();
                return datos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ConsultaCOMENTARIOSResult ConsultaCOMENTARIOS(int ComentarioID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                ConsultaCOMENTARIOSResult datos = db.ConsultaCOMENTARIOS(ComentarioID).FirstOrDefault();
                return datos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool EliminaCOMENTARIOS(int ComentarioID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.EliminarCOMENTARIOS(ComentarioID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool ActualizaCOMENTARIOS(int ComentarioID, string Comentario, DateTime FechaEnviado, int Usuario_ID, int Reaccion_ID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.ActualizarCOMENTARIOS(ComentarioID, Comentario, FechaEnviado, Usuario_ID, Reaccion_ID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool CreaCOMENTARIOS(string Comentario, DateTime FechaEnviado, int Usuario_ID, int Reaccion_ID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.CrearCOMENTARIOS(Comentario, FechaEnviado, Usuario_ID, Reaccion_ID);
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
