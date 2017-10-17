using AppEsferoCliente.estructural;
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
    public partial class GUIConsultar : Form, IActualizableEsfero
    {

        private ServiceReference1.SWServicioEsferoClient servicio;
        private ServiceReference1.esfero esfero;

        public GUIConsultar(ServiceReference1.SWServicioEsferoClient refServicio)
        {
            InitializeComponent();
            servicio = refServicio;
        }

        private void asignarEsfero(ServiceReference1.esfero refEsfero)
        {
            esfero = refEsfero;
        }

        public void cambio()
        {
            int codigo;
            String colorTinta, marca;
            double precio;

            codigo = esfero.codigo;
            colorTinta = esfero.colorTinta;
            marca = esfero.marca;
            precio = esfero.precio;

            txtCodigo.Text = codigo.ToString();
            txtColor.Text = colorTinta;
            txtMarca.Text = marca;
            txtPrecio.Text = precio.ToString();
        }

        private void GUIConsultar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int codigo = Int32.Parse(txtCodigo.Text);
                ServiceReference1.esfero refEsfero = servicio.consultar(codigo);
                asignarEsfero(refEsfero);
                cambio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
