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

    public Text energyNum;

    float directionsX;

    Rigidbody2D rb2D;

    public float speed = 0;

    int counter = 0;

    bool pointerDown;

    private static int energy;

    public int Energy {
        get {
            return energy;
        }

        set {
            energy = value;
        }
    }

    int maxEnergy = 5;

    public Slider energyBar;

    public Button backdoorBtn;

    // Use this for initialization
    void Start() {
        energy = 0;
        rb2D = GetComponent<Rigidbody2D>();
        energyBar.value = energy;
    }

    // Update is called once per frame
    void Update() {


        //energyNum.text = energy.ToString();
        energyBar.value = energy;

        directionsX = CrossPlatformInputManager.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(directionsX * 100, 0);



        speed += 0.01f;

        player.transform.Translate(0, 0.1f * Time.deltaTime * speed, 0);    // Moving player
        camera.transform.Translate(0, 0.1f * Time.deltaTime * speed / 1.3f, 0); //Moving camera

        // Debug.Log(speed);

        // Energy logic
        if (energy > maxEnergy) {
            energy /= 2;
            backdoorBtn.interactable = false;
            backdoorBtn.GetComponentInChildren<Text>().text = "Not enough energy";

        }
        if (energy == maxEnergy) {
            backdoorBtn.interactable = true;
            backdoorBtn.GetComponentInChildren<Text>().text = "Open Backdoor";
        }
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
