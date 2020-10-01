using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer1 : MonoBehaviour
{
    public GameObject prefab;
    public float delay = 2f;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        
    }
}
