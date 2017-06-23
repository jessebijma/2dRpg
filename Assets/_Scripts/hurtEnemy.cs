using UnityEngine;
using System.Collections;

public class hurtEnemy : MonoBehaviour
{

	public int damageToGive;
	private int currentDamage;
	public GameObject hitEffect;

	public Transform hitPoint;
	public GameObject damageNumber;

	private playerStats thePs;
	
	void Start ()
	{
		thePs = FindObjectOfType<playerStats>();
	}
	
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "Enemy") {
			//Destroy (other.gameObject);
			Debug.Log("attacked");
			Debug.Log(hitPoint.position.x);
			Debug.Log(hitPoint.position.y);

			currentDamage = damageToGive + thePs.currentAttack;
			
			other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(currentDamage);
			Instantiate(hitEffect, hitPoint.position, hitPoint.rotation);
			//Debug.Log(hitPoint.position.x);
			var clone = (GameObject) Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
			clone.GetComponent<damageText>().damageNumber = currentDamage;
		}

	}
}
