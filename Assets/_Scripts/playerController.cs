using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;


	private static bool playerExists;
	
	private bool attacking;
	public float attackTime;
	private float attackTimeCounter;
	public float speed = 1;

	public bool canMove;

	Text hp;
	private int currentHp = 100;

	// Use this for initialization
	void Start () {
	
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		canMove = true;

		Text instruction;
		instruction = GetComponent<Text>();

		if (!playerExists)
		{
			playerExists = true;
			DontDestroyOnLoad(transform.gameObject);
		}
		else
		{
			Destroy(gameObject);
		}

	}



	
	
	
	// Update is called once per frame
	void Update ()
	{

		if (!canMove)
		{
			rbody.velocity = Vector2.zero;
			return;
		}
		//transform.position += new Vector3(xPos, yPos, 0).normalized * speed * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.J)) {
			attackTimeCounter = attackTime;
			attacking = true;
			rbody.velocity = Vector2.zero;
			anim.SetBool ("isAttacking", true);
		}

	
		Vector2 movement_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")); 

		if (movement_vector != Vector2.zero) {
			anim.SetBool ("isWalking", true);
			anim.SetFloat ("input_x", movement_vector.x);
			anim.SetFloat ("input_y", movement_vector.y);

		} else {
			anim.SetBool ("isWalking", false);
		}

		rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime);


		if (attackTimeCounter > 0) {
			attackTimeCounter -= Time.deltaTime;
		}

		if (attackTimeCounter <= 0) {
			attacking = false;
			anim.SetBool ("isAttacking", false);
		}



	}

		}
	