using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject videoPlayer;
    public void VideoStart()
    {
        videoPlayer.SetActive(true);
    }

    // Update is called once per frame
}
