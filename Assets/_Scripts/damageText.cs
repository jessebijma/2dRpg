using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class damageText : MonoBehaviour
{


	public int moveSpeed;
	public int damageNumber;

	

	//public Transform hit;
	public Text displayNumber;
	void Start () {
		
	}
	
	void Update ()
	{
		displayNumber.text = "" + damageNumber;
		transform.position = new Vector3(transform.position.x, transform.position.y + 
		 (moveSpeed * Time.deltaTime), transform.position.z);
		//transform.position = new Vector3(hit.position.x, hit.position.y + (moveSpeed * Time.deltaTime), hit.position.z);
	}
}
