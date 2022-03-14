using System.Collections;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Ink.Runtime;

public class NPCChanger : MonoBehaviour
{
    [SerializeField] private Color defaultColor = Color.white;

    public GameObject EntityDel;
    public GameObject EntityInst;
    int delay = 5000;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        //next lines stolen from InstantiateDestroy script

    }

    private void Update()
    {
        Thread.Sleep(delay);
        EntityDel.SetActive(false);
        EntityInst.SetActive(true);
    }
}
