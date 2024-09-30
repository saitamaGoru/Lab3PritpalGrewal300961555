using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : BaseState
{


    private GameObject[] _patrolPoints;
    private int _index;
    public Patrol(NavMeshAgent agent, Animator animator, GameObject[] patrolPoints)
    : base(agent,animator)
    {
        _patrolPoints = patrolPoints;
        _index = 0;
    }
    public override void OnEnter()
    {
        Debug.Log("Entering Patrol Mode");
        _agent.speed = 1.5f;
        _animator.Play("Walking");
    }

    public override void Update()
    {
        Vector3 destination = _patrolPoints[_index].transform.position;
        _agent.SetDestination(destination);

        if(Vector3.Distance(_agent.transform.position, destination)< 2.0f) _index = (_index + 1) % _patrolPoints.Length; 
    }
}
