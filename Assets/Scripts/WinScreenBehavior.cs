using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScreenBehavior : MonoBehaviour {

   public Button exitButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        exitButton.onClick.AddListener(ExitToMain);
	}

    void ExitToMain() {
        SceneManager.LoadScene("Menu");
    }

    
}
