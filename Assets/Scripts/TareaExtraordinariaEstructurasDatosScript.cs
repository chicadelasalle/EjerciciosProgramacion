using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaExtraordinariaEstructurasDatosScript : MonoBehaviour
{

    public List<string> listaCoches = new List<string>();
    public ArrayList videojuego = new ArrayList();
    public int[] notas = new int[] { 7, 8, 5, 9, 2, 1, 0, 8};

    public EstructuraDatosScript referencia;

    // Start is called before the first frame update
    void Start()
    {
        videojuego.Add(80);
        videojuego.Add("God of Adecco");
        videojuego.Add("PlayNoEntiendo");
        videojuego.Add(5);
        videojuego.Add(false);

        Debug.Log("" + referencia.objeto[0] +  referencia.objeto[1] + referencia.objeto[2] +  referencia.objeto[3] +  referencia.objeto[4] +  referencia.objeto[5] +  referencia.objeto[6]);
    
        string[] arraySeries = referencia.series.ToArray();   
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
