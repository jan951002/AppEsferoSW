using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEsferoCliente.vista
{
    public partial class GUIListar : Form
    {
        private ServiceReference1.SWServicioEsferoClient servicio;
        public GUIListar(ServiceReference1.SWServicioEsferoClient refServicio)
        {
            InitializeComponent();
            servicio = refServicio;
        }

        private void recorrerLista()
        {
            
            try
            {
                List<ServiceReference1.esfero> lista = servicio.listar().ToList();
                dataGridView1.DataSource = lista;
                dataGridView1.Refresh();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            recorrerLista();
        }
    }
}
