using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public static int totalVidas = 6;
    public Text txtVidas;
    public Pelota pelota;
    public Personaje personaje;
    
    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;

    public SonidosFinPartida sonidosFinPartida;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcador();
    }

    // Update is called once per frame
    public void PerderVidas()
    {
        if (totalVidas <= 0) return;
        Vidas.totalVidas--;
        ActualizarMarcador();
        if (totalVidas <= 0)
        {
            sonidosFinPartida.GameOver();
            gameOver.SetActive(true);
            pelota.DetenerMovimiento();
            personaje.enabled = false;

            siguienteNivel.nivelACargar = "Inicio";
            siguienteNivel.ActivarCarga();
        }
        else
        {
            personaje.Reset();
            pelota.Reset();
        }
    }

    private void ActualizarMarcador()
    {
        txtVidas.text = "Vidas: " + Vidas.totalVidas;
    }
}
