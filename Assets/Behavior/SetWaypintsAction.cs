using System;
using System.Collections.Generic;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Set Waypints", story: "Set [waypoints] from [patrollocations]", category: "Action", id: "8fc763c9a942cbccc8c1d7d9e6a4eed8")]
public partial class SetWaypintsAction : Action
{
    [SerializeReference] public BlackboardVariable<List<GameObject>> Waypoints;
    [SerializeReference] public BlackboardVariable<GameObject> Patrollocations;

    protected override Status OnStart()
    {
        for (int i=0; i<Patrollocations.Value.transform.childCount; i++)
            Waypoints.Value.Add(Patrollocations.Value.transform.GetChild(i).gameObject);

        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

