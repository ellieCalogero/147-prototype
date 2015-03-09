using UnityEngine;
using System.Collections;

public class MovBase : MonoBehaviour 
{
	public float speed;
	static bool go_left = false;

	void Update () 
	{
		if (go_left)
		{
			Vector3 TP = transform.position;
			TP.x -= speed * Time.deltaTime;
			transform.position = TP;
		} 
		else 
		{
			Vector3 TP = transform.position;
			TP.x += speed * Time.deltaTime;
			transform.position = TP;
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "wall_Left")
		{
			go_left = false;
		}
		else if (col.gameObject.name == "wall_Right")
		{
			go_left = true;
		}
	}


}
