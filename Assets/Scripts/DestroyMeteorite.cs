using UnityEngine;
using System.Collections;

public class DestroyMeteorite : MonoBehaviour {



    //public void OnCollisionEnter2D(Collision2D coll)
    //{
    //    Debug.Log("Destruye");

    //    Destroy(this.gameObject);

    //}

    public GameObject particula;

    public void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("1 "+name);
        if (col.gameObject.tag == "EarthMeteorite" || col.gameObject.tag == "IceMeteorite" || col.gameObject.tag == "FireMeteorite")
        {
            destruyeMeteorito(col.gameObject);
            GameManager.lives -= 1;
            //Debug.Log(GameManager.lives);
            //GameManager.nMeteoritos += 1;
        }


    }

    public void destruyeMeteorito(GameObject a)
    {
        
        Instantiate(particula, new Vector2(a.transform.position.x, a.transform.position.y), Quaternion.identity);
        Destroy(a);
    }
    
    }
