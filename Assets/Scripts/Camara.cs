using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	public GameObject personaje;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (personaje.transform.position.y > (Camera.main.transform.position.y + 5)) {
			Camera.main.transform.Translate (0, 10, 0);
		}
		if (personaje.transform.position.y < (Camera.main.transform.position.y - 5)) {
			Camera.main.transform.Translate (0, -10, 0);
		}
		if (personaje.transform.position.x > (Camera.main.transform.position.x + 9)){
			Camera.main.transform.Translate(18,0,0);
		}
		if (personaje.transform.position.x < (Camera.main.transform.position.x - 9)){
			Camera.main.transform.Translate(-18,0,0);
		}

	}
}
