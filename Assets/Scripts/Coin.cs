using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Firestore;
using Firebase.Extensions;

public class Coin : MonoBehaviour
{
    public int valor = 1;
    public GameManager gameManager;
    public AudioClip sonidoMoneda;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        FirebaseFirestore db = FirebaseFirestore.DefaultInstance;
        if(collision.CompareTag("Player"))
        {
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
            AudioManager.Instance.ReproducirSonido(sonidoMoneda);

            if (gameManager.firebaseCreacion != null)
            {
                gameManager.firebaseCreacion.AddCoins(valor);
            }
            else
            {
                Debug.LogError("FirebaseCreacion no está asignado en el GameManager.");
            }
        }
        
    }
}
