using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maryRunning : MonoBehaviour 
{

    public bool onFloor = true;
    public float width = 8.0f;
    public float center = 0.0f;
    public float height = 0.05f;
	public float speed = 0.1f;
    public bool isAlive = true;
    private float blockHeight;

	// Use this for initialization
	void Start () 
	{
		blockHeight = GameObject.Find("platform").transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move to the right
		transform.Translate (speed, 0, 0);
        if (!isAlive)
        {
            speed = 0;
        }

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
			height = coll.gameObject.transform.localScale.y;
            transform.Translate(0, blockHeight, 0);
            center = coll.gameObject.transform.position.x;
            width = coll.gameObject.transform.localScale.x;
        }
        if (coll.gameObject.tag == "falling")
        {
            isAlive = false;
        }

        /*else if (coll.gameObject.tag == "wall")
		{
			transform.Rotate(0.0f, 180.0f, 0.0f);
		}*/
    }
}
