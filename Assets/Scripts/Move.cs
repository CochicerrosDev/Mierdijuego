using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 1f;
	public Animator animador;
	public float vely = 0f;
	public float velx = 0f;


	void Awake(){

		animador = GetComponent<Animator> ();

	}
	void Update ()
	{	
			vely=0;
			velx=0;
			
				if (Input.GetKey (KeyCode.RightArrow)) {
						velx = 1;
						//animador.SetFloat ("VelX", velx);
						transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0);
				} else if (Input.GetKey (KeyCode.LeftArrow)) {
						velx = -1;
						//animador.SetFloat ("VelX", velx);
						transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0);
				} else if (Input.GetKey (KeyCode.UpArrow)) {
						transform.position += new Vector3 (0.0f, speed * Time.deltaTime, 0);
						vely = 1;
						//animador.SetFloat ("VelY", vely);
				} else if (Input.GetKey (KeyCode.DownArrow)) {
						transform.position -= new Vector3 (0.0f, speed * Time.deltaTime, 0);
						vely = -1;
						//animador.SetFloat ("VelY", vely);
				} 
		animador.SetFloat ("VelX", velx);
		animador.SetFloat ("VelY", vely);

				
			}
}
