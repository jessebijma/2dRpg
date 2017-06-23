using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

	public GameObject dialogueBox;
	public Text DialogueText;

	public bool dialogueActive;

	public string[] dialogueLines;
	public int currentLine;


	private playerController thePlayer;
	
	void Start ()
	{
		thePlayer = FindObjectOfType<playerController>();
	}
	
	void Update () {
		if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
		{
			//dialogueBox.SetActive(false);
			//dialogueActive = false;
			currentLine++;
		}
		if (currentLine >= dialogueLines.Length)
		{
			dialogueBox.SetActive(false);
			dialogueActive = false;

			currentLine = 0;
			thePlayer.canMove = true;
		}

		DialogueText.text = dialogueLines[currentLine];

	}

	public void ShowBox(string dialogue)
	{
		dialogueActive = true;
		dialogueBox.SetActive(true);
		DialogueText.text = dialogue;
	}

	public void ShowDialogue()
	{
		dialogueActive = true;
		dialogueBox.SetActive(true);
		thePlayer.canMove = false;

	}
}
