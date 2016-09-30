using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class boatControl : MonoBehaviour {

	//public float speed; 
	//public Rigidbody2D rb;
	private int scoreCounter;
	public Text scoreText;

	//diff boat images
	//public Sprite boat1;
	public Sprite boat2;
	public Sprite boat3;
	public Sprite boat4;
	public Sprite boat5;
	public Sprite boat6;

	void Start ()
	{
		//rb = gameObject.GetComponent<Rigidbody2D> ();
		scoreCounter = 0;
		scoreText.text = ("Score:") + scoreCounter.ToString ();
	}

	// Update is called once per frame
	void Update () {
		if (scoreCounter == 1)
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = boat2;
		}
		if (scoreCounter == 5)
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = boat3;
		}
		if (scoreCounter == 10)
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = boat4;
		}
		if (scoreCounter == 15)
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = boat5;
		}
		if (scoreCounter == 20)
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = boat6;
		}
	}

	//survivor pick up and score and boat change to more people accordingly 
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.CompareTag("survivor")){
			other.gameObject.SetActive (false);
			scoreCounter++;
			scoreText.text = ("Score:") + scoreCounter.ToString ();
		}
	}

}
