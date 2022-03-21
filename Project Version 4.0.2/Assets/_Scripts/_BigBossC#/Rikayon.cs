using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Student Name: Tong Wu
 * Student Number: 251155168
 * Goal: Change Animation of Big Boss
 */

public class Rikayon : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            animator.SetTrigger("Attack_1");
        }
		else if (Input.GetKeyDown(KeyCode.F)) {
            animator.SetTrigger("Attack_1");
        }
	}
}
