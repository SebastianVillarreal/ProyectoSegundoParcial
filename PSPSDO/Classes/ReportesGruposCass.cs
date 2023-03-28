using PSPSDO.BD;
using PSPSDO.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPSDO.Classes
{
    internal class ReportesGruposCass
    {
        public DataSet GetRepGrupos(int parcial, string grupo)
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pIdParcial", SqlDbType = System.Data.SqlDbType.Int, Value = parcial });
            parametros.Add(new SqlParameter { ParameterName = "@pGrupo", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupo });
            DataSet ds = bd.Fill("SP_ReportesGrupos", parametros);
            return ds;
        }

        public string ReporteGrupo(ReportesGruposModel reporte)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();

                parametros.Add(new SqlParameter { ParameterName = "@pIdParcial", SqlDbType = System.Data.SqlDbType.Int, Value = reporte.Parcial });
                parametros.Add(new SqlParameter { ParameterName = "@pGrupo", SqlDbType = System.Data.SqlDbType.VarChar, Value = reporte.Grupo });

                bd.ExecuteNonQuery("SP_ReportesGrupos", parametros);
                return "Reporte realizado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
