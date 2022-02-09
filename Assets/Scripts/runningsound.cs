using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runningsound : MonoBehaviour
{    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void step()
    {
        audioSource.Play();
    }
}
