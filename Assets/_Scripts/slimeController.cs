
using UnityEngine;
using System.Collections;

public class slimeController : MonoBehaviour {

	public GameObject HealthBar1;

	public float moveSpeed;

	private Rigidbody2D myRigidbody;

	private bool isMoving;

	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;

	public Vector3 moveDirection;

	public float waitToReload;
	private bool reloading;
	private GameObject thePlayer;
	public float waitingTime;
	private bool enumtimer;

	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();

		StartCoroutine(timer());
	}
	
	void Update () {
		
		if (enumtimer) {
			StartCoroutine (timer ());
		}
	
		if (isMoving) {

			timeToMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = moveDirection;

			if(timeToMoveCounter <= 0f) {

				isMoving = false;
				timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);

			}

		} else {
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = Vector2.zero;


			if(timeBetweenMoveCounter <= 0f) {
				
				isMoving = true;
				timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);


		}

	}


	}



	void Move(){
		moveDirection = new Vector3 (Random.Range (-0.5f, 0.5f) * moveSpeed, Random.Range (-0.5f, 0.5f) * moveSpeed, 0f);
	}

	public IEnumerator timer(){
		enumtimer = false;
			waitingTime = Random.Range (2, 3);
		Move ();
			yield return new WaitForSeconds (waitingTime);

			enumtimer = true;


		}
	}





