using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour

{
   public float horizontalInput;
   public float speed = 3f;
   private void Update()
   {
      horizontalInput = Input.GetAxis("Horizontal") *speed*Time.deltaTime;
   }
}
