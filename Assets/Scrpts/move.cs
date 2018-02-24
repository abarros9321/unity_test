using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public float speed;
	public float jumpValue;
	private Rigidbody rigidbody;
	private AudioSource audio;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		audio = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && Mathf.Abs (rigidbody.velocity.y) < 0.01f) {
			rigidbody.AddForce (Vector3.up * jumpValue, ForceMode.Impulse);
			audio.Play();
		}
	}

	void FixedUpdate(){
		rigidbody.AddForce (new Vector3(Input.GetAxis("Horizontal"),
			0,
			Input.GetAxis("Vertical")) * speed
		);
	}
}
