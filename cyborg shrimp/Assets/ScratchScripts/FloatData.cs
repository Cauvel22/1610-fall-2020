using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }





}
