
using AppEsferoCliente.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEsferoCliente
{
    public partial class Form1 : Form
    {
        ServiceReference1.SWServicioEsferoClient servicio = new ServiceReference1.SWServicioEsferoClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            GUIInsertar gUIInsertar = new GUIInsertar(servicio);
            gUIInsertar.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            GUIConsultar gui = new GUIConsultar(servicio);
            gui.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            GUIActualizar gui = new GUIActualizar(servicio);
            gui.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GUIEliminar gui = new GUIEliminar(servicio);
            gui.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            GUIListar gui = new GUIListar(servicio);
            gui.Show();
        }
    }
}
