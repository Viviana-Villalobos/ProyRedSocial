using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsRol
    {
        public List<ConsultarROLResult> ConsultarROL()
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                List<ConsultarROLResult> datos = db.ConsultarROL().ToList();
                return datos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ConsultaROLResult ConsultaROL(int RolID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                ConsultaROLResult datos = db.ConsultaROL(RolID).FirstOrDefault();
                return datos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool EliminaROL(int RolID)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.EliminarROL(RolID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool ActualizaROL(int RolID, string NombreRol)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.ActualizarROL(RolID, NombreRol);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool CreaROL(string NombreRol)
        {
            try
            {
                DatosDataContext db = new DatosDataContext();
                db.CrearROL(NombreRol);
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
