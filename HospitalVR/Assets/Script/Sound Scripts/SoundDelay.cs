using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay : MonoBehaviour
{
    //public int delay;

    public AudioSource sound;

    bool trig = false;
    
    void Start()
    {
       trig = GameObject.Find("InputManager").GetComponent<InputManager>();
    }

    void Update()
    {
        //trigScr = InputManager.submitPressed;
        if (trig == true)
        {
            sound = GetComponent<AudioSource>();
            sound.Play();
        }
    }

}
