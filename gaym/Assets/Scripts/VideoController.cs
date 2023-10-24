using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Videonun biti�ini alg�lamak i�in bir event dinleyici ekliyoruz.
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Videonun bitti�inde �al��acak fonksiyon
    void OnVideoEnd(VideoPlayer vp)
    {
        // Video oynat�c�s�n� kapat
        vp.Stop();

        // Video oynat�c�s�n� devre d��� b�rakabilirsiniz
        //vp.enabled = false;

        // Bu nesneyi devre d��� b�rakabilirsiniz
        //gameObject.SetActive(false);
    }
}