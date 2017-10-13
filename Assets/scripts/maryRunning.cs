using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maryRunning : MonoBehaviour 
{

    public bool onFloor;
    public float width;
    public float center;
    public float height;

	// Use this for initialization
	void Start () 
	{
        onFloor = true;
        width = 8;
        height = 0.075f;
        center = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move to the right
		transform.Translate (0.1f, 0, 0);

        if (transform.position.x >= center + width / 2)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        
        if (transform.position.x <= center - width / 2)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "resting")
        {
            height += 1;
            transform.Translate(0, height, 0);
            center = coll.gameObject.transform.position.x;
            width = coll.gameObject.transform.localScale.x;
        }
    }
}
