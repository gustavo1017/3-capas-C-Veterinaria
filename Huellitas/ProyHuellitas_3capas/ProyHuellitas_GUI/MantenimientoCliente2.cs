using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyHuellitas_BE;
using ProyHuellitas_BL;
namespace ProyHuellitas_GUI
{
    public partial class MantenimientoCliente2 : Form
    {
        ClienteBE objClienteBE = new ClienteBE();
        ClienteBL objClienteBL = new ClienteBL();
        public MantenimientoCliente2()
        {
            InitializeComponent();
        }

        private void MantenimientoCliente2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               
                objClienteBE._TipoDocumento = txtTipo.Text;
                objClienteBE._NumeroDocumento = txtNumero.Text;
                objClienteBE._NombreCliente = txtNombre.Text;
                objClienteBE._DireccionCLiente = txtDireccion.Text;
                objClienteBE._Telefono = txtTelefono.Text;
                if (objClienteBL.AgregarCliente(objClienteBE)==true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error, verifique los datos por favor");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
