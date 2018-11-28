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
    public partial class MantenimientoVeterinario2 : Form
    {
        VeterinarioBE objVeterinarioBE = new VeterinarioBE();
        VeterinarioBL objVeterinarioBL = new VeterinarioBL();
        public MantenimientoVeterinario2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objVeterinarioBE._tipo = txtTipo.Text;
                objVeterinarioBE._numero = txtNumero.Text;
                objVeterinarioBE._nombre = txtNombre.Text;
                objVeterinarioBE._area = txtArea.Text;
                if (objVeterinarioBL.AgregarVeterinario(objVeterinarioBE)==true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
