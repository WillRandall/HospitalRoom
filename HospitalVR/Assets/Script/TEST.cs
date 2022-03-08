using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;

public class TEST 
{
    private Dictionary<string, Ink.Runtime.Object> variables;


    public TEST(string globalsFilePath)
    {
        // compile the story
        string inkFileContents = File.ReadAllText(globalsFilePath);
        Ink.Compiler compiler = new Ink.Compiler(inkFileContents);
        Story globalVaribalesStory = compiler.Compile();

        // initialize the dictionary
        variables = new Dictionary<string, Ink.Runtime.Object>();
        foreach (string name in globalVaribalesStory.variablesState)
        {
            Ink.Runtime.Object value = globalVaribalesStory.variablesState.GetVariableWithName(name);
            variables.Add(name, value);
            Debug.Log("Initalized global dialouge variable: " + name + " = " + value);
        }

    }


    public void StartListening(Story story)
    {
        story.variablesState.variableChangedEvent += VariableChanged;
    }

    public void StopListening(Story story)
    {
        story.variablesState.variableChangedEvent -= VariableChanged;
    }


    private void VariableChanged(string name, Ink.Runtime.Object value)
    {
        // only maintain variables that were initalized from the glob
    }


}
