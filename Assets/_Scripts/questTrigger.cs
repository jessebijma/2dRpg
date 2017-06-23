using UnityEngine;
using System.Collections;

public class questTrigger : MonoBehaviour
{


	private questManager theQM;

	public int questNumber;

	public bool startQuest;
	public bool endQuest;
	
	void Start ()
	{
		theQM = FindObjectOfType<questManager>();
	}
	
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("1");
			if (!theQM.questsCompleted[questNumber])
			{
				Debug.Log("2");
				if (startQuest && !theQM.quests[questNumber].gameObject.activeSelf)
				{
					Debug.Log("3");
					theQM.quests[questNumber].gameObject.SetActive(true);
					theQM.quests[questNumber].StartQuestt();
				}

				if (endQuest && theQM.quests[questNumber].gameObject.activeSelf)
				{
					theQM.quests[questNumber].EndQuest();
				}
			}
		}
	}
}
