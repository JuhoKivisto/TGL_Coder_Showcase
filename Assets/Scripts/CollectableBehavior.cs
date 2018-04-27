using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehavior : MonoBehaviour {

    public GameObject player;

    public GameObject block;

    PlayerBehavior playerBeh;

    // Use this for initialization
    void Start() {
        playerBeh = player.GetComponent<PlayerBehavior>();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter2D(Collider2D other) {

        FindObjectOfType<AudioManager>().Play("som");
        playerBeh.Energy++;
        playerBeh.Speed += 5;
        Destroy(block);




    }
}
