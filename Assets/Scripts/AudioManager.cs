using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip[] sounds;

    private AudioSource audioSource;


    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();


    }


    void Update()
    {
        if (Input.GetKeyDown("return")) {
            audioSource.loop = true;
            AudioClip ghostNormal = sounds[1];
            audioSource.clip = ghostNormal;
            audioSource.Play() ;
        }
    }
}
