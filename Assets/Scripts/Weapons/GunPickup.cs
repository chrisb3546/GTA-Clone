using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour
{
    public GameObject OurGun;
    public AudioSource GunGrab;
    public GameObject PistolFireObj;

    // Start is called before the first frame update
   void OnTriggerEnter(){
       GunGrab.Play();
       OurGun.SetActive(true);
       this.gameObject.SetActive(false);
       PistolFireObj.SetActive(true);


   }
}
