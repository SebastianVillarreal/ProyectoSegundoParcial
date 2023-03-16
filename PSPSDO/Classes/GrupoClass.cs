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
    class GrupoClass
    {
        public string InsertarGrupo(GrupoModels grupos)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pClave", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupos.Clave });
                parametros.Add(new SqlParameter { ParameterName = "@pDescripcion", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupos.Descripcion });
                parametros.Add(new SqlParameter { ParameterName = "@pUsuarioUltMod", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupos.UsuarioUltima });
                bd.ExecuteNonQuery("sp_InsertGrupos", parametros);
                return "Inserción correcta";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }


        public DataSet GetGrupos()
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            DataSet ds = bd.Fill("sp_SelectGrupos", parametros);
            return ds;



        }

        public string ActualizarGrupos(GrupoModels grupo)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();

                parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupo.Id });
                parametros.Add(new SqlParameter { ParameterName = "@pClave", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupo.Clave });
                parametros.Add(new SqlParameter { ParameterName = "@pDescripcion", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupo.Descripcion });
                parametros.Add(new SqlParameter { ParameterName = "@pUsuarioUltMod", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupo.UsuarioUltima });
                bd.ExecuteNonQuery("sp_UpdateGrupos", parametros);
                return "Actualizacion correcta";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }

        public string BorrarGrupos(GrupoModels grupo)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();

                parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = grupo.Id });
                bd.ExecuteNonQuery("sp_DeleteGrupos", parametros);
                return "Eliminación correcta";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
    }
}
