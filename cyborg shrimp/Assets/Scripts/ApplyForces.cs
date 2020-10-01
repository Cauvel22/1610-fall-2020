using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
   public Rigidbody rBody;
   public float force = 100f;

   private void OnMouseDown()
   {
      rBody.AddForce(0,force,0);
   }
}
