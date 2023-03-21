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
    public class AlumnosClass
    {
        public string InsertAlumnos(AlumnosModel Alumnos)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();

                parametros.Add(new SqlParameter { ParameterName = "@pMatricula", SqlDbType = System.Data.SqlDbType.Int, Value = Alumnos.Matricula });
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pApPaterno", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.ApellidoPaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pApMaterno", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.ApellidoMaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pDirección", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.Direccion });
                parametros.Add(new SqlParameter { ParameterName = "@pIdGrupo", SqlDbType = System.Data.SqlDbType.Int, Value = Alumnos.IdGrupo });

                bd.ExecuteNonQuery("SP_InsertAlumnos", parametros);
                return "Inserción correcta";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataSet GetAlumnos()
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.Int, Value = 1 });
            DataSet ds = bd.Fill("SP_SelectAlumnos", parametros);
            return ds;
        }

        public string ActualizarAlumnos(AlumnosModel Alumnos)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();

                parametros.Add(new SqlParameter { ParameterName = "@Id", SqlDbType = System.Data.SqlDbType.Int, Value = Alumnos.Id });
                parametros.Add(new SqlParameter { ParameterName = "@pMatricula", SqlDbType = System.Data.SqlDbType.Int, Value = Alumnos.Matricula });
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pApPaterno", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.ApellidoPaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pApMaterno", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.ApellidoMaterno });
                parametros.Add(new SqlParameter { ParameterName = "@pDirección", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.Direccion });
                parametros.Add(new SqlParameter { ParameterName = "@pIdGrupo", SqlDbType = System.Data.SqlDbType.Int, Value = Alumnos.IdGrupo });

                bd.ExecuteNonQuery("SP_UpdateAlumnos", parametros);
                return "Actualización correcta";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        public string DeleteAlumnos(AlumnosModel Alumnos)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();

                parametros.Add(new SqlParameter { ParameterName = "@Id", SqlDbType = System.Data.SqlDbType.VarChar, Value = Alumnos.Id });

                bd.ExecuteNonQuery("SP_DeleteAlumnos", parametros);
                return "Eliminación correcta";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
