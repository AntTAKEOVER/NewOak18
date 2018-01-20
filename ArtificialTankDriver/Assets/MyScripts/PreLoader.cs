using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PreLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator loadNextScene(){
		
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene ("Main");
	}
}
