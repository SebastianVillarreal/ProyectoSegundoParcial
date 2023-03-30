using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPSDO.Models
{
    public  class MateriasModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }
        public int IdCarrera { get; set; }
    }
}
