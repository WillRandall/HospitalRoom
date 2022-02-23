using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{

    XRIDefaultInputActions input;

    Vector2 currentMovment;
    bool DmovePressed;

    private void Awake()
    {
        input = new XRIDefaultInputActions();

        input.XRIRightHand.move1.performed += ctx => currentMovment = ctx.ReadValue<Vector2>();
        DmovePressed = currentMovment.x != 0 || currentMovment.y != 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        input.XRIRightHand.Enable();
    }

    private void OnDisable()
    {
        input.XRIRightHand.Disable();
    }
}
