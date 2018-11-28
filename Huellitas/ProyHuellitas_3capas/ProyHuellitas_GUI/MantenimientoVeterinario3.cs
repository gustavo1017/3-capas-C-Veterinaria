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
    public partial class MantenimientoVeterinario3 : Form
    {
        VeterinarioBE objVeterinarioBE = new VeterinarioBE();
        VeterinarioBL objVeterinarioBL = new VeterinarioBL();
        public MantenimientoVeterinario3()
        {
            InitializeComponent();
        }
        private String mvarcodigo;
        public String Codigo3
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }



        private void MantenimientoVeterinario3_Load(object sender, EventArgs e)
        {

            try
            {
                objVeterinarioBE = objVeterinarioBL.ConsultarVeterinario(Convert.ToInt32(mvarcodigo));
                txtTipo.Text = objVeterinarioBE._tipo;
                txtNumero.Text = objVeterinarioBE._numero;
                txtNombre.Text = objVeterinarioBE._nombre;
                txtArea.Text = objVeterinarioBE._area;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error aqui mira : " + ex.Message);
            }
    
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objVeterinarioBE._idVeterianrio = Convert.ToInt32(mvarcodigo);
                objVeterinarioBE._tipo = txtTipo.Text;
                objVeterinarioBE._numero = txtNumero.Text;
                objVeterinarioBE._nombre = txtNombre.Text;
                objVeterinarioBE._area = txtArea.Text;
                if (objVeterinarioBL.ActualizarVeterinario(objVeterinarioBE)==true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error, verifique los datos por favor ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
