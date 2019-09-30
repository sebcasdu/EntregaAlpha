using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaCombate : MonoBehaviour
{
    [SerializeField] Collider dashCollider;
    [SerializeField] Collider golpeLateralCollider;
    [SerializeField] Collider golpeArribaCollider;
    [SerializeField] GameObject particulasGolpe;
    [SerializeField] GameObject golpeEfecto,golpeEfecto1;
    private bool attackStand;
    Jugador jugador;

    // Start is called before the first frame update
    void Start()
    {
        golpeEfecto.SetActive(false);
        golpeEfecto1.SetActive(false);
        jugador = FindObjectOfType<Jugador>();
        golpeArribaCollider.enabled = false;
        dashCollider.enabled = false;
        golpeLateralCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            attackStand = true;
        }



        if (attackStand)
        {
            particulasGolpe.SetActive(true);
        }
        else { particulasGolpe.SetActive(false); }


        if (attackStand)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                StartCoroutine(GolpeArriba());
                attackStand = false;

            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                StartCoroutine(GolpeAdelante());
               
                attackStand = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                StartCoroutine(GolpeAdelante());

                attackStand = false;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {

                GolpeAbajo();
                attackStand = false;
            }
        }
        

    }

    
    public void DashAtack() {

        if (dashCollider.enabled)
        {

            dashCollider.enabled = false;
        }else
        {

            
            dashCollider.enabled = true;
          
        }
      

    }
    public IEnumerator GolpeAdelante() {
        jugador.intocable = true;

        golpeEfecto.SetActive(true);
        golpeLateralCollider.enabled = true;
        

        yield return new WaitForSeconds(0.1f);

        golpeEfecto.SetActive(false);
        golpeLateralCollider.enabled = false;
        jugador.intocable = false;

    }
    public  IEnumerator GolpeArriba() {
        golpeEfecto1.SetActive(true);
        jugador.intocable = true;
        golpeArribaCollider.enabled = true;
        yield return new WaitForSeconds(0.1f);
        golpeArribaCollider.enabled = false;
        jugador.intocable = false;
        golpeEfecto1.SetActive(false);
    }
    public IEnumerator GolpeAbajo() {

        yield return new WaitForSeconds(0.5f);
    }
}
