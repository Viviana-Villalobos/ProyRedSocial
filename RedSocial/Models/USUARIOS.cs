using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSocial.Models
{
    public class USUARIOS
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public int TelefonoUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string PassUsuario { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public int Rol_ID { get; set; }

    }
}