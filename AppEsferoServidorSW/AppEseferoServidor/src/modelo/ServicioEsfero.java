package modelo;

import estructual.Esfero;

import java.io.Serializable;

import java.util.ArrayList;

import vista.AActualizableEsfero;

public class ServicioEsfero implements Serializable{
    
    private static ArrayList<Esfero> esferos = new ArrayList<Esfero>();
    private static ArrayList<AActualizableEsfero> observadores = new ArrayList<AActualizableEsfero>();
    private static final long serialVersionUID = 1L;


    public static boolean insertar(Esfero refEsfero) {
        boolean resultado = false;
        Esfero buscado = consultar(refEsfero.getCodigo());
        
        if(buscado == null){
            esferos.add(refEsfero);
            System.out.println("Se acaba de agregar el objeto loco");
            notificarObservadores();
            resultado = true;
        }
        return resultado;
    }

    public static boolean eliminar(int refCodigo) {
        boolean resultado = false;
        Esfero buscado = consultar(refCodigo);
        
        if(buscado != null){
            esferos.remove(buscado);
            notificarObservadores();
            resultado = true;
        }
        return resultado;
    }

    public static boolean actualizar(Esfero refEsfero) {
        boolean resultado = false;
        Esfero buscado = consultar(refEsfero.getCodigo());
        
        if(buscado != null){
            
            buscado.setCodigo(refEsfero.getCodigo());
            buscado.setColorTinta(refEsfero.getColorTinta());
            buscado.setMarca(refEsfero.getMarca());
            buscado.setPrecio(refEsfero.getPrecio());
            
            notificarObservadores();
            resultado = true;
        }
        return resultado;
    }

    public static Esfero consultar(int refCodigo) {
        Esfero esfero = null;
        boolean encontro = false;
        
        for (int i = 0; i < esferos.size() && !encontro; i++) {
            Esfero aux = esferos.get(i);
            if(aux.getCodigo() == refCodigo){
                esfero = aux;
                encontro = true;
            }
        }
        
        return esfero;
    }

    public static ArrayList<Esfero> listar() {
        return esferos;
    }

    public static void notificarObservadores() {
        for(AActualizableEsfero observador: observadores){
            observador.cambio();
        }
    }

    public static void agregarObservador(AActualizableEsfero refObservador) {
        observadores.add(refObservador);
    }
}
