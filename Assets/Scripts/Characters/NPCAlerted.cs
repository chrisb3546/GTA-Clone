using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAlerted : MonoBehaviour
{

    
    
 
    // Start is called before the first frame update
    void OnTriggerEnter(Collider npc){
        if(npc.tag == "NPC"){
            print("pointed");
            StartCoroutine(ScaredAI(npc));
           
            
            

           
        }
    }
    
     IEnumerator ScaredAI (Collider npc){
                print("here");
                npc.GetComponent<Animation>().Play("Terrified");
                npc.GetComponent<NavMeshAgent>().speed = 0;
                yield return new WaitForSeconds (6);
                npc.GetComponent<Animation>().Play("Walking");
                npc.GetComponent<NavMeshAgent>().speed = 4;

            }
    
   
}
