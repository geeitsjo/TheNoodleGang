using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			SceneManager.LoadScene ("level1");
		}
	}
	public void loadScene (string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
