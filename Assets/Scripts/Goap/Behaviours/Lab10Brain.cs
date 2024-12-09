using CrashKonijn.Goap.Behaviours;
using KBCore.Refs;
using UnityEngine;

namespace Lab10.Goap
{
	[RequireComponent(typeof(AgentBehaviour))]
	public class Lab10Brain : ValidatedMonoBehaviour
	{
		[SerializeField, Self] private AgentBehaviour brain;
		[SerializeField, Scene] private GoapRunnerBehaviour runner;

		private void Awake()
		{
			brain.GoapSet = runner.GetGoapSet("Lab10");
		}

		private void Start()
		{
			brain.SetGoal<WanderGoal>(false);
		}
	}
}