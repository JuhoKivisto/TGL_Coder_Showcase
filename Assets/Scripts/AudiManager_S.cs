using UnityEngine.Audio;
using UnityEngine;

public class AudiManager_S : MonoBehaviour {

    public Sound_S[] sounds;
	// Use this for initialization
	void Awake () {

        foreach (Sound_S sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play(string name)
    {
      Sound_S s = System.Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
 
    }
}
