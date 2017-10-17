using AppEsferoCliente.estructural;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AppEsferoCliente.vista
{
    public partial class GUIInsertar : Form
    {
        private ServiceReference1.SWServicioEsferoClient servicio;

        public GUIInsertar(ServiceReference1.SWServicioEsferoClient refServicio)
        {
            InitializeComponent();
            servicio = refServicio;
        }

        private void Insertar_Load(object sender, EventArgs e)
        {

        }

         
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Int32.Parse(txtCodigo.Text);
                string color = txtColor.Text;
                string marca = txtMarca.Text;
                double precio = Double.Parse(txtPrecio.Text);

                Esfero miEsfero = new Esfero();
                miEsfero.asignarTodo(codigo, color, marca, precio);

                ServiceReference1.esfero unEsfero = new ServiceReference1.esfero();
                unEsfero.codigo = codigo;
                unEsfero.colorTinta = color;
                unEsfero.marca = marca;
                unEsfero.precio = precio;

                bool respuesta = servicio.insertar(unEsfero);

                if (respuesta)
                {
                    MessageBox.Show("Insertado");
                    limpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void limpiarFormulario()
        {
            txtCodigo.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = "";
        }
    }
}
