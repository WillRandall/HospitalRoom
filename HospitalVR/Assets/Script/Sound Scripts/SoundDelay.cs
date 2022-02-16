using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay : MonoBehaviour
{
    public int delay;

    AudioSource sound;
    
    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.PlayDelayed(delay);
    }


}
