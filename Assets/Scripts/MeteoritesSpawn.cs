using UnityEngine;
using System.Collections;

public class MeteoritesSpawn : MonoBehaviour {

    public GameObject fireMeteorite;
    public GameObject earthMeteorite;
    public GameObject iceMeteorite;

    public Transform spawnPosition;

    public bool spawn;



	// Use this for initialization
	void Start () {
        spawnPosition = this.transform;
        spawn = true;
        Debug.Log("Entrooo start");
        //InvokeRepeating("Spawn", 2, GameManager.tiempoEntreMeteoritos);
        
    }
	
	// Update is called once per frame
	void Update () {

        if (GameManager.spawn)
        {
            
            
            if(GameManager.nMeteoritos< GameManager.nOleada)
            {
                Debug.Log("noleada " + GameManager.nOleada);
                Debug.Log("nMeteo " + GameManager.nMeteoritos);
                GameManager.spawn = false;
                GameManager.nMeteoritos++;
                StartCoroutine("spawnMeteorito");
            }
        }

      
	
	}

    public IEnumerator spawnMeteorito()
    {
        GameManager.spawn = false;
        Spawn();
        
        yield return new WaitForSeconds(GameManager.tiempoEntreMeteoritos);

        if (GameManager.nMeteoritos < GameManager.nOleada)
        {
            GameManager.spawn = true;
        }
            
    }

    public void Spawn()
    {
        
        int i = Random.Range(1, 4);
        //  yield return new WaitForSeconds(Random.Range(1f, 4f));
        // Debug.Log("Paso Corrutina Spawn");

        switch (i)
        {
            case 1:
                Instantiate(fireMeteorite, new Vector2(spawnPosition.position.x-Random.Range(0,5),spawnPosition.position.y), Quaternion.identity);
               // Debug.Log("Meteorito Fuego");
                spawn = false;
                break;
            case 2:
                Instantiate(earthMeteorite, new Vector2(spawnPosition.position.x - Random.Range(0, 5), spawnPosition.position.y), Quaternion.identity);
               // Debug.Log("Meteorito Tierra");
                spawn = false;
                break;
            case 3:
                Instantiate(iceMeteorite, new Vector2(spawnPosition.position.x - Random.Range(0, 5), spawnPosition.position.y), Quaternion.identity);
                //Debug.Log("Meteorito Hielo");
                spawn = false;
                break;
            default:
                break;
        }
        //StartCoroutine("WaitBetweenMeteorites");
    }

    IEnumerator WaitBetweenMeteorites()
    {
        yield return new WaitForSeconds(5f);
        spawn = true;
    }
}
