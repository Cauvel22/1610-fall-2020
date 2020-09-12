using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
   public float speed = 3f,x,y,z;
   public float health = 1;
   public float score = 0;
   public int ammo = 0;

   public void Update()
   {
      //figure out a way to get the speed to happen all at once to seem like its jumping from place to place.
      x = speed * Time.deltaTime * Input.GetAxis("Horizontal")*5;
      y = speed * Time.deltaTime * Input.GetAxis("Vertical")*5;
      transform.Translate(x,y,z);
      //I want this script to pause after each time it jumps.
   }
}
