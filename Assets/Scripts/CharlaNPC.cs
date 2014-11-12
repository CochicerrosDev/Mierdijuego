using UnityEngine;
using System.Collections;

public class CharlaNPC : MonoBehaviour {
	
	private string texto = "Soy GAY";
	public TextMesh lugarDelTexto;
	public GameObject cuadro;


	void OnTriggerEnter2D(Collider2D other) {
		lugarDelTexto.text = texto;
		cuadro.SetActive (true);
	}

	void OnTriggerExit2D(Collider2D other) {
		lugarDelTexto.text = null;
				cuadro.SetActive (false);
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
