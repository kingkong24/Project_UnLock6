using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    [SerializeField] private AudioClip ButtonSound;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void OnMouseEnter()
    {  
        audioSource.PlayOneShot(ButtonSound);
    }
}
