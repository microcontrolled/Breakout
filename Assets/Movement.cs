using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = this.transform.position;
		//Support for touchscreen devices
		foreach (Touch touch in Input.touches) {
				Vector3 touchy = touch.position;
			if ((touchy.x < (Screen.width/2)) && pos.x > -32f) {
					this.transform.position = new Vector3(pos.x - 0.5f, pos.y, pos.z);
				}
			if ((touchy.x > (Screen.width/2)) && pos.x < 30f) {
					this.transform.position = new Vector3(pos.x + 0.5f, pos.y, pos.z);
				}
		}
		//Keyboard support for debugging
		if (Input.GetKey(KeyCode.LeftArrow) && pos.x > -32f)
			this.transform.position = new Vector3(pos.x - 0.5f, pos.y, pos.z);
		if (Input.GetKey(KeyCode.RightArrow) && pos.x < 30f)
			this.transform.position = new Vector3(pos.x + 0.5f, pos.y, pos.z);
	}
	//Print the current score in the top left corner of the screen
	void OnGUI() {
		//Do the diddlyhopper
		int Score = PlayerPrefs.GetInt ("currentscore");
		//GUILayout.Label("Score: "+Score);
		GUI.skin.label.fontSize = 20;
		GUI.Label(new Rect(10,10, 600, 90), "Score: "+Score);
	}
}
