using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Rigidbody rig;
    public float velocidadInicial = 600f;
    private bool inGame = false;
    Vector3 posicionInicial;
    public Transform personaje;
    private void Awake()
    {
        //personaje = GetComponentInParent<Transform>();
        posicionInicial = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    public void Reset() 
    {
        transform.position = posicionInicial;
        transform.SetParent(personaje);
        inGame = false;
        DetenerMovimiento();
    }

    public void DetenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (!inGame && Input.GetButtonDown("Fire1"))
        {
            inGame = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));
        }
    }
}
