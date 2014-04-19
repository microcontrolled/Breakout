using UnityEngine;
using System.Collections;

public class BallAction : MonoBehaviour {
	//Declare your global variables
	private Vector3 direction;
	private float speed;
	private bool flagger;
	// Use this for initialization
	void Start () {
		flagger = false;
	}
	
	// Update is called once per frame
	void Update () {
		//If the ball is still in place, move it if a touch or keystroke is detected
		if (flagger == false) {
			foreach (Touch touch in Input.touches) {
				if (touch.phase == TouchPhase.Began) {
					this.direction = new Vector3 (1.0f, 0f, 1.0f).normalized;
					this.speed = 0.5f;
					flagger = true;
				}
			}
			if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow))) {
				this.direction = new Vector3 (1.0f, 0f, 1.0f).normalized;
				this.speed = 0.5f;
				flagger = true;
			}
		}
		//If the ball is moving, change position based on direction and speed
		if (flagger == true) {
			this.transform.position += direction * speed;
			//Clamp this variable so the ball doesn't launch into the stratosphere
			this.direction.y = 0;
		}
	}
	// Changes direction when it colides with something
	void OnCollisionEnter(Collision collision)
	{
		Vector3 normal = collision.contacts[0].normal;
		direction = Vector3.Reflect(direction, normal);
		if (collision.gameObject.name == "BreakoutBrick") {
			GameObject.Destroy (collision.gameObject);
			int theScore = PlayerPrefs.GetInt ("currentscore");
			PlayerPrefs.SetInt ("currentscore",theScore+250);
		}
	}
}
