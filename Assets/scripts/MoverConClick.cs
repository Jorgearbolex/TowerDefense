using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoverConClick : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera cam;
    
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast (cam.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        } 
    }
}
