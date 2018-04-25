using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

    public static AudioManager instance;

    //Use this for initialization
   void Start() {

       Play("Theme");
    }

    void Awake() {

        if (instance == null)
            instance = this;
        else {
            Destroy(gameObject);
            return;
        }


        DontDestroyOnLoad(gameObject);

        foreach (Sound item in sounds) {
            item.source = gameObject.AddComponent<AudioSource>();
            item.source.clip = item.clip;

            item.source.volume = item.volume;
            item.source.pitch = item.pitch;
            item.source.loop = item.loop;
        }

    }


    public void Play(string name) {
        Sound s = Array.Find(sounds, item => item.name == name);

        if (s == null) {
            return;
        }
        s.source.Play();

    }
}
