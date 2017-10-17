using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AppEsferoCliente.estructural
{
    [Serializable]
    public class Esfero
    {
      
        private int codigo;
        private string colorTinta, marca;
        private double precio;

        public Esfero()
        {

        }

        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string getColorTinta()
        {
            return colorTinta;
        }

        public void setColorTinta(string colorTinta)
        {
            this.colorTinta = colorTinta;
        }

        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public void asignarTodo(int codigo, string colorTinta, string marca, double precio)
        {
            setCodigo(codigo);
            setColorTinta(colorTinta);
            setMarca(marca);
            setPrecio(precio);
        }
    }
}
