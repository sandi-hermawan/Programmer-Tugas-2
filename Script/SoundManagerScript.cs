using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip AchievementSound,CoinSound;
    static AudioSource audioSrc;

    void Start()
    {
        AchievementSound = Resources.Load<AudioClip>("achievement");
        CoinSound = Resources.Load<AudioClip>("coinCollect");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "achievement":
                audioSrc.PlayOneShot(AchievementSound);
                break;
            case "coinCollect":
                audioSrc.PlayOneShot(CoinSound);
                break;
        }
    }
}
