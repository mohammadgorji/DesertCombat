using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChange : MonoBehaviour
{

    public AudioSource audioSrc;
    private float musicVolume = 1f;

    void Start()
    {

        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {

        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
