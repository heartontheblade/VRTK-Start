using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform goal;
    public float _wheelCircle;
    public Transform[] Wheels;

    private bool movable;

    // Start is called before the first frame update
    void Start()
    {
        movable = false;
        agent.enabled = false;
    }

    // Update is called once per frame
    
    
    //根据车速转动车轮
    void FixedUpdate()
    {
        if (movable)
        {
            //print("ss");
            float _angularSpeed = (agent.velocity.magnitude / _wheelCircle) * 360 * 0.2f;
            for (int i = 0; i < Wheels.Length; i++)
            {
                Wheels[i].Rotate(Vector3.right, _angularSpeed * Time.fixedDeltaTime);
            }
        }
    }

    public void Activate()
    {
        movable = true;
        agent.enabled = true;
        agent.SetDestination(goal.transform.position);
    }
}
