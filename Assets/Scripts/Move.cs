using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 1f;
	void Update ()
	{
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0);
		}
		else if(Input.GetKey(KeyCode.LeftArrow)){
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0);
		}
		else if(Input.GetKey(KeyCode.UpArrow)){
			transform.position += new Vector3 (0.0f, speed * Time.deltaTime, 0);
		}
		else if(Input.GetKey(KeyCode.DownArrow)){
			transform.position -= new Vector3 (0.0f, speed * Time.deltaTime, 0);
		}
	}
}
