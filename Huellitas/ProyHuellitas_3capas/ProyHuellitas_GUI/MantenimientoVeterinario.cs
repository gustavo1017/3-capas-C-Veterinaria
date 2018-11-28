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
    public partial class MantenimientoVeterinario : Form
    {
        VeterinarioBL objVeterinarioBL = new VeterinarioBL();
        public MantenimientoVeterinario()
        {
            InitializeComponent();
        }
        public void CargarDatosVeterinario()
        {
            dtgVeterinario.DataSource = objVeterinarioBL.ListarVeterinario();
        }

        private void MantenimientoVeterinario_Load(object sender, EventArgs e)
        {
            try{
                CargarDatosVeterinario();
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MantenimientoVeterinario2 frmVeterinarioMan02 = new MantenimientoVeterinario2();
            frmVeterinarioMan02.ShowDialog();
            CargarDatosVeterinario();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MantenimientoVeterinario3 frmVeterinarioMan03 = new MantenimientoVeterinario3();
            frmVeterinarioMan03.Codigo3 = dtgVeterinario.CurrentRow.Cells[0].Value.ToString();
            frmVeterinarioMan03.ShowDialog();
            CargarDatosVeterinario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strCod = String.Empty;
                strCod = dtgVeterinario.CurrentRow.Cells[0].Value.ToString();
                DialogResult vrpta;
                vrpta = MessageBox.Show("Seguro de eliminar el Veterinario?",
                    "Confirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(vrpta == System.Windows.Forms.DialogResult.Yes){

                    if(objVeterinarioBL.EliminarVeterinario(Convert.ToInt32(strCod)) == true)
                    {
                        MessageBox.Show("Cliente Eliminado");
                        CargarDatosVeterinario();
                    }
                    else
                    {
                        MessageBox.Show("Error, verifique los datos ");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
