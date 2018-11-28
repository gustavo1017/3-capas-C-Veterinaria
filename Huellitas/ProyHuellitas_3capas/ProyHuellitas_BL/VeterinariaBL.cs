using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyHuellitas_BE;
using ProyHuellitas_ADO;

namespace ProyHuellitas_BL
{
    public class VeterinariaBL
    {
        VeterinariaADO objVeterinariaADO = new VeterinariaADO();

        public DataTable ListarVeterinaria()
        {
            return objVeterinariaADO.ListarVeterinaria();
        }

        public Boolean AgregarVeterinaria (VeterinariaBE objVeterinariaBE)
        {
            return objVeterinariaADO.AgregarVeterinaria(objVeterinariaBE);
        }
        public Boolean EliminarVeterinaria (int strCod)
        {
            return objVeterinariaADO.EliminarVeterinaria(strCod);
        }
        public Boolean ActualizarVeterinaria (VeterinariaBE objVeterinariaBE)
        {
            return objVeterinariaADO.ActualizarVeterinaria(objVeterinariaBE);
        }
        public VeterinariaBE ConsultarVeterinaria (int strCod)
        {
            return objVeterinariaADO.ConsultarVeterinaria(strCod);
        }


    }
}
