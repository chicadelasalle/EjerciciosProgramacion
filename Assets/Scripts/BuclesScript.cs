using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuclesScript : MonoBehaviour
{
    public string[] listaCompra = new string[] { "sal", "azúcar", "queso", "agua", "macarrones", "lechuga", "tomate", "huevos", "pan"};
    public float[] preciosCompra = new float[] { 0.50f, 0.50f, 1.65f, 0.95f, 1.10f, 1.00f, 0.70f, 2.15f, 0.37f};

    // Start is called before the first frame update
    void Start()
    {
        //FOREACH
        Debug.Log("Lista de la compra: ");
        foreach(string i in listaCompra)
        {
            Debug.Log(i);
        }

        Debug.Log("El total de todos los productos es: ");
        float totalPrecio = 0f;
        foreach(float p in preciosCompra)
        {
            totalPrecio += p;
        }
        Debug.Log(totalPrecio);

        Debug.Log("La media de todos los productos es: ");
        int numeroDatos = preciosCompra.Length;
        Debug.Log(totalPrecio/numeroDatos);

        //FOR
        for(int i = 1; i < 500; i += 2)
        {
            Debug.Log(i);
        }
        for(int i = 500; i > 0; i -= 2)
        {
            Debug.Log(i);
        }
        for(int i = 0; i < listaCompra.Length; i++)
        {
            Debug.Log("El ingrediente número " + i + " de la lista es " + listaCompra[i]);
        }

        //WHILE
        if(Input.GetKeyDown(KeyCode.E))
        {
            int i = 1;
            while(i < 500)
            {
                Debug.Log(i);
                i++;
            }
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            int i = 500;
            while(i > 0)
            {
                Debug.Log(i);
                i--;
            }
        }
        bool horaTrabajo = true;
        while(horaTrabajo)
        {
            Debug.Log("Debo ir al trabajo");
            Debug.Log("Empiezo el trabajo");
            Debug.Log("Tiempo de descanso");
            Debug.Log("Continúo trabajando");
            Debug.Log("Hora de irse a casa");
            horaTrabajo = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
