using UnityEngine;
using System.Collections;

public class musicSwitcher : MonoBehaviour {

	private musicController theMC;

	public int newTrack;

	public bool switchOnStart;

	// Use this for initialization
	void Start () {
		theMC = FindObjectOfType<musicController> ();

		if (switchOnStart) {
			theMC.SwitchTrack (newTrack);
			gameObject.SetActive (false);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			theMC.SwitchTrack (newTrack);
			gameObject.SetActive (false);
		}
	}

}
