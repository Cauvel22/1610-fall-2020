using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class BoolData : ScriptableObject
{
    public bool value;


    public void UpdateValue(bool newValue)
    {
        value = newValue;
        Debug.Log("Game Over");
    }
}
