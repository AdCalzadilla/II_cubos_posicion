using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		this.transform.Translate ( Vector3.forward * moveVertical * speed);
		this.transform.Rotate ( Vector3.up * moveHorizontal * speed* 2.0f);
	}
}
