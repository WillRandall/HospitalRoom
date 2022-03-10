using System.Collections;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Ink.Runtime;

public class InstantiateDestroy : MonoBehaviour
{
    
    //script needs a more robust way of deciding when to delete and instantiate entities.
    int scriptEnding = 0;
    public GameObject EntityDel;
    public GameObject EntityInst;
    int delay = 5000;
    [SerializeField] private TextAsset inkJSON;

    private Story story;

    private void Awake()
    {
        story = new Story(inkJSON.text);
    }

    private void Update()
    {
        UpdateFromStory();
    }
    //this method will eventually update from ink story
    // am unable at this point to get "Story" or "_inkStory" to work
    public void UpdateFromStory()
    {
        

          scriptEnding = (int)story.variablesState["x"];
         
        if (scriptEnding != 0)
        {
            Thread.Sleep(delay);
            Destroy(EntityDel);
            Instantiate(EntityInst);
        }
    }
    
}
