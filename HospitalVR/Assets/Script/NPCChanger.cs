using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCChanger : MonoBehaviour
{
    [SerializeField] private Color defaultColor = Color.white;


    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        
    }
}
