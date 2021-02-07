using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundtrackManager : MonoBehaviour
{
    public string trackName;
    void Start()
    {
        FindObjectOfType<AudioManager>().Play(trackName);
    }
}
