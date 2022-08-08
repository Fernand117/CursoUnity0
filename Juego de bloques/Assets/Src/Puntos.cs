using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text txtPuntos;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarPuntos();
    }

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarPuntos();
    }

    private void ActualizarPuntos()
    {
        txtPuntos.text = "Puntos: " + Puntos.puntos;
    }
}
