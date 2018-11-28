using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHuellitas_BE
{
    public class ClienteBE
    {
        private int idCliente;
        private String TipoDocumento;
        private String NumeroDocumento;
        private String NombreCliente;
        private String DireccionCliente;
        private String Telefono;

        public int _idCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public String _TipoDocumento
        {
            get { return TipoDocumento; }
            set { TipoDocumento = value;  }
        }

        public String _NumeroDocumento
        {
            get
            {
                return NumeroDocumento;
            }
            set
            {
                NumeroDocumento = value;
            }
        }

        public String _NombreCliente
        {
            get
            {
                return NombreCliente;
            }
            set
            {
                NombreCliente = value;
            }
        }

        public String _DireccionCLiente
        {
            get
            {
                return DireccionCliente;
            }
            set
            {
                DireccionCliente = value;
            }
        }

        public String _Telefono
        {
            get
            {
                return Telefono;
            }
            set
            {
                Telefono = value;
            }
        }




    }
}
