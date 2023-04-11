using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Player : MonoBehaviour
{
    NavMeshAgent agent;
    float x, y;
    Vector3 pos;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        pos = new Vector3(x, 0, y);
        agent.Move(pos * 10 * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Target")
        {
            Destroy(collision.gameObject);
        }
    }
}
