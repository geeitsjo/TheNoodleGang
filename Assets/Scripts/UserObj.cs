using UnityEngine;
using System.Collections;

public class UserObj : MonoBehaviour {

	float maxSpeed=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos=transform.position;
		//y-axis controls
		pos.y += Input.GetAxis ("Vertical")*maxSpeed*Time.deltaTime; //return float from -1.0 to +1.0
		transform.position=pos;

		//x-axis controls
		pos.x += Input.GetAxis ("Horizontal")*maxSpeed*Time.deltaTime; //return float from -1.0 to +1.0
		transform.position=pos;
	
	}//end of vertical
}
