using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHuellitas_BE
{
    public class VeterinariaBE
    {
        private int idVeterinaria;
        private String nombreVeterinaria;
        private String direccionVeterinaria;


        public int _idVeterinaria
        {
            get { return idVeterinaria; }
            set { idVeterinaria = value; }
        }

        public String _nombreVeterinaria
        {
            get { return nombreVeterinaria; }
            set { nombreVeterinaria = value; }
        }

        public String _direccionVeterinaria
        {
            get { return direccionVeterinaria; }
            set { direccionVeterinaria = value; }
        }
    }
}
