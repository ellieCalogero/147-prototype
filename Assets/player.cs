using UnityEngine;
using System.Collections;

public class player : MonoBehaviour 
{
	public float force;
	private bool Grounded = false;
	public float speed;
	public Transform respawn;



	void FixedUpdate () 
	{
		if (Input.GetKey (KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * Time.deltaTime * speed, Space.World);
		}
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Translate (-Vector3.right * Time.deltaTime * speed, Space.World);
		}
		// controllo se collide col terreno
		if (Grounded==true)
		{
			if (Input.GetKeyDown (KeyCode.Space))
			{
				rigidbody.AddForce (Vector3.up * force, ForceMode.Impulse);
			}
		}
	}
	//verifico se avviene la collisione col terrento, se collide allora è "true"
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "terrain")
		{
		Grounded = true;
		}
	}
	//(seconda condizione) quando non collide col terreno, allora esce dalla collisione e quindi diventa "false"
	void OnCollisionExit (Collision col)
	{
		if (col.gameObject.tag == "terrain")
		{
			Grounded = false;
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == ("death"))
		{
			transform.position = respawn.position;

		}
	}
	
}