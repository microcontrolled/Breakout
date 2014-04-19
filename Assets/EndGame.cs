using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	private GameObject disObj;
	// Use this for initialization
	void Start () {
		disObj = GameObject.Find ("LevelComplete");
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if ((touch.phase == TouchPhase.Began) && (disObj.renderer.enabled == true)) {
				Application.LoadLevel ("MainGame");
			}
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Ball") {
			GameObject.Destroy (collision.gameObject);
			disObj.renderer.enabled = true;
		}
	}
}
