using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
				//PlayerPrefs.DeleteKey ("currentscore");
				PlayerPrefs.SetInt ("currentscore",0);
				Application.LoadLevel ("MainGame");
			}
		}
		if (Input.GetKey (KeyCode.Return)) {
			//PlayerPrefs.DeleteKey ("currentscore");
			PlayerPrefs.SetInt ("currentscore",0);
			Application.LoadLevel ("MainGame");
		}
	}
}
