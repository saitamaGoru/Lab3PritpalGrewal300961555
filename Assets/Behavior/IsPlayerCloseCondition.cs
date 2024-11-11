using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "IsPlayerClose", story: "Is [Player] close to [self]", category: "Conditions", id: "7ca684887f7a18deea2559c52c00718b")]
public partial class IsPlayerCloseCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Player;
    [SerializeReference] public BlackboardVariable<GameObject> Self;

    public override bool IsTrue()
    {

        return Vector3.Distance(Player.Value.transform.position, Self.Value.transform.position) <= 2f;;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
