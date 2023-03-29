using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPSDO.Models
{
    public class GrupoModels
    {
        public int Id { get; set; }

        public string Clave { get; set; }

        public string Descripcion { get; set; }

        public int Estatus { get; set; }

        public int UsuarioUltima { get; set; }

        public int FechaActualizacion { get; set; }

        public string ClaveGrupo { get;  set; }
    }
}
