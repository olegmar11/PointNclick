using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayer : MonoBehaviour
{
    public AudioClip badkey, goodkey, winning,microwork,microfinish;
    AudioSource audiosrc;
    private void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }
    public void PlayGood()
    {
        audiosrc.PlayOneShot(goodkey);
    }
    public void PlayBad()
    {
        audiosrc.PlayOneShot(badkey);
    }
    public void PlayWin()
    {
        audiosrc.PlayOneShot(winning);
    }

    public void Play_microvawe_work()
    {
        audiosrc.PlayOneShot(microwork);
    }

    public void Play_Microwave_end()
    {
        audiosrc.PlayOneShot(microfinish);
    }
}
