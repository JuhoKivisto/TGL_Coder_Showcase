using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour {

    PlayerBehavior player_s;

    public GameObject player;

	// Use this for initialization
	void Start () {
        player_s = player.GetComponent<PlayerBehavior>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.Equals(player)) {

        player_s.MaxEnergy++;
        }
    }
}
