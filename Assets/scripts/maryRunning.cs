using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maryRunning : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move to the right
		transform.Translate (0.1f, 0, 0);

		// hits wall, start moving left
		if(transform.position.x >= 4)
		{
			transform.rotation = Quaternion.Euler (0, 180, 0);
		}

		// hits other wall, start moving right
		if (transform.position.x <= -4) 
		{
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
	}
}
