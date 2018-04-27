using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackdoorBehavior : MonoBehaviour {

    public GameObject backdoor;

    public GameObject backdoortrigger;

    public GameObject player;

    public GameObject mainframe;

    PlayerBehavior player_S;

    public ParticleSystem deathsmoke;

    public Button openbackdoor;

    // Use this for initialization
    void Start() {
        player_S = player.GetComponent<PlayerBehavior>();
    }

    // Update is called once per frame
    void Update() {
        openbackdoor.onClick.AddListener(OpenBackdoor);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        SceneManager.LoadScene("GameOver");
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        openbackdoor.interactable = true;
        player_S.Speed = 5;
        Destroy(backdoortrigger);

        if (player.Equals(mainframe)) {
            Destroy(player);
        }


    }

    void OpenBackdoor() {

        if (player_S.Energy == player_S.MaxEnergy) {
            deathsmoke.startColor = new Color(0, 0, 0, .5f);
            mainframe.SetActive(true);
            Destroy(backdoor);
        }
    }


}
