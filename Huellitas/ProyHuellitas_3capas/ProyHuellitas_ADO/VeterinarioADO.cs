using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyHuellitas_BE;

namespace ProyHuellitas_ADO
{
    public class VeterinarioADO
    {
        ConexionVeterinaria MiConexion = new ConexionVeterinaria();
        SqlConnection onx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        public DataTable ListarVeterinario()
        {
            DataSet dts = new DataSet();
            try
            {
                onx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = onx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarVeterinario";
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Veterinario");

            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Veterinario"];
        }

        public Boolean AgregarVeterinario (VeterinarioBE objVeterianrioBE)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "agregarVeterinario";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@tipo", SqlDbType.VarChar, 50));
                cmd.Parameters["@tipo"].Value = objVeterianrioBE._tipo;
                cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar, 50));
                cmd.Parameters["@numero"].Value = objVeterianrioBE._numero;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 50));
                cmd.Parameters["@nombre"].Value = objVeterianrioBE._nombre;
                cmd.Parameters.Add(new SqlParameter("@area", SqlDbType.VarChar, 50));
                cmd.Parameters["@area"].Value = objVeterianrioBE._area;
                onx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch(SqlException x)
            {
                blnexito = false;
            }
            finally
            {
                if(onx.State == ConnectionState.Open)
                {
                    onx.Close();
                }
                cmd.Parameters.Clear();
            }
            return blnexito;
        }


        public Boolean EliminarVeterinario (int strCod)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ElimnarVeterinario";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@IdVeterinario", SqlDbType.Int, 4));
                cmd.Parameters["@IdVeterinario"].Value = strCod;
                onx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
            }catch(SqlException x)
            {
                blnexito = false;
            }
            finally
            {
                if(onx.State == ConnectionState.Open)
                {
                    onx.Close();
                }
                cmd.Parameters.Clear();
            }
            return blnexito;
        }

        public Boolean ActualizarVeterinario (VeterinarioBE objVeterinarioBE)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarVeterinario";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@IdVeterinario", SqlDbType.Int, 4));
                cmd.Parameters["@IdVeterinario"].Value = objVeterinarioBE._idVeterianrio;
                cmd.Parameters.Add(new SqlParameter("@Dni", SqlDbType.VarChar, 50));
                cmd.Parameters["@Dni"].Value = objVeterinarioBE._tipo;
                cmd.Parameters.Add(new SqlParameter("@Ndocumento", SqlDbType.VarChar, 50));
                cmd.Parameters["@Ndocumento"].Value = objVeterinarioBE._numero;
                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50));
                cmd.Parameters["@Nombre"].Value = objVeterinarioBE._nombre;
                cmd.Parameters.Add(new SqlParameter("@Area", SqlDbType.VarChar, 50));
                cmd.Parameters["@Area"].Value = objVeterinarioBE._area;
                onx.Open();
                cmd.ExecuteNonQuery();
                blnexito= true;

            }catch(SqlException x)
            {
                blnexito = false;
            }
            finally
            {
                if (onx.State == ConnectionState.Open)
                {
                    onx.Close();
                }
                cmd.Parameters.Clear();
            }
            return blnexito;
        }


        public VeterinarioBE ConsultarVeterinario (int strCod)
        {
            VeterinarioBE objVeterinarioBE = new VeterinarioBE();
            try
            {
                onx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = onx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BuscarVeterinario";
                cmd.Parameters.Add(new SqlParameter("@IdVeterinario", SqlDbType.Int, 4));
                cmd.Parameters["@IdVeterinario"].Value = strCod;
                onx.Open();
                dtr = cmd.ExecuteReader();
                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    objVeterinarioBE._idVeterianrio = Convert.ToInt32(dtr.GetValue(dtr.GetOrdinal("IdVeterinario")).ToString());
                    objVeterinarioBE._tipo = dtr.GetValue(dtr.GetOrdinal("TipoDocumento")).ToString();
                    objVeterinarioBE._numero = dtr.GetValue(dtr.GetOrdinal("NumeroDocumento")).ToString();
                    objVeterinarioBE._nombre = dtr.GetValue(dtr.GetOrdinal("NombreVeterinario")).ToString();
                    objVeterinarioBE._area = dtr.GetValue(dtr.GetOrdinal("AreaTrabajo")).ToString();
                }
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                if(onx.State == ConnectionState.Open)
                {
                    onx.Close();

                }
                cmd.Parameters.Clear();
            }
            return objVeterinarioBE;

        }



    }
}
