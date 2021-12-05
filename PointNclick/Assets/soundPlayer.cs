using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayer : MonoBehaviour
{
    public AudioClip badkey, goodkey, winning;
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
}
