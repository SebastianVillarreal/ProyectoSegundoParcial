using PSPSDO.BD;
using PSPSDO.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPSDO.Classes
{
    internal class ReportesCarerrasClass
    {
        public DataSet GetRepCarreras(int parcial, string carrera)
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pIdParcial", SqlDbType = System.Data.SqlDbType.Int, Value = parcial });
            parametros.Add(new SqlParameter { ParameterName = "@pCarrera", SqlDbType = System.Data.SqlDbType.VarChar, Value =  carrera});
            DataSet ds = bd.Fill("SP_ReportesCarreras", parametros);
            return ds;
        }

        public string ReporteCarrera(ReportesCarrerasModel reporte)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();

                parametros.Add(new SqlParameter { ParameterName = "@pIdParcial", SqlDbType = System.Data.SqlDbType.Int, Value = reporte.Parcial });
                parametros.Add(new SqlParameter { ParameterName = "@pCarrera", SqlDbType = System.Data.SqlDbType.VarChar, Value = reporte.Carrera });

                bd.ExecuteNonQuery("SP_ReportesCarreras", parametros);
                return "Reporte realizado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
