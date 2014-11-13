using UnityEngine;
using System.Collections;

//public enum ENEMYDIRECTION {UPDOWN,LEFTRIGHT};

/*
An enemy that goes and come back
*/

public class Enemy : Entity {
	
	public GameObject following;
	public float distance;
	public float damp = 2;
	//	public ENEMYDIRECTION movementDirection;
	//	public float movementLength;
	public Animator animador;

	
	//Life myLife;
	
	
	//	float currentDirectionIncrement;
	//	float currentLength = 0;
	float velx;
	float vely;
	//	float cero=0;
	
	
	void Start () {
		
	}
	
	void Update () 
	{
		vely=0;
		velx=0;
		
		
		if (following.rigidbody2D.transform.position.y > (rigidbody2D.transform.position.y + distance)) {
			vely = 1;
			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;
			
		} 
		//else if (following.rigidbody2D.transform.position.y == (rigidbody2D.transform.position.y + distance)) {}
		else {
			vely = -1;
			rigidbody2D.transform.position -= Vector3.up * speed * Time.deltaTime;
			
		}
		
		
		
		if (following.rigidbody2D.transform.position.x > (rigidbody2D.transform.position.x + distance)) {
			velx = 1;
			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;
			
		} 
		//else if (following.rigidbody2D.transform.position.x == (rigidbody2D.transform.position.x + distance)) {}
		else if ((rigidbody2D.transform.position.x + distance) > following.rigidbody2D.transform.position.x) {
			velx = -1;
			rigidbody2D.transform.position -= Vector3.right * speed * Time.deltaTime;
			
		}
		
		
		animador.SetFloat ("VelX", velx);
		animador.SetFloat ("VelY", vely);
		// EL CODIGO DESDE ESTE PUNTO SERIA PARA UN MOVIMIENTO CICLICO DEL PERSONAJE, VARIABLES LIFE PARA LA VIDA.
		/*velx = 0;

		//Stop movement if I am dead
	//	if (RoomManager.Instance.Pause || myLife.life<=0) return;

		if (movementDirection == ENEMYDIRECTION.LEFTRIGHT) {
						transform.position += new Vector3 (currentDirectionIncrement, 0, 0);
						if (currentDirectionIncrement >= cero) {
								velx = 1;
						} else {
								velx = -1;
						}
				}
		
		else {
						transform.position += new Vector3 (0, currentDirectionIncrement, 0);
				}
	
		currentLength += Mathf.Abs(currentDirectionIncrement);

		if (currentLength>=movementLength) {
			currentLength = 0;
			currentDirectionIncrement *= -1;
		}
		animador.SetFloat ("VelX", velx);
	}*/
	}
	void OnTriggerEnter2D(Collider2D other) {
		
	}
}