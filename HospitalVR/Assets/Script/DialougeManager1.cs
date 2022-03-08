using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Ink.UnityIntegration;


public class DialougeManager1 : MonoBehaviour
{

    [Header("Globals Ink File")]
    [SerializeField] private InkFile globalsInkFile;

    [Header("Dialouge UI")]

    [SerializeField] private GameObject dialougePanel;

    [SerializeField] private TextMeshProUGUI dialougeText;


    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;

    private TextMeshProUGUI[] choicesText;

    private PlayerInput playerInput;

    private Story currentStory;

    public bool dialougeIsPlaying { get; private set; }

    private static DialougeManager1 instance;

    private TEST dialougeVariables;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialouge Manager in scene");
        }
        instance = this;

        dialougeVariables = new TEST(globalsInkFile.filePath);

        
    }

    public static DialougeManager1 GetInstance()
    {
        return instance;
    }


    private void Start()
    {
        dialougeIsPlaying = false;
        dialougePanel.SetActive(false);

        // get all of the choices text
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        //Return right away if Dialouge isnt playing
        if (!dialougeIsPlaying)
        {
            return;
        }
        // Handle countinuing to the next line in the dialouge when submit is pressed
        if (currentStory.currentChoices.Count == 0 && InputManager.GetInstance().GetSubmitPressed())
        {
            ContinueStory();
        }


    }


    public void EnterDialougeMode(TextAsset inkJSon)
    {
        currentStory = new Story(inkJSon.text);
        dialougeIsPlaying = true;
        dialougePanel.SetActive(true);

        dialougeVariables.StartListening(currentStory);

        ContinueStory();
    }
    private void ExitDialougeMode()
    {
        dialougeVariables.StartListening(currentStory);

        dialougeIsPlaying = false;
        dialougePanel.SetActive(false);
        dialougeText.text = "";
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            //set text for current dialouge line
            dialougeText.text = currentStory.Continue();
            //display choices, if any, for this dialouge line
            DisplayChoices();
        }
        else
        {
            ExitDialougeMode();
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        // Check to make sure UI can support the number of choices coming in
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given then UI can support. Number of choices given: " + currentChoices.Count);
        }

        int index = 0;
        //enable and initalize the choices up to the amount of choices for this Line of dialouge
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        //go through the remaining choices the UI supports and make sure they're hidden
        for(int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        // Event system requires we clear it first, then wait
        // for at least one frame before we set the current selected object.
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        InputManager.GetInstance().RegisterSubmitPressed();
        ContinueStory();
    }


}
