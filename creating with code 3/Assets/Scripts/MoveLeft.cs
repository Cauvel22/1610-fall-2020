using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 3f;
    public PlayerController playerControllerScript;
    private float leftBoundary = -10;

    public void Start()
    {
        playerControllerScript =
            GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    private void Update()
    {
        
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBoundary && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    } 

   
}
