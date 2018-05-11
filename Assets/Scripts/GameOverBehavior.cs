using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverBehavior : MonoBehaviour {
    public Button exitButton;

    // Use this for initialization
    void Start() {
        exitButton.onClick.AddListener(ExitToMain);
    }
    
    // Update is called once per frame
    void Update() {
        
    }
    
    public void ExitToMain() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

}
