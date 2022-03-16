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
    private int entity;
    

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    //private TextAsset inkJSON;
    private Story _story;
    // Start is called before the first frame update
    void Awake()
    {
        _story = new Story(inkJSON.text);
    }
    void Start()
    {
        //_story.BindExternalFunction("changeEntity", (int newValue) => {
            //rename(newValue);
            //Debug.Log(entity);
        //});
    }

    public void rename(int newValue)
    {
        entity = newValue;
    }

    public void changer(TextAsset inkJSON)
    {
        int entity = ((Ink.Runtime.IntValue) DialougeManager1
            .GetInstance()
            .GetVariableState("entity")).value;
        switch(entity)
        {
            case 0:
                entity = 0;
                //Debug.Log(entity);
                break;
            case 1:
                entity = 1;
                Debug.Log(entity);
                break;
            case 2:
                entity = 2;
                Debug.Log(entity);
                break;
            case 3:
                entity = 3;
                Debug.Log(entity);
                break;
            case 4:
                entity = 4;
                Debug.Log(entity);
                break;
        }
        
        //Debug.Log(entity);
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
