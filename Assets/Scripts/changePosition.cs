using UnityEngine;
using System.Collections;

public class changePosition : MonoBehaviour {

	public GameObject cube;
	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	public GameObject cube5;

	// Use this for initialization
	void Start () {
		cube.transform.position = new Vector3 (-0.03f, 0.5f, 3.56f);
		cube1.transform.position = new Vector3 (3.36f,0.5f,2.43f);
		cube2.transform.position = new Vector3 (3.36f,0.5f,-1.69f);
		cube3.transform.position = new Vector3 (0.03f,0.5f,-3.44f);
		cube4.transform.position = new Vector3 (-3.39f,0.5f,-1.55f);
		cube5.transform.position = new Vector3 (-3.39f,0.5f,2.4f);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			cube.transform.position= new Vector3(cube1.transform.position.x, cube1.transform.position.y, cube1.transform.position.z);
			cube1.transform.position= new Vector3(cube2.transform.position.x, cube2.transform.position.y, cube2.transform.position.z);
			cube2.transform.position= new Vector3(cube3.transform.position.x, cube3.transform.position.y, cube3.transform.position.z);
			cube3.transform.position= new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z);
			cube4.transform.position= new Vector3(cube5.transform.position.x, cube5.transform.position.y, cube5.transform.position.z);
			cube5.transform.position= new Vector3(cube4.transform.position.x, cube4.transform.position.y, cube4.transform.position.z);
		}
	}
}
