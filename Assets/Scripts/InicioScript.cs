using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioScript : MonoBehaviour
{
    /*
    Inicialización de Variables
    */
    public int miNumerico = 5;
    private float dinero;
    public float pi = 3.14159632f;
    private string nombre;
    public string zonaEstudio;
    public int miNumerico2 = 15;
    public string frase;
    public float miNumerico3 = 3.5f;
    public string mascota;
    public char inicialNombre = 'J';
    public string fecha;
    public bool esRojo = false;

    // Start is called before the first frame update
    void Start()
    {
        //Todos los métodos que queramos que funcionen cuando empiece el juego los llamamos aquí
        RestarNumeros();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestarNumeros()
    {
        //El método hará todo lo que esté entre las dos llaves
        Debug.Log(miNumerico - miNumerico3);
    }
}
