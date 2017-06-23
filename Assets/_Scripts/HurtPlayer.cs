using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {
	
	[SerializeField]
	private GameObject player;

	private int currentDamage;
	public int damageToGive;
	
	public GameObject damageNumber;

	private playerStats thePs;

	// Use this for initialization
	void Start ()
	{
		thePs = FindObjectOfType<playerStats>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			Debug.Log("player hit");

			currentDamage = damageToGive - thePs.currentDefence;
			if (currentDamage <= 0)
			{
				currentDamage = 1;
			}
			
			player.GetComponent<PlayerHealthManager> ().HurtPlayer (currentDamage);
			var clone = (GameObject) Instantiate(damageNumber, player.transform.position, Quaternion.Euler(Vector3.zero));
			clone.GetComponent<damageText>().damageNumber = currentDamage;
		}
	}
}