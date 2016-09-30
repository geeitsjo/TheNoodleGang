using UnityEngine;
using System.Collections;

public class CreatureObj : MonoBehaviour {
//	float maxSpeed = 5f;
//	float rotSpeed=180f;

	[HideInInspector]
	public float speed;
	private Rigidbody2D myBody;

	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		speed = -1f;
	}
	
	// Update is called once per frame
	void Update () {

		myBody.velocity = new Vector2 (speed, 0);

//		Quaternion rot = transform.rotation;
//		float z = rot.eulerAngles.z;
//		//change this to be random too
//		z -= Input.GetAxis ("Horizontal") * rotSpeed * Time.deltaTime;
//
//		rot = Quaternion.Euler (0, 0, z);
//		transform.rotation = rot;
//		Vector3 pos = transform.position;
//		//change this to be random
//		//instead of chaing the y postition change it to x position
//		Vector3 movement =new Vector3(0,Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime,0);
//		pos += rot*movement;
//		transform.position = pos;
	}
}
