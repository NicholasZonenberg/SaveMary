using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehavior : MonoBehaviour
{
	public float fallSpeed = 0.1f;
	public float craneY = 3.66f;

	private float height;
	private bool isOnCrane;
	private bool isSettled;
	private Transform cranePos;

    // Use this for initialization
    void Start ()
	{
		isOnCrane = true;
		isSettled = false;

		height = GetComponent<Transform>().lossyScale.y;

		cranePos = GameObject.Find("crane").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(isOnCrane)
		{
			Vector3 newPosition = new Vector3(cranePos.position.x, craneY - (height / 2.0f), 2.0f);
			transform.position = newPosition;

			if(Input.GetKeyDown(KeyCode.Space))
			{
				isOnCrane = false;
			}
		}

		if(!isOnCrane && !isSettled)
		{
			transform.Translate(0.0f, -fallSpeed, 0.0f);
		}
        if(isSettled)
        {
            
        }
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(!isSettled && !isOnCrane && (col.gameObject.tag=="resting" || col.gameObject.tag == "ground"))
		{
			Instantiate(gameObject, new Vector3(0.0f, craneY - (height / 2.0f), 0.0f), Quaternion.identity);
			isSettled = true;
            gameObject.tag = "resting";
        }
    }
}
