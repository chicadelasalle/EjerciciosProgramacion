using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructuraDatosScript : MonoBehaviour
{
    //ARRAYS
    public string[] nombres = new string[] {"Alfonso", "María", "Carla", "Gabriel"};
    int[] orden = new int[] {1, 5, 3, 2, 4};
    public float[] acciones = new float[] {2.5f, 2.4f, 2.55f, 3.05f, 3f, 2.70f};
    public char[] objeto = new char[] {'C', 'a', 'm', 'p', 'a', 'n', 'a'};
    public string[] oficios = new string[10];
    public bool[] asistencia = new bool[] {true, false, false, true, true};

    //LISTAS
    public List<string> series = new List<string>();

    //ARRAYLIST
    public ArrayList inventario = new ArrayList();

    //HASHTABLE
    public Hashtable miInventario = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(nombres[2] + " es la " + orden[2] + " por orden alfabético de la lista de personas que tenemos");
        
        series.Add("Lost");
        Debug.Log(series[0]);
        series.Add("Futurama");
        Debug.Log(series[1]);
        series.Add("Mandaloriano");
        Debug.Log(series[2]);
        series.Add("Doramion");
        Debug.Log(series[3]);
        series.Add("Cine de barrio");
        Debug.Log(series[4]);
        if(series.Contains("Mandaloriano"))
        {
            series.Remove("Mandaloriano");
        }
        series.Insert(2, "Farmacia de guardia");
        Debug.Log(series.Count);

        inventario.Add("Pocion");
        inventario.Add(30);
        inventario.Add("Mago");
        inventario.Add("Cuero");

        inventario.Remove("Pocion");
        inventario.Remove(30);
        inventario.Add(30);
        inventario.Add("Pocion");
        Debug.Log(inventario[0].GetType());
        Debug.Log(inventario[1].GetType());

        miInventario.Add("tipo", "espada");
        miInventario.Add("material", "acero");
        miInventario.Add("color", "rojo");
        miInventario.Add("costo", 45);
        miInventario.Add("usada", false);

        MetodoInventario();

        if(miInventario.Contains("tipo") && miInventario.Contains("color"))
        {
            Debug.Log("El arma es una " + miInventario["tipo"] + " de color " + miInventario["color"] + " que se encuentra en la posición " + transform.position.x + ", " + transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MetodoInventario()
    {
        if((string)inventario[3] == "Pocion" && (int)inventario[2] >= 5)
        {
            Debug.Log("¡Enhorabuena! Podéis emprender la quest");
        }
        else
        {
            Debug.Log("Más suerte la próxima vez");
        }
    }
}
