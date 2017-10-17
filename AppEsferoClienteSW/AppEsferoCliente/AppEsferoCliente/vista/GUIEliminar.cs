using System;
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
    public partial class GUIEliminar : Form
    {
        private ServiceReference1.SWServicioEsferoClient servicio;

        public GUIEliminar(ServiceReference1.SWServicioEsferoClient refServicio)
        {
            InitializeComponent();
            servicio = refServicio;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Int32.Parse(txtCodigo.Text);
                ServiceReference1.esfero buscado = servicio.consultar(codigo);

                if (buscado != null)
                {
                    bool resultado = servicio.eliminar(codigo);

                    if (resultado)
                    {
                        MessageBox.Show("Eliminado");
                        txtCodigo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El esfero existe, pero no se pudo eliminar.");
                    }
                }
                else
                {
                    MessageBox.Show("No existe ese esfero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
