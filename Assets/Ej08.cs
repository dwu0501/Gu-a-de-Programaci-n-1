/*Crear una variable entera que pueda ser modificada desde el Inspector. 
 * Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día 
 * correspondiente al valor de la variable “dia”. Si el día no está en el rango 
 * permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08 : MonoBehaviour
{
    // Start is called before the first frame update
    public int dia;
    void Start()
    {

        switch (dia)
        {
            case 1:
                Debug.Log("El día de la semana es Domingo");
                break;
            case 2:
                Debug.Log("El día de la semana es Lunes");
                break;
            case 3:
                Debug.Log("El día de la semana es Martes");
                break;
            case 4:
                Debug.Log("El día de la semana es Miércoles");
                break;
            case 5:
                Debug.Log("El día de la semana es Jueves");
                break;
            case 6:
                Debug.Log("El día de la semana es Viernes");
                break;
            case 7:
                Debug.Log("El día de la semana es Sábado");
                break;
            default:
                Debug.Log("El día ingresado no es válido");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
