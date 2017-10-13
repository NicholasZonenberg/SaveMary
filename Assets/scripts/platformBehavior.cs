using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehavior : MonoBehaviour {

	public bool isOnCrane;
	public bool isSettled;

	// Use this for initialization
	void Start ()
	{
		isOnCrane = true;
		isSettled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space) && isOnCrane)
		{
			isOnCrane = false;
		}

		if(!isOnCrane && !isSettled)
		{
			transform.Translate(0.0f, -0.1f, 0.0f);
		}
        if(isSettled)
        {
            
        }
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(!isSettled && !isOnCrane)
		{
			Instantiate(gameObject, new Vector3(0.0f, 2.96f, 0.0f), Quaternion.identity);
			isSettled = true;
            gameObject.tag = "resting";
        }
	}
}
