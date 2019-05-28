using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = new Vector2(GameController.Instance.scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(GameController.Instance.isGameOver){
			rb2d.velocity = Vector2.zero;
		}
	}
}
