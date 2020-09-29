﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour

{
    private float topBoundary = 35f;
    private float lowerBoundary = -10;

    private void Update()
    {
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }else if (transform.position.z< lowerBoundary)
        {
            Debug.Log("Git Gud Scrub!");
            Destroy(gameObject);
        }
        {
            
        }
    }
}