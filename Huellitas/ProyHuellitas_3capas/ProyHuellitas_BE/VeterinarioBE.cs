using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHuellitas_BE
{
    public class VeterinarioBE
    {
        private int idVeterinario;
        private String tipo;
        private String numero;
        private String nombre;
        private String area;

        public int _idVeterianrio
        {
            get { return idVeterinario; }
            set { idVeterinario = value; }
        }

        public String _tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public String _numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public String _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String _area
        {
            get { return area; }
            set { area = value; }
        }
    }
}
