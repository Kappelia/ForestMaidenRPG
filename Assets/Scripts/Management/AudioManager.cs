using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("-----Audio Source-----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    
    [Header("-----Audio Clip-----")]
    public AudioClip background;
    //public AudioClip death;
    //public AudioClip portal;
    //public AudioClip takeHit;
    //public AudioClip swordSlash;
    //public AudioClip staffLAser;
    //public AudioClip bowWhistle;

    //public AudioClip ghostAttack;
    //public AudioClip grapeAttack;
    //public AudioClip slimeAttack;

    //public AudioClip hearthPickUp;
    //public AudioClip staminaPickUp;
    //public AudioClip GoldPickUp;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);    
    }
}
