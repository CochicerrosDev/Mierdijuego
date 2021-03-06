﻿using UnityEngine;
using System.Collections;

public class Player : Entity {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		velx = 0;
		vely = 0;
		if (Vida <= 0) {
						transform.position = new Vector3 (0, 0, 0);
						Vida = 120;
				}

		if (Input.GetKey (KeyCode.RightArrow)) {
			velx = 1;
			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			velx = -1;
			rigidbody2D.transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			vely = 1;
			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {						
			vely = -1;
			rigidbody2D.transform.position += Vector3.down * speed * Time.deltaTime;
		}
		animador.SetFloat ("VelX", velx);
		animador.SetFloat ("VelY", vely);
		animador2.SetFloat ("vida", Vida);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			coll.gameObject.SendMessageUpwards("Golpe", Fuerza);
				}
		
	}
}
