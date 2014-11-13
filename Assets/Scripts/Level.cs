using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	private int width;
	private int height;

	public Transform grass;
	public Transform stone;

	private Color[] colours;

	public Color grassColor;
	public Color stoneColor;
	public Color spawn;

	public Texture2D levelTexture;

	public Player player;

	// Use this for initialization
	void Start () {
		width = levelTexture.width;
		height = levelTexture.height;
		loadLevel();
	}

	void loadLevel() {
		colours = new Color[width * height];
		colours = levelTexture.GetPixels();

		for (int y=0; y<height; y++) {
			for(int x=0;x<width;x++) {
				if(colours[x+y*width] == grassColor){
					Instantiate(grass, new Vector3(x,y), Quaternion.identity);
				}
				if(colours[x+y*width] == stoneColor){
					Instantiate(stone, new Vector3(x,y), Quaternion.identity);
				}
			}
		}
	}
}
