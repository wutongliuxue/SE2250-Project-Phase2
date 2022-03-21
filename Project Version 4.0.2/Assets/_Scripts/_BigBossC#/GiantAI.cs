using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Student Name: Tong Wu
 * Student Number: 251155168
 * Goal: Change Animation of Big Boss
 */

public class GiantAI : MonoBehaviour
{
   
    public GameObject Giant;
    public Animator animator;


    void Start(){
        animator = GetComponent<Animator>();
    }

    void onTriggerEnter(Collider other){
       animator.SetTrigger("Attack_1");
    }

    void onTriggerExit(Collider other){
        animator.SetTrigger("Rest");
    }
}
