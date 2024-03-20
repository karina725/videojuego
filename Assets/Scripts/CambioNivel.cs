using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel: MonoBehaviour
{
    public bool pasarNivel;
    public int indiceNivel;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SiguienteNivel(indiceNivel);
        }
        
        if (pasarNivel)
        {
            SiguienteNivel(indiceNivel);
        }
    }

    public void SiguienteNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}