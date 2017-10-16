using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risingWater : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		transform.position.Set(0.0f, -10.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(transform.position.y < -1.75)
		{
			transform.Translate(new Vector3(0.0f, 0.1f) * Time.deltaTime);
		}
	}
}
