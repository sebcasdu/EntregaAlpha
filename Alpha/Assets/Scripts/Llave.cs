﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    Jugador jugador;
    // Start is called before the first frame update
    void Start()
    {
        jugador = FindObjectOfType<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(gameObject.transform.position, jugador.transform.position) < 5) { transform.position = Vector3.MoveTowards(gameObject.transform.position, jugador.transform.position, 3*Time.deltaTime); }
  
       
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Jugador>() != null)
        {
            jugador.GetComponent<Jugador>().AgregarMonedas(1);
            Destroy(gameObject);
        }

    }
}
