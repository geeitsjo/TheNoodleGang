using UnityEngine;
using System.Collections;

public class BoatObj : MonoBehaviour {

	private Rigidbody2D myBody;
	// Use this for initialization
	public delegate void PlayerDied();
	public static event PlayerDied playerDied;
	 
	void OnCollisionEnter2D(Collision2D target){
		//LOSE
		if (target.gameObject.tag == "monster") {
			if(playerDied!=null){
				playerDied ();
			}
			Destroy (gameObject);
		}

		//WIN
		if (target.gameObject.tag == "island") {

		}
	}//end of onCollision method
	void OnTriggerEnter2D (Collider2D target){
		if (target.gameObject.tag == "monster") {
			if(playerDied!=null){
				playerDied ();
			}
			Destroy (gameObject);//this destroys the user rathen than the baot
		}
	}
}
