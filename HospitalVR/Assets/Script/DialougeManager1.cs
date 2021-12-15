using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;


public class DialougeManager1 : MonoBehaviour
{

    [Header("Dialouge UI")]

    [SerializeField] private GameObject dialougePanel;

    [SerializeField] private TextMeshProUGUI dialougeText;



    private Story currentStory;

    private bool dialougeIsPlaying { get; private set; }


    private static DialougeManager1 instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialouge Manager in scene");
        }
        instance = this;
    }

    public static DialougeManager1 GetInstance()
    {
        return instance;
    }


    private void Start()
    {
        dialougeIsPlaying = false;
        dialougePanel.SetActive(false);
    }

    private void Update()
    {
        //Return right away if Dialouge isnt playing
        if (!dialougeIsPlaying)
        {
            return;
        }

        //Move to next line of Dialouge when submit is pressed 
        if (InputManager.GetInstance().GetSubmitPressed())
        {
            ContinueStory();
        }

    }


    public void EnterDialougeMode(TextAsset inkJSon)
    {
        currentStory = new Story(inkJSon.text);
        dialougeIsPlaying = true;
        dialougePanel.SetActive(true);

        ContinueStory();
    }
    private void ExitDialougeMode()
    {
        dialougeIsPlaying = false;
        dialougePanel.SetActive(false);
        dialougeText.text = "";
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialougeText.text = currentStory.Continue();
        }
        else
        {
            ExitDialougeMode();
        }
    }

}
