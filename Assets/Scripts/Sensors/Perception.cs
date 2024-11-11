using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Perception : MonoBehaviour
{
    
    public bool VisualDebug = true;

    protected virtual void Initialize(){}
    protected virtual void UpdatePerception(){}
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePerception();
    }
}
