using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField]
	private float upForce = 200f;
	public bool isDead = false;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if(isDead){
			return;
		}

		if(Input.GetKeyDown("space")){
			rb2d.velocity = Vector2.zero;
			rb2d.AddForce(new Vector2(0, upForce));
		}
		
	}

	void OnCollisionEnter2D(){
		isDead = true;
		rb2d.velocity = Vector2.zero;
		GameController.Instance.Die();
	}
}
