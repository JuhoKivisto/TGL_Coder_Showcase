using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerBehavior : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public GameObject player;

    public GameObject camera;

    float directionsX;

    Rigidbody2D rb2D;

    public float speed = 0;

    int counter = 0;

    bool pointerDown;

    float pointerDownTimer = 0.0f;

    public UnityEvent ButtonHold;

    // Use this for initialization
    void Start() {

        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

        directionsX = CrossPlatformInputManager.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(directionsX * 100, 0);

        if (counter == 10) {

        }
        else {

            speed += 0.01f;
        }
        player.transform.Translate(0, 0.1f * Time.deltaTime * speed, 0);
        camera.transform.Translate(0, 0.1f * Time.deltaTime * speed / 1.3f, 0);

        // Debug.Log(speed);
    }

    public void GoLeft() {

        player.transform.Translate(Vector2.left * Time.deltaTime * 10);
    }

    public void GoRight() {
        player.transform.Translate(Vector2.right * Time.deltaTime);

    }

    public void OnPointerDown(PointerEventData eventData) {
        pointerDown = true;

    }

    public void OnPointerUp(PointerEventData eventData) {
        pointerDown = false;
    }
}
