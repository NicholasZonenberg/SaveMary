using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craneScript : MonoBehaviour {

	public float speed = 0.1f;
	public float limit = 4.0f;

	// Use this for initialization
	void Start ()
	{
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-speed, 0.0f, 0.0f);
			if(transform.position.x < -limit)
			{
				transform.Translate(speed, 0.0f, 0.0f);
			}
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(speed, 0.0f, 0.0f);
			if(transform.position.x > limit)
			{
				transform.Translate(-speed, 0.0f, 0.0f);
			}
        }
    }
}
