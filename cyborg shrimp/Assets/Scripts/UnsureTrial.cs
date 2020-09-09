using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnsureTrial : MonoBehaviour
{
    public float speed = 4f;
    public float x, y, z;
    void Start()
    {
        Debug.Log("I think this'll all work");
    }
    
    void Update()
    {
        x = speed * Input.GetAxis("Horizontal")*Time.deltaTime;
        y = speed * Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(x,y,z);
    }
}
