using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    GameObject[] fireMeteorites;
    GameObject[] iceMeteorites;
    GameObject[] earthMeteorites;

    public GameObject objetoTexto;
    public Text textoPantalla;

    public float desactivaBotonTiempo=0.5f;

    public Text score;

    public Text scoreGameOver;

    public Chaman chaman;

    public GameObject particula;

    public GameObject panel;

    public Text lives;

    public Button fuegoB;
    public Button aguaB;
    public Button tierraB;

    public GameObject particulaFuego;
    public GameObject particulaAgua;
    public GameObject particulaTierra;

    
    // Use this for initialization
    void Start () {
        objetoTexto.SetActive(false);
        score.text = "0";
        scoreGameOver.text = "0";
        lives.text = GameManager.lives.ToString();

        panel.SetActive(false);

	}

    
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void DestroyFire()
    {
      fireMeteorites= GameObject.FindGameObjectsWithTag("FireMeteorite");
        chaman.lanzaAnimacion();
        StartCoroutine("desactivaBoton");
        foreach (GameObject a in fireMeteorites)
        {
            //  chaman.SetBool("lanza", true);
            //  Destroy(a);
            destruyeMeteorito(a);
            GameManager.score += 1;
            cambiaPuntuacion();
            Instantiate(particulaFuego, particulaFuego.transform);
            //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyEarth()
    {
        earthMeteorites = GameObject.FindGameObjectsWithTag("EarthMeteorite");
        chaman.lanzaAnimacion();
        StartCoroutine("desactivaBoton");
        foreach (GameObject a in earthMeteorites)
        {
           // chaman.SetBool("lanza", true);
           // Destroy(a);
            destruyeMeteorito(a);
            GameManager.score += 1;
            cambiaPuntuacion();
           // Instantiate(particulaTierra, particulaTierra.transform);

            //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyIce()
    {
        iceMeteorites = GameObject.FindGameObjectsWithTag("IceMeteorite");
        chaman.lanzaAnimacion();
        StartCoroutine("desactivaBoton");
        foreach (GameObject a in iceMeteorites)
        {
            // chaman.SetBool("lanza", true);
            // Destroy(a);
            destruyeMeteorito(a);
            GameManager.score += 1;
            cambiaPuntuacion();
            //Instantiate(particulaAgua,new Vector2(particulaAgua.transform.position.x,particulaAgua.transform.position.y),Quaternion.identity);
            

            // GameManager.nMeteoritos += 1;
        }
    }
    public void destruyeMeteorito(GameObject a)
    {

        Instantiate(particula, new Vector2(a.transform.position.x, a.transform.position.y), Quaternion.identity);
        Destroy(a);
    }

    public void cambiaPuntuacion()
    {
        score.text = GameManager.score.ToString();
        scoreGameOver.text = GameManager.score.ToString();
    }

    public void muestraPanel()
    {
        panel.SetActive(true);

    }
    public void juegaDeNuevo()
    {
        
        SceneManager.LoadScene(0);
    }

    public void salirDelJuego()
    {
        Application.Quit();
    }
    public IEnumerator desactivaBoton()
    {
        fuegoB.interactable = false;
        tierraB.interactable = false;
        aguaB.interactable = false;
        yield return new WaitForSeconds(desactivaBotonTiempo);
        fuegoB.interactable = true;
        tierraB.interactable = true;
        aguaB.interactable = true;

    }
}
