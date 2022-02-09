using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    // [SerializeField] Slider volumeSlider;

    public static AudioClip backgroundSound,jump,gameoverSound,painSound,potionSound,winSound,zombieSound, laser,runSound, buttonSound, playMenu,fire;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
       // backgroundSound=Resources.Load<AudioClip>("background");
        gameoverSound=Resources.Load<AudioClip>("gameover");
        painSound=Resources.Load<AudioClip>("pain");
        potionSound=Resources.Load<AudioClip>("potion");
        winSound=Resources.Load<AudioClip>("win");
        zombieSound=Resources.Load<AudioClip>("Zombie");
        runSound=Resources.Load<AudioClip>("run");
        fire=Resources.Load<AudioClip>("fire");
        buttonSound = Resources.Load<AudioClip>("button");
        playMenu = Resources.Load<AudioClip>("Play-menu");
         laser = Resources.Load<AudioClip>("laser");
         jump = Resources.Load<AudioClip>("jump");


        audioSource = GetComponent<AudioSource>();

        // if (!PlayerPrefs.HasKey("background"))
        // {
        //     PlayerPrefs.SetFloat("background", 1);
        //     Load();
        // }

        // else
        // {
        //     Load();
        // }

    }

    // public void ChangeVolume()
    // {
    //     AudioListener.volume = volumeSlider.value;
    //     Save();

    // }

    // private void Load()
    // {
    //     volumeSlider.value = PlayerPrefs.GetFloat("background");
    // }

    // private void Save()
    // {
    //     PlayerPrefs.SetFloat("background", volumeSlider.value);
    // }


    public static void PlaySound (string clip)
    {
        switch(clip){
            // case "background":
            // audioSource.PlayOneShot(backgroundSound);
            // break;
            case "gameover":
            audioSource.PlayOneShot(gameoverSound);
            break;
            case "pain":
            audioSource.PlayOneShot(painSound);
            break;
            case "potion":
            audioSource.PlayOneShot(potionSound);
            break;
            case "win":
            audioSource.PlayOneShot(winSound);
            break;
            case "zombie":
            audioSource.PlayOneShot(zombieSound);
            break;
            case "run":
            audioSource.PlayOneShot(runSound);
            break;
            case "fire":
            audioSource.PlayOneShot(fire);
            break;
            case "laser":
            audioSource.PlayOneShot(laser);
            break;
            case "jump":
            audioSource.PlayOneShot(jump);
            break;




            

        }
    }
}