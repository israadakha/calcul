using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        somme(1,2);
        divi(1,3) ;
        prod(2,5) ;
        
    }
    int somme(int a, int b)
    {
        Debug.Log(a + b);
        return(a + b);
    }
    int divi (int a, int b)
    {
        if (b != 0)
        {
            Debug.Log(a / b); 
            return(a / b);
        }
        else 
        {
            Debug.Log("erreur");
            return 1;
        }
        

    }
    int prod(int a, int b)
    {
        return(a * b);

    }
}
