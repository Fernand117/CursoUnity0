using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text txtPuntos;
    public Transform contenedorBloques;
    public GameObject nivelCompletado;
    public GameObject juegoCompletado;
    public SiguienteNivel siguienteNivel;
    public Pelota pelota;
    public Personaje personaje;
    public SonidosFinPartida sonidosFinPartida;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarPuntos();
    }

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarPuntos();

        if (contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            personaje.enabled = false;

            if (siguienteNivel.UltimoNivel())
            {
                juegoCompletado.SetActive(true);
            }
            else
            {
                nivelCompletado.SetActive(true);
            }
            sonidosFinPartida.NivelCompletado();
            siguienteNivel.ActivarCarga();
        }
    }

    private void ActualizarPuntos()
    {
        txtPuntos.text = "Puntos: " + Puntos.puntos;
    }
}
