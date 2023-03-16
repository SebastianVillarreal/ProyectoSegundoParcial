using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSPSDO.BD;
using System.Web;

namespace PSPSDO.Classes
{
    public class CarreraClass
    {
        public void show(DataGridView dgvCarreras)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pEstatus", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
                DataSet ds = bd.Fill("sp_GetCarrera", parametros);
                dgvCarreras.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("error inesperado: " + ex.Message);
            }
        }
        public void add(DataGridView dgvCarreras, string Nombre, string Clave, string Descripcion)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pClave", SqlDbType = System.Data.SqlDbType.VarChar, Value = Clave });
                parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = System.Data.SqlDbType.VarChar, Value = Nombre });
                parametros.Add(new SqlParameter { ParameterName = "@pDescripcion", SqlDbType = System.Data.SqlDbType.VarChar, Value = Descripcion });
                parametros.Add(new SqlParameter { ParameterName = "@pUltimoUsuario", SqlDbType = System.Data.SqlDbType.VarChar, Value = 9999 });
                bd.ExecuteNonQuery("sp_SetCarrera", parametros);


                CarreraClass Opciones = new CarreraClass();
                Opciones.show(dgvCarreras);

                MessageBox.Show("Registro completado");
            }


            catch (Exception ex)
            {
                MessageBox.Show("error inesperado: " + ex.Message);
            }
        }
        public void delete(DataGridView dgvCarreras, int ID)
        {
            try
            {
                ArrayList parametros = new ArrayList();
                BDContext bd = new BDContext();
                parametros.Add(new SqlParameter { ParameterName = "@pID", SqlDbType = System.Data.SqlDbType.VarChar, Value = ID });
                bd.ExecuteNonQuery("SP_DeleteCarreras", parametros);
                CarreraClass Opciones = new CarreraClass();
                Opciones.show(dgvCarreras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error inesperado: " + ex.Message);
            }

        }
        public void edit(DataGridView dgvCarreras, int id, string Clave, string Nombre, string Descripcion)
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = id });
            parametros.Add(new SqlParameter { ParameterName = "@pClave", SqlDbType = System.Data.SqlDbType.VarChar, Value = Clave });
            parametros.Add(new SqlParameter { ParameterName = "@pNombre", SqlDbType = System.Data.SqlDbType.VarChar, Value = Nombre });
            parametros.Add(new SqlParameter { ParameterName = "@pDescripcion", SqlDbType = System.Data.SqlDbType.VarChar, Value = Descripcion });
            parametros.Add(new SqlParameter { ParameterName = "@pUltimoUsuario", SqlDbType = System.Data.SqlDbType.VarChar, Value = 9999 });
            bd.ExecuteNonQuery("SP_UpdateCarreras", parametros);
            CarreraClass Opciones = new CarreraClass();
            Opciones.show(dgvCarreras);
        }
    }
}