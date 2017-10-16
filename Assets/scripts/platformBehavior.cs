using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehavior : MonoBehaviour {

	public bool isOnCrane;
	public bool isSettled;

	Transform cranePos;

	// Use this for initialization
	void Start ()
	{
		isOnCrane = true;
		isSettled = false;

		cranePos = GameObject.Find("crane").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(isOnCrane)
		{
			Vector3 newPosition = new Vector3(cranePos.position.x, transform.position.y, 2.0f);
			transform.position = newPosition;

			if(Input.GetKeyDown(KeyCode.Space))
			{
				isOnCrane = false;
			}
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
			Instantiate(gameObject, new Vector3(0.0f, 3.41f, 0.0f), Quaternion.identity);
			isSettled = true;
            gameObject.tag = "resting";
        }
	}
}
