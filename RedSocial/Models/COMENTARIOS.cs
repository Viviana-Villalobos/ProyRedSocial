using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSocial.Models
{
    public class COMENTARIOS
    {
        public int ComentarioID { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaEnviado { get; set; }
        public int Usuario_ID { get; set; }
        public int Reaccion_ID { get; set; }

    }
}