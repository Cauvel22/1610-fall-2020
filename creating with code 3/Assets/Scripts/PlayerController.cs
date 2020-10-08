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
    public bool gameOver;
    
    
    void Start()
    {
        gameOver = ScriptableObject.CreateInstance<BoolData>();
        PlayerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        gameOver = false;
        isOnGround = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over");
        }
    }
}