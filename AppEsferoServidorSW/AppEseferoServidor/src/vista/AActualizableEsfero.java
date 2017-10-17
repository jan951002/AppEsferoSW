package vista;

import java.io.Serializable;

public abstract class AActualizableEsfero implements Serializable {

    @SuppressWarnings("compatibility:804774102975096767")
    private static final long serialVersionUID = 1L;

    private int index;
    
    public AActualizableEsfero() {
        index = 0;    
    }
    
    public int gettIndex(){
        return index;
    }
    
    public void setIndex(int index){
        this.index = index;
    }
    
    public abstract void cambio();
}
