using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaExtraordinariaBuclesScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        for(int numero = 1; numero < 100; numero++)
        {
            if(numero % 2 == 0)
            {
                Debug.Log("El número " + numero + " es par.")
            }
            else
            {
                Debug.Log("El número " + numero + " es impar.")
            }
        }
        
        int miNumero = 13;
        bool primo = true;
        for(int n = 2; n < miNumero; n++)
        {
            if(miNumero % n == 0)
            {
                primo = false;
                break;
            }
        }
        if(primo)
            Debug.Log("El número " + miNumero + " es primo.");
        else
            Debug.Log("El número " + miNumero + " no es primo.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
