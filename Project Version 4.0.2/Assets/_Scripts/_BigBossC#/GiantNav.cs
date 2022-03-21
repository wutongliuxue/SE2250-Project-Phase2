using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*
 * Student Name: Tong Wu
 * Student Number: 251155168
 * Goal: Set Big Boss A Destination 
 */

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject theDestination;
    NavMeshAgent theAgent;


    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        theAgent.SetDestination(theDestination.transform.position);
    }
}
