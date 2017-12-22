using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
    {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		float moveUpDown = Input.GetAxis ("up/down");
		
		Vector3 movement = new Vector3 (moveHorizontal, moveUpDown, moveVertical);

		rb.AddForce(movement *speed );

    }
}

