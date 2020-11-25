using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingPistol : MonoBehaviour
{
    public bool isAiming = false;
    public GameObject ThePlayer;
    public AudioSource PistolShot;
    public static bool isFiring;
    public GameObject AimingNotice;

    public static float DistanceFromTarget;
    public float ToTarget;
    public int ShotDamage;
    

    
    void Update()
    {
        RaycastHit Hit;
        if (Input.GetKey("e")){
            isAiming = true;
            ThePlayer.GetComponent<Animation>().Play("Aiming 1Pistol");
            AimingNotice.SetActive(true);
        }
        else{
            isAiming = false;
            ThePlayer.GetComponent<Animation>().Play("Idle");
            AimingNotice.SetActive(false);
        }
        if(isAiming == true && Input.GetMouseButton(0)){
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
            {
                ToTarget = Hit.distance;
                DistanceFromTarget = ToTarget;
                ShotDamage = 20;
                Hit.transform.SendMessage("HurtNPC", ShotDamage, SendMessageOptions.DontRequireReceiver);
            }
            isFiring = true;
            PistolShot.Play();
            ThePlayer.GetComponent<Animation>().Play("Fire 1Pistol");
            StartCoroutine(FireThePistol());
        }
        
    }
    IEnumerator FireThePistol(){
        yield return new WaitForSeconds(1.0f);
        isFiring = false;
    }

}
