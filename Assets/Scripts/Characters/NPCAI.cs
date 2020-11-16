using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
   public GameObject DestinationPoint;
   NavMeshAgent TheAgent;
  
    
    void Start()
    {
         TheAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        TheAgent.SetDestination(DestinationPoint.transform.position);
    }
}
