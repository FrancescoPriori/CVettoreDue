using System;
using System.Linq;

public class Vettore {


    private int[] vettore;
    private int idx = 0 ;

// costruttore vuoto chee crea 
//interamente un vettore di un solo elemento inizzializzato a zero
    public Vettore () {
        vettore = new int[]{0};
    }
    //un costruttore con un parametro N 
    //(che crea internamente un vettore di N interi)
    
     public Vettore (int N ) 
    {
        // nel caso N sia negativo o zero
        if(N <= 0)
            vettore = new int[0];
        else

        vettore = new int[N];
    }

    // un metodo bool Aggiungi( val ) 
    //(che aggiunge sempre in fondo il valore val e torna true se riesce ad inserirlo... false altrimenti)

public bool Aggiungi(int val)
    {
        if( idx >= vettore.Length)
             return false;
        
        
        vettore[idx] = val;
        idx++;

        return true;

    }

    //un metodo Somma che torna la somma degli elementi

    public int  Somma()
    {
        int retVal = 0;
        
        for (int idx = 0; idx < vettore.Length ; idx++ )
            retVal = retVal + vettore[idx];
        
        return retVal;
  }
    //un metodo Ultimo che torna l'ultimo valore inserito
    public int Ultimo()
    {
        if (vettore.Length == 0)
            return 0;

        if(idx == 0)
            return vettore[idx];
        
        return vettore[idx - 1];
    }

    //elimina il valore contenuto in ultimo 
    public bool EliminaUltimo()
    {
        if(idx == 0)
        {
            return false;
        }
        return true;
    }


}