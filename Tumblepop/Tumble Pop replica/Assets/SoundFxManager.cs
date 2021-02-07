using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFxManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlaySoundFx(string sfx)
    {
        FindObjectOfType<AudioManager>().Play(sfx);
    }
}
