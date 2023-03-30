using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPSDO.Models
{
    public class AlumnosModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Matricula { get; set; }
        public string Direccion { get; set; }
        public int IdGrupo { get; set; }
    }
}
