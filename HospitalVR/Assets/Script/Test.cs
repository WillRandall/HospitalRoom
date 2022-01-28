using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Test : MonoBehaviour
{
    //TESTING this script to put in Trigger and manager
  [SerializeField] private InputActionReference contiuneStoryActionRefrence;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    // Start is called before the first frame update
    void Start()
    {
        contiuneStoryActionRefrence.action.performed += OnContiune;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnContiune(InputAction.CallbackContext obj)
    {
        DialougeManager1.GetInstance().EnterDialougeMode(inkJSON);
    }

}
