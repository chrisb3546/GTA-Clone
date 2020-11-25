using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCDeath : MonoBehaviour
{
    public int NPCHealth = 20;
    public bool NPCDead = false;
    public GameObject NpcObj;
    public GameObject InteractionTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void HurtNPC(int ShotDamage){
        NPCHealth -= ShotDamage;
        if (NPCHealth <= 0 && NPCDead == false){
            NPCDead = true;
            StartCoroutine(NPCDying());
        }
    }
    // Update is called once per frame
    void Update()
    {
        // this.gameObject.transform.position = NpcObj.transform.position  ;
        
    }
    IEnumerator NPCDying(){
        this.GetComponent<NPCAI>().enabled = false;
        this.GetComponent<NavMeshAgent>().enabled = false;
        NpcObj.GetComponent<BoxCollider>().enabled = false;
        // this.GetComponent<BoxCollider>().enabled = false;
        InteractionTrigger.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<Animation>().Play("Standing React Death Backward");

    }
}
