using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
  public GameObject ThePlayer;
  public bool isRunning;
  public float horizontalMove;
  public float verticalMove;
  public int stepNum;
  public bool isStepping = false;
  public AudioSource leftStep;
  public AudioSource rightStep;



    void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical")){
            // ThePlayer.GetComponent<Animation>().Play("Run");
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 6;
            isRunning = true;
            if(isStepping == false){
                StartCoroutine(RunSound());
            }
            transform.Rotate(0, horizontalMove, 0);
            transform.Translate(0, 0 , verticalMove);
        }
        else{

            if(AimingPistol.isFiring == false){
                ThePlayer.GetComponent<Animation>().Play("Idle");
                isRunning = false;
            }
           
        }
        
    }

    IEnumerator RunSound(){
        if(isRunning == true && isStepping == false ){
            isStepping = true;
            stepNum = Random.Range(1,3);
            if(stepNum == 1){
                leftStep.Play();
            }
            else {
                rightStep.Play();
            }
            
        }
        yield return new WaitForSeconds(0.3f);
        isStepping = false;
    }
}
