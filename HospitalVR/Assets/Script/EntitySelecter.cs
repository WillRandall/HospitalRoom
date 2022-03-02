using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class EntitySelecter : MonoBehaviour
{

    public GameObject entity1;
    public GameObject entity2;
    public GameObject entity3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var entity = (int)_Entitey1.variablesState["entity"];
        if(entity == 1)
        {
            entity1.SetActive(true);
            entity1.SetActive(false);
            entity1.SetActive(false);
        }

        if (entity == 2)
        {
            entity1.SetActive(false);
            entity1.SetActive(true);
            entity1.SetActive(false);
        }

        if (entity == 3)
        {
            entity1.SetActive(false);
            entity1.SetActive(false);
            entity1.SetActive(true);
        }

        if (entity == 4)
        {
            entity1.SetActive(false);
            entity1.SetActive(false);
            entity1.SetActive(false);
        }
    }
}
