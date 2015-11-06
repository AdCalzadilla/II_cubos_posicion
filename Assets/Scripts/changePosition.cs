using UnityEngine;
using System.Collections;

public class changePosition : MonoBehaviour {

	public int contador;
	public GameObject cube0;
	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	public GameObject cube5;

	private Vector3 pos0 = new Vector3 (-0.03f, 0.5f, 3.56f);
	private Vector3 pos1 = new Vector3 (3.36f,0.5f,2.43f);
	private Vector3 pos2 = new Vector3 (3.36f,0.5f,-1.69f);
	private Vector3 pos3 = new Vector3 (0.03f,0.5f,-3.44f);
	private Vector3 pos4 = new Vector3 (-3.39f,0.5f,-1.55f);
	private Vector3 pos5 = new Vector3 (-3.39f,0.5f,2.4f);

	// Use this for initialization
	void Start () {
		contador = 0;
		cube0.transform.position = pos0;
		cube1.transform.position = pos1;
		cube2.transform.position = pos2;
		cube3.transform.position = pos3;
		cube4.transform.position = pos4;
		cube5.transform.position = pos5;

	}
	
	// Update is called once per frame
	void Update () {
		if (contador == 0) {
			if (Input.GetButtonDown ("Jump")) {
				contador ++;
				cube0.transform.position= pos5;
				cube1.transform.position= pos4;
				cube2.transform.position= pos3;
				cube3.transform.position= pos2;
				cube4.transform.position= pos1;
				cube5.transform.position= pos0;
			}
		}

		else if(contador == 1){
			if (Input.GetButtonDown ("Jump")) {
				contador ++;
				cube0.transform.position= pos0;
				cube1.transform.position= pos5;
				cube2.transform.position= pos4;
				cube3.transform.position= pos3;
				cube4.transform.position= pos2;
				cube5.transform.position= pos1;
			}
		}

		else if(contador == 2){
			if (Input.GetButtonDown ("Jump")) {
				contador ++;
				cube0.transform.position= pos1;
				cube1.transform.position= pos0;
				cube2.transform.position= pos5;
				cube3.transform.position= pos4;
				cube4.transform.position= pos3;
				cube5.transform.position= pos2;
			}
		}

		else if(contador == 3){
			if (Input.GetButtonDown ("Jump")) {
				contador ++;
				cube0.transform.position= pos2;
				cube1.transform.position= pos1;
				cube2.transform.position= pos0;
				cube3.transform.position= pos5;
				cube4.transform.position= pos4;
				cube5.transform.position= pos3;
			}
		}

		else if(contador == 4){
			if (Input.GetButtonDown ("Jump")) {
				contador ++;
				cube0.transform.position= pos3;
				cube1.transform.position= pos2;
				cube2.transform.position= pos1;
				cube3.transform.position= pos0;
				cube4.transform.position= pos5;
				cube5.transform.position= pos4;
			}
		}

		else if(contador == 5){
			if (Input.GetButtonDown ("Jump")) {
				contador = 0;
				cube0.transform.position= pos0;
				cube1.transform.position= pos1;
				cube2.transform.position= pos2;
				cube3.transform.position= pos3;
				cube4.transform.position= pos4;
				cube5.transform.position= pos5;
			}
		}
	}
}
