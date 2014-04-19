using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 pos = this.transform.position;
		int x = (int)pos.x;
		int z = (int)pos.z;
		switch (Mathf.Abs((x/10)+(z/10))) {
		case 6: {
			renderer.material.color = Color.blue;
			break;
		}
		case 5: {
			renderer.material.color = Color.cyan;
			break;
		}
		case 4: {
			renderer.material.color = Color.green;
			break;
		}
		case 3: {
			renderer.material.color = Color.magenta;
			break;
		}
		case 2: {
			renderer.material.color = Color.yellow;
			break;
		}
		case 1: {
			renderer.material.color = Color.white;
			break;
		}
		case 0: {
			renderer.material.color = Color.grey;
			break;
		}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy ()
	{
		DestroyImmediate(renderer.material);
	}
}
