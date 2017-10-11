using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehavior : MonoBehaviour {

	public bool isOnCrane;
	public bool isFalling;
	public bool isSettled;

	// Use this for initialization
	void Start ()
	{
		isOnCrane = true;
		isFalling = false;
		isSettled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space) && !isFalling && !isSettled)
		{
			isOnCrane = false;
			isFalling = true;
		}

		if(isFalling)
		{
			transform.Translate(0.0f, -0.1f, 0.0f);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		isFalling = false;
		isSettled = true;

		//GameObject newBlock = Instantiate(gameObject);
		//newBlock.transform.position.Set(0.0f, 2.96f, 0.0f);
	}
}
