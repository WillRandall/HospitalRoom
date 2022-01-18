using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public float m_DefualtLength = 5.0f;
    public GameObject m_Dot;
    public VRInputModule m_InputModule;

    private LineRenderer m_lineRenderer = null;

    private void Awake()
    {
        m_lineRenderer = GetComponent<LineRenderer>();
    }
   private void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {
        // use deafult of distance
        float targetLength = m_DefualtLength;
        
        //Raycast
        RaycastHit hit = CreateRaycast(targetLength);
        
        //Deafult
        Vector3 endPosition = transform.position + (transform.forward * targetLength);
        
        //or based on hit
        if (hit.collider != null)
            endPosition = hit.point;

        //Set postion of Dot
        m_Dot.transform.position = endPosition;

        // Set Linerender
        m_lineRenderer.SetPosition(0, transform.position);
        m_lineRenderer.SetPosition(1, endPosition);
    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, m_DefualtLength);
        return hit;
    }

}
