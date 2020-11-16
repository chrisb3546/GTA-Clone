using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC001_INTERACT : MonoBehaviour
{
    // Start is calle
    public AudioSource [] VoiceLine;
    public int LineNumber;

 void OnTriggerEnter(Collider other){
     if(other.tag == "Player"){
           StartCoroutine(CharInteraction());
     }
   
 }
 IEnumerator CharInteraction(){
     this.gameObject.GetComponent<BoxCollider>().enabled = false;
     LineNumber = Random.Range(0,3);
     VoiceLine[LineNumber].Play();
     yield return new WaitForSeconds(2);
     this.gameObject.GetComponent<BoxCollider>().enabled = true;

 }
}


