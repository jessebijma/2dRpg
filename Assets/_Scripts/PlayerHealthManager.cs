using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

	public int playerMaxHealth;
	public int playerCurrentHealth;


	void Start () {
		playerCurrentHealth = playerMaxHealth;
	}


	public void HurtPlayer (int damageToGive) {
		playerCurrentHealth -= damageToGive;
	}

	public void SetMaxHealth () {
		playerCurrentHealth = playerMaxHealth;
	}

	void Update () {
		if (playerCurrentHealth <= 0) {
			Debug.Log("dead");
			//gameObject.SetActive (false);


		}	
	}
}
