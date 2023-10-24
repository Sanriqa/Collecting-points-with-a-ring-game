using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Videonun bitiþini algýlamak için bir event dinleyici ekliyoruz.
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Videonun bittiðinde çalýþacak fonksiyon
    void OnVideoEnd(VideoPlayer vp)
    {
        // Video oynatýcýsýný kapat
        vp.Stop();

        // Video oynatýcýsýný devre dýþý býrakabilirsiniz
        //vp.enabled = false;

        // Bu nesneyi devre dýþý býrakabilirsiniz
        //gameObject.SetActive(false);
    }
}