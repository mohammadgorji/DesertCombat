using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource myAudio;
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuReturn()
    {
        SceneManager.LoadScene(0);
    }

    public void PlaySound()
    {
        myAudio.Play();
    }
}

