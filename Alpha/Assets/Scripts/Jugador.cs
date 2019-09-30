using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float vida,llaves;
    public float armadura;

   public bool intocable; 

    void Start()
    {
        
        llaves = 0;
        intocable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RecibirDaño(float daño) {
        if (intocable==false) { vida -= daño; }
       

       
    }
    public void AgregarMonedas(float mon) {

        llaves += mon;

    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
