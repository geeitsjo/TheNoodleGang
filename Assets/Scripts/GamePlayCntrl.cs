using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GamePlayCntrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnEnable(){
		BoatObj.playerDied += PlayerDied;
	}

	void OnDisable(){
		BoatObj.playerDied -= PlayerDied;
	}

	void PlayerDied(){
		StartCoroutine (RestartGame ());
	}
	IEnumerator RestartGame(){
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene ("FishGame");
	}
	// Update is called once per frame
	void Update () {
		SceneManager.LoadScene ("MainMenu");
	}
}
