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
    public class VeterinariaADO

    {
        ConexionVeterinaria MiConexion = new ConexionVeterinaria();
        SqlConnection onx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        public DataTable ListarVeterinaria()
        {
            DataSet dts = new DataSet();
            try
            {
                onx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = onx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarVeterinaria";
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Veterinaria");
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Veterinaria"];
        }

        public Boolean AgregarVeterinaria (VeterinariaBE objVeterinarioBE)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "agregarVeterinaria";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 50));
                cmd.Parameters["@nombre"].Value = objVeterinarioBE._nombreVeterinaria;
                cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar, 50));
                cmd.Parameters["@direccion"].Value = objVeterinarioBE._direccionVeterinaria;
                onx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;

            }catch(SqlException ex)
            {
                blnexito = false;
            }
            finally
            {
                if (onx.State == ConnectionState.Open)
                {
                    onx.Close();
                }
            }
            return blnexito;
        }


        public Boolean EliminarVeterinaria (int strCod)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_EliminarVeterinaria";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@IdVeterinaria", SqlDbType.Int, 4));
                cmd.Parameters["@IdVeterinaria"].Value = strCod;
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


        public Boolean ActualizarVeterinaria (VeterinariaBE objVeterinariaBE)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarVeterinaria";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4));
                cmd.Parameters["@id"].Value = objVeterinariaBE._idVeterinaria;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 50));
                cmd.Parameters["@nombre"].Value = objVeterinariaBE._nombreVeterinaria;
                cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar, 50));
                cmd.Parameters["@direccion"].Value = objVeterinariaBE._direccionVeterinaria;
                onx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch(SqlException x)
            {
                blnexito=false;
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


        public VeterinariaBE ConsultarVeterinaria(int strCod)
        {
            VeterinariaBE objVeterinariaBE = new VeterinariaBE();
            try
            {
                onx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = onx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BuscarVeterinaria";
                cmd.Parameters.Add(new SqlParameter("@IdVeterinaria", SqlDbType.Int, 4));
                cmd.Parameters["@IdVeterinaria"].Value = strCod;
                onx.Open();
                dtr = cmd.ExecuteReader();
                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    objVeterinariaBE._idVeterinaria = Convert.ToInt32(dtr.GetValue(dtr.GetOrdinal("IdVeterinaria")).ToString());
                    objVeterinariaBE._nombreVeterinaria = dtr.GetValue(dtr.GetOrdinal("NombreVeterinaria")).ToString();
                    objVeterinariaBE._direccionVeterinaria = dtr.GetValue(dtr.GetOrdinal("DireccionVeterinaria")).ToString();

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
            }
            return objVeterinariaBE;
        }

    }
}
