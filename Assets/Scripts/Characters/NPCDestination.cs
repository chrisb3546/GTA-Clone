using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
    public int triggNum;
    public int genPos;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        if(other.tag == "NPC"){
            genPos = Random.Range(0,5);
            
            if (genPos == 0){
                this.gameObject.transform.position = new Vector3 (23,16,151);
                
            }
            else if(genPos == 1){
                this.gameObject.transform.position = new Vector3 (84,16,151);
                
            }
            else if(genPos == 2){
                this.gameObject.transform.position = new Vector3 (84,16,75);
                
            }
            else if(genPos == 3){
                this.gameObject.transform.position = new Vector3 (23,16,75);
            }
            
            
        }

    }
}
