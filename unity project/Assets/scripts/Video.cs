using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider player)
    {
        videoPlayer.SetActive(true);
    }

    void OnTriggerExit(Collider player)
    {
        videoPlayer.SetActive(false);
    }

}
