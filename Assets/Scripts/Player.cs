using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed;
	public float jumpForce;

	bool isGrounded = false; 


	void Start () {
	
	}
	

	void Update () {

		Movement ();
	}


	void Movement () //movement of the player
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate (Vector3.right*-speed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right*speed*Time.deltaTime);
		}
		
		if (isGrounded == true)
		{
			if (Input.GetKey(KeyCode.Space))
			{
				rigidbody.AddForce (Vector3.up* jumpForce,ForceMode.Impulse);
			}
		}
	}
	
	void OnCollisionEnter (Collision col) //checking if is grounded
	{
		if (col.gameObject.tag == "floor")
		{
			isGrounded=true; //if true, can jump;
		}
	}

	void OnCollisionExit (Collision col)
	{
		if (col.gameObject.tag == "floor")
		{
			isGrounded=false;
        }
	}

}
