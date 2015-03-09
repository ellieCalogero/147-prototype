using UnityEngine;
using System.Collections;

public class TargetFollow : MonoBehaviour {


	public Transform follower; 
	public Transform myTransform;
	public Transform checkpoint;

	public float maxDistance;
	public float moveSpeed;

	bool colliding = false;
	bool entered =false;


	void Awake ()
	{
		myTransform = transform; 
	}

	void Update () {

		if (colliding == true) 
		{
			//max distance from Empty GameObject follower and target
				if (Vector3.Distance(follower.position, myTransform.position)> maxDistance)  
			{ //interpolation from follower position to target position
              myTransform.position = Vector3.Lerp(follower.position,myTransform.position,moveSpeed* Time.deltaTime);
			}
		}
		if (entered == true)
		{
			myTransform.position = Vector3.Lerp(myTransform.position,checkpoint.position,moveSpeed* Time.deltaTime);
			//Application.LoadLevel("147");
		}

	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag ==("Player")) //checking if there is a collision with player
		{
			colliding=true;
		}

		if (col.gameObject.tag ==("Player"))
		{
			colliding=false;
			entered=true;
		}
	}
	
}

	