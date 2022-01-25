using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class DialougeTrigger1 : MonoBehaviour
{

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;

    private void Awake()
    {
 

        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && !DialougeManager1.GetInstance().dialougeIsPlaying)
        {
            visualCue.SetActive(true);
            //if (InputManager.GetInstance().Button.Start.Pressed())

            //{
            //    DialougeManager1.GetInstance().EnterDialougeMode(inkJSON);
            //}
        }
        else
        {
            visualCue.SetActive(false);
            
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }


    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

}
