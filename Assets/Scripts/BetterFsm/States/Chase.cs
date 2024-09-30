using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : BaseState
{
    private GameObject _player;
    public Chase(NavMeshAgent agent, Animator animator, GameObject player)
    :base(agent, animator)
    {
        _player = player;
    }

    public override void OnEnter()
    {
        Debug.Log("Chase Started.......");
        _agent.speed = 4f;
        _animator.Play("Running");
    }

    public override void Update()
    {
        _agent.SetDestination(_player.transform.position);
    }

    public override void OnExit()
    {
        Debug.Log("Back to patrol, player ran away");
        
    }
}
