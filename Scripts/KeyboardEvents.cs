using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class KeyboardEvents : MonoBehaviour
{
    [Serializable]
    public struct KeyboardEvent
    {
        public string name;
        public KeyCode keyCode;
        public UnityEvent<KeyCode> onKeyDown;
    }

    public List<KeyboardEvent> events;

    void Update()
    {
        foreach (var keyboardEvent in events)
        {
            if (Input.GetKeyDown(keyboardEvent.keyCode))
            {
                keyboardEvent.onKeyDown.Invoke(keyboardEvent.keyCode);
            }
        }
    }
}
