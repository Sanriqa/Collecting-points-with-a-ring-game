using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Videonun bitişini algılamak için bir event dinleyici ekliyoruz.
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Videonun bittiğinde çalışacak fonksiyon
    void OnVideoEnd(VideoPlayer vp)
    {
        // Video oynatıcısını kapat
        vp.Stop();

        // Video oynatıcısını devre dışı bırakabilirsiniz
        //vp.enabled = false;

        // Bu nesneyi devre dışı bırakabilirsiniz
        //gameObject.SetActive(false);
    }
}