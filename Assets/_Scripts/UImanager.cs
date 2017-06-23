using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{

	private static bool UIExists;
	
	
	public Slider healthBar;
	public Text hpText;
	public Text lvlText;
	public PlayerHealthManager playerHealth;

	private playerStats thePS;
	
	
	void Start () {
		if (!UIExists)
		{
			UIExists = true;
			DontDestroyOnLoad(transform.gameObject);
		}
		else
		{
			Destroy(gameObject);
		}

		thePS = GetComponent<playerStats>();

	}
	
	void Update ()
	{
		healthBar.maxValue = playerHealth.playerMaxHealth;
		healthBar.value = playerHealth.playerCurrentHealth;
		hpText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
		lvlText.text = "Lvl: " + thePS.currentLevel;
	}
}
