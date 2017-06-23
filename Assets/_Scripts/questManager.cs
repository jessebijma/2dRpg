using UnityEngine;
using System.Collections;


public class questManager : MonoBehaviour
{

	public questObject[] quests;
	public bool[] questsCompleted;

	public DialogueManager dManager;


	 
	void Start ()
	{
		questsCompleted = new bool[quests.Length];
	}
	
	void Update () {
		
	}

	public void ShowQuestText(string questText)
	{
		dManager.dialogueLines = new string[1];
		dManager.dialogueLines[0] = questText;

		dManager.currentLine = 0;
		dManager.ShowDialogue();
	}
}
