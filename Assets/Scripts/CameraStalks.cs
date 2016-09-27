using UnityEngine;
using System.Collections;

public class CameraStalks : MonoBehaviour {
	
	public Transform player;
	public float minX=-46, maxX=46;
	//float shipBoundary=05f;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	//float shipBoundary=05f;
	// Update is called once per frame
	void Update () {
		//Vector3.Lerp;
		Vector3 temp = transform.position;
		temp.x = player.position.x;

		if(temp.x<minX){
			temp.x = minX;
		}
		if(temp.x>maxX){
			temp.x = maxX;
		}

		transform.position=temp;



//			if(pos.y+shipBoundary> Camera.main.orthographicSize){
//				pos.y = Camera.main.orthographicSize - shipBoundary;
//			}
//			if(pos.y-shipBoundary< -Camera.main.orthographicSize){
//				pos.y = -Camera.main.orthographicSize + shipBoundary;
//			}

	}
}
