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
    public partial class MantenimientoVeterinaria2 : Form
    {
        VeterinariaBE objVeterinariaBE = new VeterinariaBE();
        VeterinariaBL objVeterinariaBL = new VeterinariaBL();
        public MantenimientoVeterinaria2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objVeterinariaBE._nombreVeterinaria = txtNombre.Text;
                objVeterinariaBE._direccionVeterinaria = txtDireccion.Text;
                if (objVeterinariaBL.AgregarVeterinaria(objVeterinariaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Verifique los datos ");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
