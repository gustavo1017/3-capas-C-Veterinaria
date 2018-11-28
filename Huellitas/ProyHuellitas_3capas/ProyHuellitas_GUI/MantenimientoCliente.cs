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
    
    public partial class MantenimientoCliente : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
       
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
     

        public void CargarDatos()
        {
            dtgMantenimientoCliente.DataSource = objClienteBL.ListarCliente();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

            try
            {
                CargarDatos();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoCliente2 frmClienteMan02 = new MantenimientoCliente2();
            frmClienteMan02.ShowDialog();
            CargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strCod = String.Empty;
                strCod = dtgMantenimientoCliente.CurrentRow.Cells[0].Value.ToString();
                DialogResult vrpta;
                vrpta = MessageBox.Show("Seguro de eliminar el cliente?",
                    "Comfirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == System.Windows.Forms.DialogResult.Yes)
                {
                    if (objClienteBL.EliminarCliente( Convert.ToInt32(strCod) ) == true)
                    {
                        MessageBox.Show("Cliente Eliminado");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error, verifique los datos");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MantenimientoCliente3 frmClienteMan03 = new MantenimientoCliente3();
            frmClienteMan03.Codigo = dtgMantenimientoCliente.CurrentRow.Cells[0].Value.ToString();
            frmClienteMan03.ShowDialog();
            CargarDatos();
            
        }

        private void MantenimientoCliente_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dtgMantenimientoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  textBox1.Text = dtgMantenimientoCliente.CurrentRow.Cells[0].Value.ToString();
            MantenimientoCliente3 frmClienteMan03 = new MantenimientoCliente3();*/
          
        }
    }
}
