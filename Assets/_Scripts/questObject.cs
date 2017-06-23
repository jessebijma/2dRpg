using UnityEngine;
using System.Collections;

public class questObject : MonoBehaviour
{

	public int questNumber;

	public questManager qm;

	public string startText;
	public string endText;
	
	void Start () {
	
	}
	
	void Update () {
	
	}

	public void StartQuestt()
	{
		qm.ShowQuestText(startText);
	}

	public void EndQuest()
	{
		qm.ShowQuestText(endText);
		qm.questsCompleted[questNumber] = true;
		gameObject.SetActive(false);
	}
}
