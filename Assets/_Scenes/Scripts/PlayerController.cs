using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		float MoveHorizontal = Input.GetAxis ("Horizontal");
		float MoveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (MoveHorizontal, 0, MoveVertical);

		rb.AddForce (movement * speed);
	}
}
