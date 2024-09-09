using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalToEvent : MonoBehaviour
{
    [Flags]
    public enum Signal
    {
        Awake = 1,
        Start = 2,
        Update = 4,
        FixedUpdate = 8,
        LateUpdate = 16
    }

    [SerializeField]
    private Signal _signal;
    
    [SerializeField]
    private UnityEvent _onSignal;

    void Awake()
    {
        if ((_signal & Signal.Awake) != 0)
            _onSignal.Invoke();
    }
    
    void Start()
    {
        if ((_signal & Signal.Start) != 0)
            _onSignal.Invoke();
    }
    
    void Update()
    {
        if ((_signal & Signal.Update) != 0)
            _onSignal.Invoke();
    }
    
    void FixedUpdate()
    {
        if ((_signal & Signal.FixedUpdate) != 0)
            _onSignal.Invoke();
    }
    
    void LateUpdate()
    {
        if ((_signal & Signal.LateUpdate) != 0)
            _onSignal.Invoke();
    }
}
