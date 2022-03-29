/*En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje  obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes  resultados:  
• Si los tres dados son seis, mostrar el mensaje “Excelente” 
• Si dos dados son seis, mostrar el mensaje “Muy bien”  
• Si un dado es seis, mostrar el mensaje “Regular”  
• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej12 : MonoBehaviour
{
    // Start is called before the first frame update
    public int d1;
    public int d2;
    public int d3;
    int cantSeis = 0;

    void Start()
    {
        if (d1 + d2 + d3 > 18 || d1 + d2 + d3 < 3)
        {
            Debug.Log("Datos ingresados incorrectamente");
        }
        else
        {
            if (d1 == 6)
            {
                cantSeis++;
            }

            if (d2 == 6)
            {
                cantSeis++;
            }
            if (d3 == 6)
            {
                cantSeis++;
            }
            switch (cantSeis)
            {
                case 1:
                    Debug.Log("Regular");
                    break;
                case 2:
                    Debug.Log("Muy Bien");
                    break;
                case 3:
                    Debug.Log("Excelente");
                    break;
                default:
                    Debug.Log("Insuficiente");
                    break;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
