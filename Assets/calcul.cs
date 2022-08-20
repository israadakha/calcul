using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int sum();
        int div();
        int prod();
        
    }
    int sum(int a,int b)
    {
        Debug.Log(a + b);
        

    }
    int div(int a, int b)
    {
        if (b != 0){ Debug.Log(a / b); }
        else { Debug.Log("erreur"); }
        

    }
    int prod(int a, int b)
    {
        Debug.Log(a * b);

    }
}
