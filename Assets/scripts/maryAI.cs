using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maryAI : MonoBehaviour {

    public bool isAlive;

    // Use this for initialization
    void Start () {
        isAlive = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "falling")
        {
            isAlive = false;
        }
    }
}
