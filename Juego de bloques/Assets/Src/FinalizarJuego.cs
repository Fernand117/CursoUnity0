using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizarJuego : MonoBehaviour
{
    public bool salir;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (salir)
            {
                Debug.Log("Saliendo del juego");
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("Inicio");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vidas.totalVidas = 6;
            Puntos.puntos = 0;
            SceneManager.LoadScene("NivelUno");
        }
    }
}
