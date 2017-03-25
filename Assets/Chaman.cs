using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaman : MonoBehaviour {

    public Animator chaman;
	// Use this for initialization
	void Start () {
        chaman= this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void lanzaAnimacion()
    {
        chaman.Play("lanzamiento");
    }
}
