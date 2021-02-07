using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFxManager : MonoBehaviour
{
    public AudioClip land;
    public AudioClip shoot;
    public AudioClip hurt;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlaySoundFx(string sfx)
    {
        //FindObjectOfType<AudioManager>().Play(land.name);
        switch (sfx)
        {
            case "land":
                audioSource.PlayOneShot(land);
                break;
            case "shoot":
                audioSource.PlayOneShot(shoot);
                break;
            case "hurt":
                audioSource.PlayOneShot(hurt);
                break;
        }
        
    }
}
