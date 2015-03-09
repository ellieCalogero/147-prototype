using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public float vanishTime;

	void Awake () 
	{
		Reappear ();
	}

	void Start () 
	{
		StartCoroutine (Vanishing (2.0f));
		
	}


//	void OnCollisionEnter (Collision hit)
//	{
//		if (hit.gameObject.tag == "Player") 
//		{
//			Invoke ("Vanish", vanishTime);
//			Debug.Log ("About to vanish!!!");
//		}
//	}
//	



	IEnumerator Vanishing (float vanishTime)
	{
		Vanish ();
		yield return new WaitForSeconds (5f);
	}



	void Vanish()
	{
		this.transform.renderer.enabled = false;

	}
	void Reappear()
	{

		this.transform.renderer.enabled = true;
	}




}
