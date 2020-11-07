using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameAction : ScriptableObject
{
    public UnityAction action;

    public void raise()
    {
        action.Invoke();
    }



}
