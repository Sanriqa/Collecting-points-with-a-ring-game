using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField]
    private bool musicEnable;

    [SerializeField]
    private AudioSource music;

    private void Awake()
    {
        musicEnable = true;
    }
    public void ToogleMusic()
    {
        if (!musicEnable)
        {
            //Enable Music
             
            music.Play();
            musicEnable = true;
        }
        else
        {
            //Disable Music

            music.Pause();
            musicEnable = false;
        }
    }
}
