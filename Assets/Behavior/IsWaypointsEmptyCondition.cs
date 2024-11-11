using System;
using System.Collections.Generic;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "IsWaypointsEmpty", story: "Are [waypoints] empty?", category: "Conditions", id: "cfe6e70accb77f4e92a06b486dbf92c5")]
public partial class IsWaypointsEmptyCondition : Condition
{
    [SerializeReference] public BlackboardVariable<List<GameObject>> Waypoints;

    public override bool IsTrue()
    {
        return Waypoints.Value.Count <=0;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
