using UnityEngine;
using System.Collections;

public abstract class Entity : MonoBehaviour {

	public float speed;
	public Animator animador;
	public Animator animador2;
	public float vely = 0f;
	public float velx = 0f;
	public float Vida = 120f;
	public float VidaMax = 300f;
	public float Fuerza;




	void Awake(){
		
		animador = GetComponent<Animator> ();
		animador2 = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AumentarVida(float qty) {
		Vida+=qty;
		if (Vida>VidaMax) Vida = VidaMax;
	}

	public void Golpe(float fuerza) {
				Vida -= fuerza;

		}

}


