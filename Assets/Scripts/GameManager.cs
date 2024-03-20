using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FirebaseCreacion firebaseCreacion; 

    public int PuntosTotales { get { return puntosTotales; } }

    private int puntosTotales;

    private void Awake()
    {
        firebaseCreacion = FindObjectOfType<FirebaseCreacion>(); 
        if (firebaseCreacion == null)
        {
            Debug.LogError("No se encontró el objeto FirebaseCreacion en la escena.");
        }
    }

    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Debug.Log("Puntos Totales: " + puntosTotales);
        
        if (firebaseCreacion != null)
        {
          
            firebaseCreacion.ActualizarPuntosEnFirestore(puntosTotales);
        }
        else
        {
            Debug.LogWarning("La referencia a FirebaseCreacion no está establecida.");
        }
    }
}
