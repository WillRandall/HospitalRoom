using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;

public class TEST 
{

    public Dictionary<string, Ink.Runtime.Object> variables { get; private set; }

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
        // its important that VariablesToStory is before assigning to listener! 
        VariablesToStory(story);
        story.variablesState.variableChangedEvent += VariableChanged;
    }


    public void StopListening(Story story)
    {
        story.variablesState.variableChangedEvent -= VariableChanged;
    }

    private void VariableChanged(string name, Ink.Runtime.Object value)
    {
        // only maintain variables that were initalized from the globals file 
        if (variables.ContainsKey(name))
        {
            variables.Remove(name);
            variables.Add(name, value);
        }
    }

    private void VariablesToStory(Story story)
    {
        foreach(KeyValuePair<string, Ink.Runtime.Object> variable in variables)
        {
            story.variablesState.SetGlobal(variable.Key, variable.Value);
        }
    }

}
