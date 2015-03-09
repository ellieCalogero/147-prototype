using UnityEngine;
using System.Collections;

public class CylinderCollision : MonoBehaviour {

	public Transform target;
	public Transform follower; 
	public Transform checkpoint;

	public float speed;

	bool triggered=false;



	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (triggered == true)
		{
			target.position = Vector3.Lerp(target.position,checkpoint.position, speed * Time.deltaTime);
			//Application.LoadLevel("Level2");
		}

	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == ("Player"))
		{
			triggered=true;
		}
	}

	
}
