using UnityEngine;
using System.Collections;

public class destroyText : MonoBehaviour
{


	public float timeToDestroy;
	
	void Start () {
	
	}
	
	void Update ()
	{
		timeToDestroy -= Time.deltaTime;


		if (timeToDestroy <= 0)
		{
			Destroy(gameObject);
		}
	}
}
