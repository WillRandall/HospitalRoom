using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour
{
    //TESTING
    private Vector2 moveDirection = Vector2.zero;

    private bool submitPressed = false;
    private bool interactPressed = false;
    public bool buttonAstate = false;
    
    private static InputManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more then one Input Manager in the scene.");
        }
        instance = this;
    }

    public static InputManager GetInstance()
    {
        return instance;
    }

    //TESTING
    public void MovePressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            moveDirection = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            moveDirection = context.ReadValue<Vector2>();
        }
    }


    public void InteractButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            interactPressed = true;
        }
        else if (context.canceled)
        {
            interactPressed = false;
        }
    }

    public void SubmitPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            submitPressed = true;
            GameObject.Find("XR Rig 2").GetComponent<SoundDelay>().trig = true;
        }
        else if (context.canceled)
        {
            submitPressed = false;
            GameObject.Find("XR Rig 2").GetComponent<SoundDelay>().trig = false;
        }
    }

    //TEST
public Vector2 GetMoveDirection()
    {
        return moveDirection;
    }

    public bool GetInteractPressed()
    {
        bool result = interactPressed;
        interactPressed = false;
        return result;
    }

    public bool GetSubmitPressed()
    {
        bool result = submitPressed;
        submitPressed = false;
        return result;
    }

    public void RegisterSubmitPressed()
    {
        submitPressed = false;
    }
    /*
 * public void buttonA(InputAction.CalbackContext context)
 * {
 * if (context.performed)
 * {
 * submitPressed = true;
 * buttonAstate = true;
 * buttonBstate = false;
 * }
 * 
 * 
 * 
 * }
 */
}
