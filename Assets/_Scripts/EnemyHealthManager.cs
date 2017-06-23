using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class EnemyHealthManager : MonoBehaviour
{


	public int CurrentHealth;
	public int MaxHealth;

	private playerStats thePlayerStats;

	public int expToGive;
	
	void Start ()
	{
		CurrentHealth = MaxHealth;

		thePlayerStats = FindObjectOfType<playerStats>();
	}
	

	void Update () {
		if (CurrentHealth <= 0)
		{
			Destroy(gameObject);
			
			thePlayerStats.AddExperience(expToGive);
		}
	}

	public void HurtEnemy(int damageToGive)
	{
		CurrentHealth -= damageToGive;
	}

	public void SetMaxHealth()
	{
		CurrentHealth = MaxHealth;
	}
	
}
