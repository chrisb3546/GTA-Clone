using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
    
    public int genPos;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        if(other.tag == "NPC"){
            genPos = Random.Range(0,5);
            print("entered");
            if (genPos == 0){
                this.gameObject.transform.position = new Vector3 (23,16,151);
                print("0");
            }
            else if(genPos == 1){
                this.gameObject.transform.position = new Vector3 (84,16,151);
                print("1");
            }
            else if(genPos == 2){
                this.gameObject.transform.position = new Vector3 (84,16,75);
                print("2");
            }
            else if(genPos == 3){
                this.gameObject.transform.position = new Vector3 (23,16,75);
                print("3");
            }
            else if(genPos == 4){
                this.gameObject.transform.position = new Vector3 (23,16,75);
                print("4");
            }
            
            
        }

    }
}
