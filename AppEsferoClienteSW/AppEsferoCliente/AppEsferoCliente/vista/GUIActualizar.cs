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
    public partial class GUIActualizar : Form, IActualizableEsfero
    {
        private ServiceReference1.SWServicioEsferoClient servicio;
        private ServiceReference1.esfero esfero;

        public GUIActualizar(ServiceReference1.SWServicioEsferoClient refServicio)
        {
            InitializeComponent();
            servicio = refServicio;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Int32.Parse(txtCodigo.Text);
                string color = txtColor.Text;
                string marca = txtMarca.Text;
                double precio = Double.Parse(txtPrecio.Text);

                ServiceReference1.esfero nuevo = new ServiceReference1.esfero();

                nuevo.codigo = codigo;
                nuevo.colorTinta = color;
                nuevo.marca = marca;
                nuevo.precio = precio;

                bool respuesta = servicio.actualizar(nuevo);

                if (respuesta)
                {
                    MessageBox.Show("Actualizado");
                    limpiarFormulario();

                    txtMarca.Enabled = false;
                    txtColor.Enabled = false;
                    txtPrecio.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Por algna razón no se pudo actualizar.");
                }

                txtCodigo.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " +  ex.Message);
            }
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

        private void limpiarFormulario()
        {
            txtCodigo.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int codigo = Int32.Parse(txtCodigo.Text);
                ServiceReference1.esfero refEsfero = servicio.consultar(codigo);

                if(refEsfero != null)
                {
                    asignarEsfero(refEsfero);
                    cambio();

                    txtCodigo.Enabled = false;

                    txtMarca.Enabled = true;
                    txtColor.Enabled = true;
                    txtPrecio.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existe un esfero con dicho código");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
