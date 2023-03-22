using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSPSDO.BD;
using PSPSDO.Models;
using System.Data.SqlClient;
using System.Data;

namespace PSPSDO.Classes
{
    public class CalificacionesClass
    {
        public string InsertCalificaciones(CalificacionesModel calificaciones)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pIdMateria", SqlDbType = System.Data.SqlDbType.VarChar, Value = calificaciones.IdMateria });
                parametros.Add(new SqlParameter { ParameterName = "@pIdAlumno", SqlDbType = System.Data.SqlDbType.VarChar, Value =  calificaciones.IdAlumno});
                parametros.Add(new SqlParameter { ParameterName = "@pParcial", SqlDbType = System.Data.SqlDbType.VarChar, Value = calificaciones.IdParcial});
                parametros.Add(new SqlParameter { ParameterName = "@pCalificacion", SqlDbType = System.Data.SqlDbType.VarChar, Value = calificaciones.Calificacion });
                bd.ExecuteNonQuery("SP_InsertCalificaciones", parametros);
                return "Calificacion Guardada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
