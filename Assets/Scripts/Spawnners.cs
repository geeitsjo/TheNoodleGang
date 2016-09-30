using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawnners : MonoBehaviour {

	[SerializeField]
	private GameObject[] monsterRef;

	private List<GameObject> monsters = new List<GameObject>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateMonsters(){
		int index = 0;
		//9 monsters in our list array
		//change this as the elvel progresses
		for (int i = 0; i < monsterRef.Length * 3; i++) {
			GameObject shiz = Instantiate (monsterRef [index], transform.position, Quaternion.identity) as GameObject;
			monsters.Add(shiz);
			monsters [i].SetActive (false);
			index++;
			if(index==monsterRef.Length){
				index = 0;
			}
		}//end of for
	}//end of method


	IEnumerator Spawnner(float delay){
		yield return new WaitForSeconds (delay);
		int randomIndex = Random.Range (0, monsters.Count);

		while (true) {
			if (!monsters [randomIndex].activeInHierarchy) {
				monsters [randomIndex].SetActive (true);
				monsters [randomIndex].transform.position = transform.position;
				break;
			} else { //a different monsters
				randomIndex = Random.Range (0, monsters.Count);
			}
		}//end of while loop
		if(gameObject.name=="Left Spawnner"){
			
		}
	}
}
