using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    GameObject[] fireMeteorites;
    GameObject[] iceMeteorites;
    GameObject[] earthMeteorites;

    public GameObject objetoTexto;
    public Text textoPantalla;
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
            Destroy(a);
          //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyEarth()
    {
        earthMeteorites = GameObject.FindGameObjectsWithTag("EarthMeteorite");
        foreach (GameObject a in earthMeteorites)
        {
            Destroy(a);
          //  GameManager.nMeteoritos += 1;
        }
    }
    public void DestroyIce()
    {
        iceMeteorites = GameObject.FindGameObjectsWithTag("IceMeteorite");
        foreach (GameObject a in iceMeteorites)
        {
            Destroy(a);
           // GameManager.nMeteoritos += 1;
        }
    }
}
