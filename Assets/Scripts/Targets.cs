using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Targets : MonoBehaviour
{
    NavMeshAgent agent;
    public List<Transform> target = new List<Transform>();
    private int destinationPoint;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (Vector3.Distance(target[destinationPoint].position, transform.position) > 1)
        {
            agent.SetDestination(target[destinationPoint].position);
            
        }
        else
        {
            destinationPoint++;

            if (destinationPoint==target.Count)
            {

                destinationPoint = 0;
            }
            
        }
    }
}
