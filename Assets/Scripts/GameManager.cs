using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static int lives;

    public int points;

    public UIController ui;
    public bool muerto = false;

    public static int nMeteoritos = 0;

    public static float tiempoEntreMeteoritos = 5f;

    public static int nOleada = 5;

    public static int oleada = 1;

    public static bool spawn;



	// Use this for initialization
	void Start () {
        lives = 3;
        points = 0;
        nMeteoritos = 0;
        spawn = true;
        
        
	}
	
	// Update is called once per frame
	void Update () {

        if (lives <= 0)
        {
           // Debug.Log("GAMEOVER");
            GameOver();
            muerto = false;
        }

        if (nMeteoritos >= nOleada) {

            //Incrementa Oleada
            spawn = false;
            oleada++;
            nMeteoritos = 0;
            nOleada = nOleada + (nOleada / 2);
            StartCoroutine("nuevaOleadaCorrutina");
        }
	}

    IEnumerator nuevaOleadaCorrutina()
    {
        
        nuevaOleada();
        yield return new WaitForSeconds(1.5f);
        ui.objetoTexto.SetActive(false);
        yield return new WaitForSeconds(1f);
        //spawn = true;
    }

    public void GameOver()
    {
       
       // Debug.Log("GAMEOVER2");
        ui.textoPantalla.text = "GAMEOVER";
        ui.objetoTexto.SetActive(true);
        
        
    }

    public void nuevaOleada()
    {
        ui.textoPantalla.text = "Wave " +oleada;
        ui.objetoTexto.SetActive(true);
    }
}
