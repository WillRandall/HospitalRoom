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

    private PlayerInput playerInput;
    private bool start = false;

    private bool playerInRange;

    public void Awake()
    {
 
        playerInRange = false;
        visualCue.SetActive(false);

        playerInput = GetComponent<PlayerInput>();

        PlayerInputActions playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Start.performed += Start;

        
    }

    public void Start(InputAction.CallbackContext context)
    {
        //Debug.Log(context);
        if (context.performed)
        {
            start = true;
            Debug.Log(start);
        }
    }


    public void Update()
    {
        if (playerInRange && !DialougeManager1.GetInstance().dialougeIsPlaying)
        {
            visualCue.SetActive(true);
            if (start = true)

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
