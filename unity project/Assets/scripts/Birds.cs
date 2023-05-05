using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }

    void OnTriggerExit(Collider other)
    {
        playSound.Stop();
        
    }
}
