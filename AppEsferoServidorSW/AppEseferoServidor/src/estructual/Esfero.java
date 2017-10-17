package estructual;

import java.io.Serializable;

public class Esfero implements Serializable{

    private static final long serialVersionUID = -2260701570289892907L;
    
    private int codigo;
    private String colorTinta, marca;
    private double precio;
    
    public Esfero() {
        
    }
    
    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
    
    public String getColorTinta() {
        return colorTinta;
    }

    public void setColorTinta(String colorTinta) {
        this.colorTinta = colorTinta;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public void asignarTodo(int codigo, String colorTinta, String marca, double precio){
        setCodigo(codigo);
        setColorTinta(colorTinta);
        setMarca(marca);
        setPrecio(precio);
    }
}
