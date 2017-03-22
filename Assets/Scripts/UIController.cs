using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    GameObject[] fireMeteorites;
    GameObject[] iceMeteorites;
    GameObject[] earthMeteorites;

    public GameObject objetoTexto;
    public Text textoPantalla;

    public Animator chaman;
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
      foreach (GameObject a in fireMeteorites)
        {
          //  chaman.SetBool("lanza", true);
            Destroy(a);
          //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyEarth()
    {
        earthMeteorites = GameObject.FindGameObjectsWithTag("EarthMeteorite");
        foreach (GameObject a in earthMeteorites)
        {
           // chaman.SetBool("lanza", true);
            Destroy(a);
          //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyIce()
    {
        iceMeteorites = GameObject.FindGameObjectsWithTag("IceMeteorite");
        foreach (GameObject a in iceMeteorites)
        {
           // chaman.SetBool("lanza", true);
            Destroy(a);
           // GameManager.nMeteoritos += 1;
        }
    }

}
