using UnityEngine;
using System.Collections;

public class npcMovement : MonoBehaviour
{

	private Vector2 minPoint;
	private Vector2 maxPoint;
	
	public float moveSpeed;
	public float walkTime;
	public float waitTime;
	private float walkCounter;
	private float waitCounter;
	
	private Rigidbody2D rb;
	public Collider2D walkArea;
	
	public bool isMoving;
	private bool hasWalkArea;
	private int walkDirection;

	public bool canMove;

	private DialogueManager theDM;

	
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		waitCounter = waitTime;
		walkCounter = walkTime;
		theDM = FindObjectOfType<DialogueManager>();
		
		ChooseDirection();

		if (walkArea != null)
		{
			minPoint = walkArea.bounds.min;
			maxPoint = walkArea.bounds.max;
			hasWalkArea = true;
		}


		canMove = true;
	}
	
	void Update () {

		if (!theDM.dialogueActive)
		{
			canMove = true;
		}
		
		if (!canMove)
		{
			rb.velocity = Vector2.zero;
			return;
		}
		
		if (isMoving)
		{
			walkCounter -= Time.deltaTime;

			

			switch (walkDirection)
			{
				
				case 0: 
					rb.velocity = new Vector2(0, moveSpeed);
					if (hasWalkArea && transform.position.y > maxPoint.y)
					{
						isMoving = false;
						waitCounter = waitTime;
					}
					break;
					
				case 1:
					rb.velocity = new Vector2(moveSpeed, 0);
					if (hasWalkArea && transform.position.x > maxPoint.x)
					{
						isMoving = false;
						waitCounter = waitTime;
					}

					break;
					
				case 2:
					rb.velocity = new Vector2(0, -moveSpeed);
					if (hasWalkArea && transform.position.y < minPoint.y)
					{
						isMoving = false;
						waitCounter = waitTime;
					}

					break;
					
				case 3:
					rb.velocity = new Vector2(-moveSpeed, 0);
					if (hasWalkArea && transform.position.x < minPoint.x)
					{
						isMoving = false;
						waitCounter = waitTime;
					}

					break;
					
			}
			
			if (walkCounter < 0)
			{
				isMoving = false;
				waitCounter = waitTime;
			}
			
	}
		else
		{
			waitCounter -= Time.deltaTime;
			
			rb.velocity = Vector2.zero;
	

			if (waitCounter < 0)
			{
				ChooseDirection();
			}
			
			
		}
	}


	public void ChooseDirection()
	{
		walkDirection = Random.Range(0, 4);
		isMoving = true;
		walkCounter = walkTime;
	}
}
