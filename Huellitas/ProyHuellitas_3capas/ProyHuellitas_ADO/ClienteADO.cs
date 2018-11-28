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
   public class ClienteADO
    {
        ConexionVeterinaria MiConexion = new ConexionVeterinaria();
        SqlConnection onx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;
        public DataTable ListarCliente()
        {
            DataSet dts = new DataSet();
            try
            {
                onx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = onx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarCliente";
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Cliente");
              
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Cliente"];
        }

        public Boolean AgregarCliente (ClienteBE objClienteBE)
        {
        
                onx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = onx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "agregarCliente";
                //Agregando los parametros
                try{
                    cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar, 50));
                    cmd.Parameters["@TipoDocumento"].Value = objClienteBE._TipoDocumento;
                    cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", SqlDbType.VarChar, 50));
                    cmd.Parameters["@NumeroDocumento"].Value = objClienteBE._NumeroDocumento;
                    cmd.Parameters.Add(new SqlParameter("@NombreCliente", SqlDbType.VarChar, 50));
                    cmd.Parameters["@NombreCliente"].Value = objClienteBE._NombreCliente;
                    cmd.Parameters.Add(new SqlParameter("@DireccionCliente", SqlDbType.VarChar, 50));
                    cmd.Parameters["@DireccionCliente"].Value = objClienteBE._DireccionCLiente;
                    cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 50));
                    cmd.Parameters["@Telefono"].Value = objClienteBE._Telefono;
                onx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
                }
                catch (SqlException x)
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

        public Boolean EliminarCliente (int strCod)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_EliminarCliente";
            try
            {
                
                cmd.Parameters.Add(new SqlParameter("@idCLiente", SqlDbType.Int,4));
                cmd.Parameters["@idCliente"].Value = strCod;
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

        public Boolean ActualizarCliente (ClienteBE objClienteBE)
        {
            onx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = onx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarCliente";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@idCliente",SqlDbType.VarChar,4));
                cmd.Parameters["@idCliente"].Value = objClienteBE._idCliente;
                cmd.Parameters.Add(new SqlParameter("@Dni", SqlDbType.VarChar, 50));
                cmd.Parameters["@Dni"].Value = objClienteBE._TipoDocumento;
                cmd.Parameters.Add(new SqlParameter("@Ndocumento", SqlDbType.VarChar, 50));
                cmd.Parameters["@Ndocumento"].Value = objClienteBE._NumeroDocumento;
                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50));
                cmd.Parameters["@Nombre"].Value = objClienteBE._NombreCliente;
                cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar, 50));
                cmd.Parameters["@Direccion"].Value = objClienteBE._DireccionCLiente;
                cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar, 50));
                cmd.Parameters["@Telefono"].Value = objClienteBE._Telefono;
                onx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch (SqlException x)
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

        public ClienteBE ConsultarCliente(int strCod)
        {
            ClienteBE objClienteBE = new ClienteBE();
            try
            {
                onx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = onx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BuscarCliente";
                cmd.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int, 4));
                cmd.Parameters["@IdCliente"].Value = strCod;
                onx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE._idCliente = Convert.ToInt32(dtr.GetValue(dtr.GetOrdinal("IdCliente")).ToString());
                    objClienteBE._TipoDocumento = dtr.GetValue(dtr.GetOrdinal("TipoDocumento")).ToString();
                    objClienteBE._NumeroDocumento = dtr.GetValue(dtr.GetOrdinal("NumeroDocumento")).ToString();
                    objClienteBE._NombreCliente = dtr.GetValue(dtr.GetOrdinal("NombreCliente")).ToString();
                    objClienteBE._DireccionCLiente = dtr.GetValue(dtr.GetOrdinal("DireccionCliente")).ToString();
                    objClienteBE._Telefono = dtr.GetValue(dtr.GetOrdinal("Telefono")).ToString();


                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (onx.State == ConnectionState.Open)
                {
                    onx.Close();
                }
                cmd.Parameters.Clear();
            }
            return objClienteBE;
        }



    }
}
