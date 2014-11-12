using UnityEngine;
using System.Collections;

public enum ROL {Personaje, Enemigo};
public enum TIPO {Personaje, Enemigo,BLOCK,WEAPON}

/*
 Life control for the player, attacks, enemies and breakable blocks
*/

public class Vida : MonoBehaviour {

	public TIPO Tipo;
	public ROL Rol;
	public Animator animador;
	public int VVida = 100;
	public int VidaMax = 300;

	void Awake(){
		
		animador = GetComponent<Animator> ();
		
	}

	//public GameObject createWhenDestroyed=null;
		
	public void AumentarVida(int qty) {
		VVida+=qty;
		if (VVida>VidaMax) VVida = VidaMax;
	}



	public void Hit(int power) {
		VVida -= power;
		animador.SetInteger("vida", VVida);

		/*if (life<=0) {
			//Player will not die for now
			if (name!="Personaje") {
				//Play destroy sound
				GameMain gm = Camera.main.GetComponent("GameMain") as GameMain;
				if (SFXDestroy!=null) {
					AudioSource.PlayClipAtPoint(SFXDestroy,Camera.main.transform.position);
				} else {
					AudioSource.PlayClipAtPoint(gm.SFXDestroy,Camera.main.transform.position);
				}
				//Change sprite to explosion
				SpriteRenderer sr =  gameObject.GetComponent("SpriteRenderer") as SpriteRenderer;
				sr.sprite = gm.SpriteDestroy;
				//And destroy after some time
				Destroy(gameObject,0.3f);
				// If there is something to create, instantiate it
				if (createWhenDestroyed) {
					Instantiate(createWhenDestroyed,gameObject.transform.position,gameObject.transform.rotation);
				}
			}
		} */
	}
}
