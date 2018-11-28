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
    public partial class MantenimientoVeterinaria3 : Form
    {
        VeterinariaBE objVeterinariaBE = new VeterinariaBE();
        VeterinariaBL objVeterinariaBL = new VeterinariaBL();
        public MantenimientoVeterinaria3()
        {
            InitializeComponent();
        }
        private String mvarcodigo;
        public String Codigo2
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objVeterinariaBE._idVeterinaria = Convert.ToInt32(mvarcodigo);
                objVeterinariaBE._nombreVeterinaria = txtNombre.Text;
                objVeterinariaBE._direccionVeterinaria = txtDireccion.Text;

                if (objVeterinariaBL.ActualizarVeterinaria(objVeterinariaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error, verifique los datos por favor");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el error : " + ex.Message);
            }
        }

        private void MantenimientoVeterinaria3_Load(object sender, EventArgs e)
        {
            try
            {
                objVeterinariaBE = objVeterinariaBL.ConsultarVeterinaria(Convert.ToInt32(mvarcodigo));
                txtNombre.Text = objVeterinariaBE._nombreVeterinaria;
                txtDireccion.Text = objVeterinariaBE._direccionVeterinaria;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error aqui mira : " + ex.Message);
            }
        }
    }
}
