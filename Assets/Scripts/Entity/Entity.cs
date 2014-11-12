using UnityEngine;
using System.Collections;

public abstract class Entity : MonoBehaviour {

	public float speed;
	public Animator animador;
	public float vely = 0f;
	public float velx = 0f;

	void Awake(){
		
		animador = GetComponent<Animator> ();
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
