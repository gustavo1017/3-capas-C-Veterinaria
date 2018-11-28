using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyHuellitas_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void mantenimientoVeterinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoVeterinaria frmMantenimientoVeterinaria = new MantenimientoVeterinaria();
            frmMantenimientoVeterinaria.ShowDialog();
        }

        private void mantenimientoVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoVeterinario frmMantenimientoVeterinario = new MantenimientoVeterinario();
            frmMantenimientoVeterinario.ShowDialog();
        }

        private void mantenimientoClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenimientoCliente frmMantenimientoCliente = new MantenimientoCliente();
            frmMantenimientoCliente.ShowDialog();
        }
    }
}
