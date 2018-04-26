using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackdoorBehavior : MonoBehaviour {

    public GameObject backdoor;

    public GameObject player;

    PlayerBehavior player_S;

   public ParticleSystem deathsmoke;

	// Use this for initialization
	void Start () {
        player_S = gameObject.GetComponent<PlayerBehavior>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision) {

        if (player_S.Energy == player_S.MaxEnergy) {
            deathsmoke.startColor = new Color(0, 0, 0, .5f);
            Destroy(backdoor);
        }
        else  {
                
        }

    }
}
