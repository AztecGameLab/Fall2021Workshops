using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Music;
    public AudioSource Background;
    public AudioSource PlayerJump;
    public AudioSource PlayerLand;
    public AudioSource PlayerWhip;

    private static SoundManager _instance;

    public static SoundManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public void PlayPlayerJumpSound()
    {
        PlayerJump.Play();
    }
    public void PlayPlayerLandSound()
    {
        PlayerLand.Play();
    }
    public void PlayPlayerWhip()
    {
        PlayerWhip.Play();
    }

}
