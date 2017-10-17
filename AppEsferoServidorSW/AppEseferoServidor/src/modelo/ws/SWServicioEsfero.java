package modelo.ws;

import estructual.Esfero;

import java.util.ArrayList;

import javax.jws.Oneway;
import javax.jws.WebMethod;
import javax.jws.WebService;

import modelo.ServicioEsfero;

import vista.AActualizableEsfero;

@WebService(targetNamespace = "http://tempuri.org/")
public class SWServicioEsfero {
    public SWServicioEsfero() {
        super();
    }

    @WebMethod
    public boolean insertar(Esfero refEsfero){
        return ServicioEsfero.insertar(refEsfero);
    }

    @WebMethod
    public boolean eliminar(int refCodigo){
        return ServicioEsfero.eliminar(refCodigo);
    }

    @WebMethod
    public boolean actualizar(Esfero refEsfero){
        return ServicioEsfero.actualizar(refEsfero);
    }

    @WebMethod
    public ArrayList<Esfero> listar(){
        return ServicioEsfero.listar();
    }

    @WebMethod
    public Esfero consultar(int refCodigo){
        return ServicioEsfero.consultar(refCodigo);
    }

    @WebMethod
    @Oneway
    public void notificarObservadores(){
        ServicioEsfero.notificarObservadores();
    }

    @WebMethod
    @Oneway
    public void agregarObservador(AActualizableEsfero refObservador){
        ServicioEsfero.agregarObservador(refObservador);
    }
}
