using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    GameObject[] fireMeteorites;
    GameObject[] iceMeteorites;
    GameObject[] earthMeteorites;

    public GameObject objetoTexto;
    public Text textoPantalla;

    public Chaman chaman;

    public GameObject particula;
    // Use this for initialization
    void Start () {
        objetoTexto.SetActive(false);
	}

    
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void DestroyFire()
    {
      fireMeteorites= GameObject.FindGameObjectsWithTag("FireMeteorite");
        chaman.lanzaAnimacion();
        foreach (GameObject a in fireMeteorites)
        {
            //  chaman.SetBool("lanza", true);
            //  Destroy(a);
            destruyeMeteorito(a);
            
          //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyEarth()
    {
        earthMeteorites = GameObject.FindGameObjectsWithTag("EarthMeteorite");
        chaman.lanzaAnimacion();
        foreach (GameObject a in earthMeteorites)
        {
           // chaman.SetBool("lanza", true);
           // Destroy(a);
            destruyeMeteorito(a);
            
            //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyIce()
    {
        iceMeteorites = GameObject.FindGameObjectsWithTag("IceMeteorite");
        chaman.lanzaAnimacion();
        foreach (GameObject a in iceMeteorites)
        {
            // chaman.SetBool("lanza", true);
            // Destroy(a);
            destruyeMeteorito(a);
            
            // GameManager.nMeteoritos += 1;
        }
    }
    public void destruyeMeteorito(GameObject a)
    {

        Instantiate(particula, new Vector2(a.transform.position.x, a.transform.position.y), Quaternion.identity);
        Destroy(a);
    }

}
