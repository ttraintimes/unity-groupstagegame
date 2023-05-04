using UnityEngine;
using UnityEngine.Video;

public class PlayVideoOnCollision : MonoBehaviour
{
    public GameObject videoPlayerObject;

    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = videoPlayerObject.GetComponent<VideoPlayer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoPlayer.Play();
        }
    }
}
