using UnityEngine;
using System.Collections;

public class dialogueHolder : MonoBehaviour
{


	public string dialogue;
	private DialogueManager dManager;

	public string[] dialogueLines;
	
	void Start ()
	{
		dManager = FindObjectOfType<DialogueManager>();
	}
	
	void Update () {
	
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (Input.GetKeyUp(KeyCode.Space))
			{
				//dManager.ShowBox(dialogue);

				if (!dManager.dialogueActive)
				{
					dManager.dialogueLines = dialogueLines;
					dManager.currentLine = 0;
					dManager.ShowDialogue();
				}

				if (transform.parent.GetComponent<npcMovement>() != null)
				{
					transform.parent.GetComponent<npcMovement>().canMove = false;
				}
			}
		}
	}
}
