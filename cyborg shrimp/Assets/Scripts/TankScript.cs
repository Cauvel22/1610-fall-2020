using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    
    public float speed = 3f, x, y, z;
    public float health = 10;
    public int point = 0;
    public string password = "Shukaka";
    private void Start()
    {
        Debug.Log("My name's Lil'Billy!");
    }

    private void Update()
    {
        x = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        y = speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(x,y,z);
    }
}
