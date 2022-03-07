using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class EntitySelecter : MonoBehaviour
{

    public GameObject entity1;
    public GameObject entity2;
    public GameObject entity3;
    

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    //private TextAsset inkJSON;
    private Story _story;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changer(TextAsset inkJSON)
    {
        _story = new Story(inkJSON.text);
        int entity = (int) _story.variablesState["entity"];
        Debug.Log(entity);
        if (entity == 1)
        {
            entity1.SetActive(true);
            entity2.SetActive(false);
            entity3.SetActive(false);
        }

        else if (entity == 2)
        {
            entity1.SetActive(false);
            entity2.SetActive(true);
            entity3.SetActive(false);
        }

        else if (entity == 3)
        {
            entity1.SetActive(false);
            entity2.SetActive(false);
            entity3.SetActive(true);
        }

        else if (entity == 4)
        {
            entity1.SetActive(false);
            entity2.SetActive(false);
            entity3.SetActive(false);
        }
        //changer(inkJSON);
    }

    // Update is called once per frame
    void Update()
    {
        changer(inkJSON); 

        
    }
}
