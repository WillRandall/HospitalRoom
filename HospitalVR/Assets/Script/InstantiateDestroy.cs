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
     
    //this method will eventually update from ink story
    // am unable at this point to get "Story" or "_inkStory" to work
    public void UpdateFromStory()
    {
        //commented next line out to avoid compiler errors
        /* 
         * scriptEnding = (int)story.variablesState["scriptEnding"];
         */
        if (scriptEnding != 0)
        {
            //destroy EntityDel
            Thread.Sleep(delay);
            Instanstiate EntityInst;
        }
    }
    
}
