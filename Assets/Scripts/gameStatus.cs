using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class gameStatus : MonoBehaviour {

	private bool paused;
	private int startCountdownTime = 60;
	private float countdownTime = 0;
	public Text timerText;

	public GameObject pauseBgd;
	//public GameObject pauseTxt;

	// Use this for initialization
	void Start () {
		countdownTime = startCountdownTime;
		paused = false;
		pauseBgd.SetActive (false);
		//pauseTxt.SetActive (false);
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		countdownTime = countdownTime - Time.deltaTime;
		timerText.text = ((int)(countdownTime)).ToString();

		if (Input.GetKeyDown (KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.A)) {
			if (paused == false) {
				paused = true;
				Time.timeScale = 0;
				pauseBgd.SetActive (true);
				//pauseTxt.SetActive (true);
			}
			else if (paused == true) {
				paused = false;
				Time.timeScale = 1;
				pauseBgd.SetActive (false);
				//pauseTxt.SetActive (false);
			}
		}
		//restart
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			SceneManager.LoadScene ("level1");
		}
		//end
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			SceneManager.LoadScene ("titleScene");
		}
	}
}
