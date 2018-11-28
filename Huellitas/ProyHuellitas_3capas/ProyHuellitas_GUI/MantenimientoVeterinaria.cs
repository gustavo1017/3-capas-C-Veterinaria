using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyHuellitas_BL;
namespace ProyHuellitas_GUI
{
    public partial class MantenimientoVeterinaria : Form
    {
        VeterinariaBL objVeterinaria = new VeterinariaBL();
        public MantenimientoVeterinaria()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            dtgVeterinaria.DataSource = objVeterinaria.ListarVeterinaria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoVeterinaria2 frmVeterinariaMan02 = new MantenimientoVeterinaria2();
            frmVeterinariaMan02.ShowDialog();
            CargarDatos();
              
        }

        private void MantenimientoVeterinaria_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenimientoVeterinaria3 frmVeterinariaMan03 = new MantenimientoVeterinaria3();
            frmVeterinariaMan03.Codigo2 = dtgVeterinaria.CurrentRow.Cells[0].Value.ToString();
            frmVeterinariaMan03.ShowDialog();
            CargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strCod = String.Empty;
                strCod = dtgVeterinaria.CurrentRow.Cells[0].Value.ToString();
                DialogResult vrpta;
                vrpta = MessageBox.Show("Seguro de eliminar esta veterinaria?",
                    "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta==System.Windows.Forms.DialogResult.Yes)
                {
                    if (objVeterinaria.EliminarVeterinaria(Convert.ToInt32(strCod)))
                    {
                        MessageBox.Show("Veterinaria eliminada");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error, verifique los datos");
                    }
                }



            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }




        }
    }
}
