using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed=5f;
	public float jumpSpeed=15f;
	
	// Use this for initialization

	private Vector2 moveDirection = Vector2.zero;

	void Start () {
	
	}
	
	// Update is called once per frame


	void FixedUpdate(){
		
		Rigidbody2D controller = GetComponent<Rigidbody2D> ();


		moveDirection = new Vector2 (Input.GetAxis("Horizontal"),0);
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;

		
		transform.position= new Vector2(Mathf.Clamp (transform.position.x, -9.00f, 9.00f),transform.position.y);




		if (Input.GetButton ("Jump")) {
		
			moveDirection.y = jumpSpeed;
		
		}

		controller.velocity = moveDirection * speed;
		
		/// if you  make 3d game use CharacterController instead of Rigidbody2D
	
		/// CharacterController controller = GetComponent<CharacterController>();
		/// controller.Move(moveDirection * );


	}
	void Update () {
		
		
		}
	}

