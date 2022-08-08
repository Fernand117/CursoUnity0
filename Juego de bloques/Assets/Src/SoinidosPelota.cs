using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoinidosPelota : MonoBehaviour
{
    public AudioSource rebote;
    public AudioSource punto;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bloques"))
        {
            punto.Play();
        }
        else
        {
            rebote.Play();
        }
    }
}
