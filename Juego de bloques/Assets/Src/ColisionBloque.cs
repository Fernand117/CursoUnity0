using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBloque : MonoBehaviour
{
    public GameObject particulas;
    public Puntos puntos;
    private void OnCollisionEnter()
    {
        Instantiate(particulas, transform.position, Quaternion.identity);
        puntos.GanarPunto();
        Destroy(gameObject);
    }
}
