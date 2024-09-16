using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioBGM;
    public GameObject[] audioSFX;

    void Start()
    {
        PlayBGM();   
    }
    
    public void PlayBGM() 
    {
        audioBGM.Play();
    }
    
    public void PlaySFX(Vector3 spawnPosition, int sfxIndex) 
    {
        if (sfxIndex >= 0 && sfxIndex < audioSFX.Length)
        {
            Instantiate(audioSFX[sfxIndex], spawnPosition, Quaternion.identity);
        }
    }
}
