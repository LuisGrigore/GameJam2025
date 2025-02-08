using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class MusicHandlerScript : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject flechaFactory;

    void Start()
    {
        audioSource.Play(); // Reproduce la canción

        DoSequence();
    }
    void DoSequence()
    {
        List<float> delays = new List<float> { 1, 2, 2, 0.5f, 0.5f, 2, 0.2f, 1 };
        float currentDelay = 0;
        foreach (float delay in delays)
        {
            currentDelay += delay;
            Invoke("Spawn", currentDelay);
        }
    }
    void Spawn()
    { 
        flechaFactory.GetComponent<FlechaFactory>().SpawnObject();
    }
}
