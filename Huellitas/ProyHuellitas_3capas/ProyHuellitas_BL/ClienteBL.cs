using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyHuellitas_BE;
using ProyHuellitas_ADO;
using System.Data;
namespace ProyHuellitas_BL
{
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();
        

        public DataTable ListarCliente()
        {
            return objClienteADO.ListarCliente();

        }
        public Boolean AgregarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.AgregarCliente(objClienteBE);
        }
        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.ActualizarCliente(objClienteBE);
        }
        public Boolean EliminarCliente(int strCod)
        {
            return objClienteADO.EliminarCliente(strCod);
        }
        public ClienteBE ConsultarCliente(int strCod)
        {
            return objClienteADO.ConsultarCliente(strCod);
        }

    }
}
