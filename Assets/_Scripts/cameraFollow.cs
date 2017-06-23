using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

	public Transform target;

	Camera mycam; 


	void Start () {
	
		mycam = GetComponent<Camera> ();

	}
	
	void FixedUpdate () {
	
		mycam.orthographicSize = (Screen.height / 100f) / 4f;

		if (target) {
				
			transform.position = Vector3.Lerp(transform.position, target.position + new Vector3(0, 0, -10), 0.1f);
		}

	}
}
