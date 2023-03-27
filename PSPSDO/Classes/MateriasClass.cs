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
    public class MateriasClass
    {
        public string InsertMateria(MateriasModel Materia)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pClave", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Clave });
                parametros.Add(new SqlParameter { ParameterName = "@pUsuario", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Usuario });
                parametros.Add(new SqlParameter { ParameterName = "@pFechaUltAct", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Fecha });
                bd.ExecuteNonQuery("SP_InsertMaterias", parametros);
                return "Inserción correcta";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateMateria(MateriasModel Materia)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Id });
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pClave", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Clave });
                parametros.Add(new SqlParameter { ParameterName = "@pUsuario", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Usuario });
                bd.ExecuteNonQuery("SP_UpdateMteria", parametros);
                return "Actualizacion correcta";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public string DeleteMateria(MateriasModel Materia)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = Materia.Id });
                bd.ExecuteNonQuery("sp_DeleteMaterias", parametros);
                return "Eliminacion correcta";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public DataSet GetMaterias()
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
                DataSet ds = bd.Fill("sp_GetMateria", parametros);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataSet BuscarMaterias(string Busqueda)
        {
            BDContext bd = new BDContext();
            ArrayList parametros = new ArrayList();
            parametros.Add(new SqlParameter { ParameterName = "@pDatosBuscados", SqlDbType = SqlDbType.VarChar, Value = Busqueda });
            DataSet ds = bd.Fill("SP_SearchMateria", parametros);
            return ds;
        }
    }
}
