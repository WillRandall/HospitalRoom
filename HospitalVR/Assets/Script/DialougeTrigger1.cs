using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class DialougeTrigger1 : MonoBehaviour
{

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    //TESTING this script to put in Trigger and manager
  [SerializeField] private InputActionReference contiuneStoryActionRefrence;

    
    private bool start = false;

    private bool playerInRange;

    public void Awake()
    {
 
        playerInRange = false;
        visualCue.SetActive(false);
        

        
    }

    void Start()
    {
        //part of Test Script
        contiuneStoryActionRefrence.action.performed += OnContiune;
    }


    public void Update()
    {
        if (playerInRange && !DialougeManager1.GetInstance().dialougeIsPlaying)
        {
            visualCue.SetActive(true);
           

            {
                DialougeManager1.GetInstance().EnterDialougeMode(inkJSON);
            }
        }
        else
        {
            visualCue.SetActive(false);
            
        }
    }

    private void OnContiune(InputAction.CallbackContext obj)
    {
        if (playerInRange && !DialougeManager1.GetInstance().dialougeIsPlaying)
        {
            visualCue.SetActive(true);


            {
                DialougeManager1.GetInstance().EnterDialougeMode(inkJSON);
            }
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
