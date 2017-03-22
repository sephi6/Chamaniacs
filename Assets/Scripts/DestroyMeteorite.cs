using UnityEngine;
using System.Collections;

public class DestroyMeteorite : MonoBehaviour {



    //public void OnCollisionEnter2D(Collision2D coll)
    //{
    //    Debug.Log("Destruye");

    //    Destroy(this.gameObject);
    //}
    public void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("1 "+name);
        if (col.gameObject.tag == "EarthMeteorite" || col.gameObject.tag == "IceMeteorite" || col.gameObject.tag == "FireMeteorite")
        {
            Destroy(col.gameObject);
            GameManager.lives -= 1;
            //Debug.Log(GameManager.lives);
            //GameManager.nMeteoritos += 1;
        }


    }
    
    }
