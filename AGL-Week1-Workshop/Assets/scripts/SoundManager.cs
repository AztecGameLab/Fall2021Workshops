using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Music;
    public AudioSource Background;
    public AudioSource PlayerOneShotAudio;
    public AudioClip playerJump;
    public AudioClip playerLand;

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
        PlayerOneShotAudio.PlayOneShot(playerJump);
    }
    public void PlayPlayerLandSound()
    {
        PlayerOneShotAudio.PlayOneShot(playerLand);
    }

}
