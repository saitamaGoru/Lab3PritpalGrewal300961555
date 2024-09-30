using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent), typeof(Animator))]
public class Enemy : MonoBehaviour
{

    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject[] _patrolPoints;

    private StateMachine _stateMachine;
    // Start is called before the first frame update
    void Awake()
    {
        _player = GameObject.FindWithTag("Player");
        _animator = GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        _stateMachine = new StateMachine();
        var patrolState = new Patrol(_agent, _animator,_patrolPoints);
        var chaseState = new Chase(_agent, _animator,  _player);

        _stateMachine.AddTransition(patrolState, chaseState, 
        new FuncPredicate(() => Vector3.Distance(_player.transform.position, transform.position) < 2.0f));

        _stateMachine.AddTransition(chaseState, patrolState, 
        new FuncPredicate(() => Vector3.Distance(_player.transform.position, transform.position) > 12.0f));

        _stateMachine.SetState(patrolState);
    }

    // Update is called once per frame
    void Update()
    {
        _stateMachine.Update();
    }

    private void FixedUpdate()
    {
        _stateMachine.FixedUpdate();
    }
}
