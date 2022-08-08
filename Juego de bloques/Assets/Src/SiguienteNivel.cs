using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour
{
    public string nivelACargar;
    public float retraso;

    [ContextMenu("Activar Carga")]
    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }

    private void CargarNivel()
    {
        if (!UltimoNivel())
        {
            Vidas.totalVidas++;
        }
        SceneManager.LoadScene(nivelACargar);
    }

    public bool UltimoNivel()
    {
        return nivelACargar == "Inicio";
    }
}
