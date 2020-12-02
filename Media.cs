using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RedSocial.Models
{
    public class Media
    {
        [DisplayName("Identificación")]
        public int IdMedia { get; set; }
        [DisplayName("Nombre del Archivo")]
        public string NombreFoto { get; set; }
        [DisplayName("URL")]
        public string ArchivoURL { get; set; }
        [DisplayName("Nombre de la Foto")]
        public string NomArchivoFoto { get; set; }
        [DisplayName("Detalle de Media")]
        public string DetalleFoto { get; set; }
        [DisplayName("Id Usuario")]
        public int IdUsuario { get; set; }
    }
}