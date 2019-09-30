using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas CanvasMuerte, canvasVictoria, canvasGeneral, canvasPausa;
    Jugador jugador;
    Slider slidervidaJugador;
    [SerializeField] TextMeshProUGUI Llaves;
    // Start is called before the first frame update
    void Start()
    {
        CanvasMuerte.enabled = false;
           jugador = FindObjectOfType<Jugador>();
        slidervidaJugador = canvasGeneral.GetComponentInChildren<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador.vida <= 0) {
            Time.timeScale = 0;
            CanvasMuerte.enabled = true;

        }
        Llaves.text = jugador.llaves.ToString();
        slidervidaJugador.value = jugador.vida / 100;
    }
    public void Reintentar() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Volver() {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
    bool paused;
    public void Pausa() {
        if (paused) {
            canvasPausa.enabled = false;
            Time.timeScale = 1;
            paused = false;
        } else { Time.timeScale =0;
            canvasPausa.enabled = true;
            paused = true;
        }
        
    }
}
