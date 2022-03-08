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
        // Compile the story
        string inkFileContents = File.ReadAllText(globalsFilePath);
        Ink.Compiler compiler = new Ink.Compiler(inkFileContents);
        Story globalsVariablesStory = compiler.Compile();

        // initalize the dictionary 
        variables = new Dictionary<string, Ink.Runtime.Object>();
        foreach (string name in globalsVariablesStory.variablesState)
        {
            Ink.Runtime.Object value = globalsVariablesStory.variablesState.GetVariableWithName(name);
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
        Debug.Log("Variable changed: " + name + " = " + value);
    }

}
