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
    public partial class MantenimientoCliente3 : Form
    {
        ClienteBE objClienteBE = new ClienteBE();
        ClienteBL objClienteBL = new ClienteBL();
  
        public MantenimientoCliente3()
        {
            InitializeComponent();
        }
        private String mvarcodigo;
        public String Codigo
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                objClienteBE._idCliente = Convert.ToInt32(mvarcodigo);
                objClienteBE._TipoDocumento = txtTipo.Text;
                objClienteBE._NumeroDocumento = txtNumero.Text;
                objClienteBE._NombreCliente = txtNombre.Text;
                objClienteBE._DireccionCLiente = txtDireccion.Text;
                objClienteBE._Telefono = txtTelefono.Text;
                if (objClienteBL.ActualizarCliente(objClienteBE) == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error, verifique los datos por favor");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void MantenimientoCliente3_Load(object sender, EventArgs e)
        {
            try
            {
                objClienteBE = objClienteBL.ConsultarCliente(Convert.ToInt32(mvarcodigo));
                txtTipo.Text = objClienteBE._TipoDocumento;
                txtNumero.Text = objClienteBE._NumeroDocumento;
                txtNombre.Text = objClienteBE._NombreCliente;
                txtDireccion.Text = objClienteBE._DireccionCLiente;
                txtTelefono.Text = objClienteBE._Telefono;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error aqui mira : " + ex.Message);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
