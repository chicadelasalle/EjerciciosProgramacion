using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaExtraordinariaScript : MonoBehaviour
{
    public int miVariable1 = 7;
    public int miVariable2 = 13;
    public float dinero = 75.5f;
    public bool fechaSalida = true;

    public InicioScript referencia;
    public Mascota referenciaMascota;

    // Start is called before the first frame update
    void Start()
    {
        referencia.Multiplica(2, 7);

        //Obtengo la altura de la pelota
        //this = el objeto donde está metido este código
        //this.transform.position.y;
        Debug.Log(transform.position.y);

        CompraJuego();

        Debug.Log("Mi mascota es un " + referenciaMascota.tipo + ", que se llama " + referenciaMascota.nombre + " y tiene " + referenciaMascota.edad + " de edad");
    }

    // Update is called once per frame
    void Update()
    {
        Calculadora();
    }

    public void Calculadora()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(miVariable1 + miVariable2);
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(miVariable1 - miVariable2);
        }
        else if(Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(miVariable1 * miVariable2);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(miVariable1 / miVariable2);
        }

        /*string referencia = Input.inputString;
        switch(referencia)
        {
            case "S":
                Debug.Log(miVariable1 + miVariable2);
                break;
            case "R":
                Debug.Log(miVariable1 - miVariable2);
                break;
            case "M":
                Debug.Log(miVariable1 * miVariable2);
                break;
            case "D":
                Debug.Log(miVariable1 / miVariable2);
                break;
            default:
                Debug.Log("Caracter introducido incorrecto");
                break;
        }*/
    }

    public void CompraJuego()
    {
        if(dinero > 60 && fechaSalida)
        {
            Debug.Log("Vaya un juegarraco ninioh");
        }
        else
        {
            Debug.Log("aCHO PAYICOH tiene's un eurico?");
        }
    }
}
