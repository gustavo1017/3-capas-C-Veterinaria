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
    public class VeterinarioBL
       
    {
        VeterinarioADO objVeterinarioADO = new VeterinarioADO();
        public DataTable ListarVeterinario()
        {
            return objVeterinarioADO.ListarVeterinario();
        }
        public Boolean AgregarVeterinario(VeterinarioBE objVeterinarioBE)
        {
            return objVeterinarioADO.AgregarVeterinario(objVeterinarioBE);
        }
        public Boolean EliminarVeterinario(int strCod)
        {
            return objVeterinarioADO.EliminarVeterinario(strCod);
        }
        public VeterinarioBE ConsultarVeterinario(int strCod)
        {
            return objVeterinarioADO.ConsultarVeterinario(strCod);
        }
        public Boolean ActualizarVeterinario(VeterinarioBE objVeterinarioBE)
        {
            return objVeterinarioADO.ActualizarVeterinario(objVeterinarioBE);
        }

   



    }
}
