using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionSuelo : MonoBehaviour
{
    public Vidas vidas;
    private void OnTriggerEnter() {
        vidas.PerderVidas();
    }
}
