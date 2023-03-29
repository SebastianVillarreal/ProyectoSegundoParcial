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
    internal class frmReportesAlumnosClass
    {
        internal class ReportesAlumnosClass
        {
            public DataSet GetRepAlumnos(int matricula)
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pMatricula", SqlDbType = System.Data.SqlDbType.Int, Value = matricula });
                DataSet ds = bd.Fill("SP_ReportesAlumnos", parametros);
                return ds;
            }

            public string ReporteAlumnos(ReportesAlumnosModel reporte)
            {
                try
                {
                    ArrayList parametros = new ArrayList();
                    BDContext bd = new BDContext();

                    parametros.Add(new SqlParameter { ParameterName = "@pMatricula", SqlDbType = System.Data.SqlDbType.Int, Value = reporte.Matricula });

                    bd.ExecuteNonQuery("SP_ReportesAlumnos", parametros);
                    return "Reporte realizado correctamente";
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
            }
        }
    }
}
