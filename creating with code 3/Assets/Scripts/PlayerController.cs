using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround;
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround)
        {
            PlayerRb.AddForce(Vector3.up * 8, ForceMode.Impulse);
            isOnGround = false;
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        isOnGround = true;
    }
}
