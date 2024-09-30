using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class BaseState : IState
{
   protected readonly Animator _animator;
   //protected readonly GameObject _player; 
   protected readonly NavMeshAgent _agent;

   protected static readonly int _walk = Animator.StringToHash("Walk");
   protected static readonly int _run = Animator.StringToHash("Run");

   protected BaseState(NavMeshAgent agent, Animator animator)
   {
     this._agent = agent;
     this._animator = animator;
   }

   public virtual void OnEnter(){}
   public virtual void Update(){}
   public virtual void FixedUpdate(){}
   public virtual void OnExit(){}

}
