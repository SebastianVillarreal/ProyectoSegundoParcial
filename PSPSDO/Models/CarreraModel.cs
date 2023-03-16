using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPSDO.Models
{
    internal class CarreraModel
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Estatus { get; set; }
        public int ultimoUsuario { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
