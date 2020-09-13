using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleePickup : MonoBehaviour
{
    public int melee;
    private void OnTriggerEnter(Collider other)
    {
        melee++;
        print(melee);//I'd like it to show which pickup was gotten and how much there is
    }
}
