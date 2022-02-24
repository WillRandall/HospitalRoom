using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay : MonoBehaviour
{
    //public int delay;

    public AudioSource sound;

    public bool trig = false;
    
    void Start()
    {
       //trig = GameObject.Find("InputManager").GetComponent<InputManager>().submitPressed;
    }

    void Update()
    {
        if (trig == true)
        {
            sound = GetComponent<AudioSource>();
            sound.Play();
        }
    }

}
