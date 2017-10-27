using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risingWater : MonoBehaviour
{
    private AudioSource source;
    public AudioClip platformDrop;

    public float initialY = -10.0f;
	public float speed = 0.1f;
	public float stopHeight = -1.75f;

	// Use this for initialization
	void Start ()
	{
		transform.position.Set(0.0f, initialY, 0.0f);

        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update ()
	{
		if(transform.position.y < stopHeight)
		{
			transform.Translate(new Vector3(0.0f, speed) * Time.deltaTime);
		}
	}
}
