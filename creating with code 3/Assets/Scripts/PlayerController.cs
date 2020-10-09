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
    private Animator playerAnim;
    public ParticleSystem explosion;
    public ParticleSystem dirt;
    public AudioClip jump;
    public AudioClip crash;
    private AudioSource playerAudio;
    

    void Start()
    {
        gameOver = ScriptableObject.CreateInstance<BoolData>();
        PlayerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        gameOver = false;
        isOnGround = true;
        playerAudio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirt.Stop();
            playerAudio.PlayOneShot(jump, 7.0f);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirt.Play();
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosion.Play();
            dirt.Stop();
            playerAudio.PlayOneShot(crash, 1.0f);
        }
    }
}