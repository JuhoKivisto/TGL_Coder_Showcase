using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehavior : MonoBehaviour {

    public GameObject player;

    public GameObject block;

    PlayerBehavior playerBeh;

	// Use this for initialization
	void Start () {
        playerBeh = gameObject.AddComponent<PlayerBehavior>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {

        FindObjectOfType<AudioManager>().Play("som");
        Destroy(block);
        playerBeh.Energy++;

       
    }
}
