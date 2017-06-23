using System;
using UnityEngine;
using System.Collections;
using System.Timers;

public class spawnEnemies : MonoBehaviour
{

	public int[] maxEnemies;
	public int currentEnemies;
	public float timeToSpawn;

	public GameObject enemy;
	
	void Start () {
		//get enemy reference
		
		enemy = (GameObject) Resources.Load("Assets/Prefabs/Enemies/bee", typeof(GameObject));		
	}
	
	void Update () {
		//check current enemies
		// if < max enemies
		if (currentEnemies < maxEnemies.Length)
		{
			Spawn();
		}
		// timer
		// instantiate enemy
		//update current enemies
		
	}

	void Spawn()
	{
		timeToSpawn = Time.deltaTime + 3;
		Instantiate(enemy);
		currentEnemies = maxEnemies.Length;
	}
}
