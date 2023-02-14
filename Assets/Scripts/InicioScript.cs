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
        Estudio("biblioteca");
        Multiplica(5, 3);

        //Primera manera y con parámetros
        Debug.Log(Operacion(3,2,5));
        //Segunda manera y con parámetros
        int resultadoOperacion = Operacion(3,2,5);
        Debug.Log(resultadoOperacion);

        Debug.Log(Division(15,3));


        /*CONDICIONALES*/
        bool diaMercado = false;
        bool cogerCoche = true;
        if(!diaMercado && cogerCoche)
        {
            Debug.Log("Aparca en esa calle mangurrian");
        }
        else
        {
            Debug.Log("O bien busco otro sitio, o hoy no hay que trabajar payico limón");
        }

        bool esLunes = true;
        bool esMiercoles = false;
        if(esLunes || esMiercoles)
        {
            Debug.Log("Puedo ir a clase");
        }
        else
        {
            Debug.Log("Me quedo en mi casa");
        }

        if(esRojo)
        {
            Debug.Log("Maestro, es rojo");
        }
        else
        {
            Debug.Log("Maestro, no es rojo");
        }

        string colorObjeto = "Rojo";
        if(colorObjeto == "Rojo")
        {
            Debug.Log("Maestro, es rojo");
        }
        else
        {
            Debug.Log("Maestro, no es rojo");
        }
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

    public void Estudio(string nombreSitio)
    {
        Debug.Log("El sitio donde estudio es " + nombreSitio);
    }

    public void Multiplica(int primerNumero, int segundoNumero)
    {
        Debug.Log(primerNumero * segundoNumero);
    }

    public int Operacion(int numero1, int numero2, int numero3)
    {
        int resultado = numero1 * numero2 - numero3;
        return resultado;
    }
    /*public int Operacion()
    {
        int resultado = 2 * 5 - 3;
        return resultado;
    }*/

    public int Division(int miPrimerNumero, int miSegundoNumero)
    {
        int resultado = miPrimerNumero / miSegundoNumero;
        return resultado;
    }
}
