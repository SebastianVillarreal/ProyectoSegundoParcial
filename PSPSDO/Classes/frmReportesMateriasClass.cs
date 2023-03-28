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
        internal class ReportesMateriasClass
        {
            public DataSet GetRepMaterias(string carrera)
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pCarrera", SqlDbType = System.Data.SqlDbType.VarChar, Value = carrera });
                DataSet ds = bd.Fill("SP_ReportesMaterias", parametros);
                return ds;
            }

            public string ReporteMaterias(ReportesMateriasModel reporte)
            {
                try
                {
                    ArrayList parametros = new ArrayList();
                    BDContext bd = new BDContext();

                    parametros.Add(new SqlParameter { ParameterName = "@pCarrera", SqlDbType = System.Data.SqlDbType.VarChar, Value = reporte.Carrera });
                DataSet ds = bd.Fill("SP_ReportesMaterias", parametros);
                    return "Reporte realizado correctamente";
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
            }
        }
    }