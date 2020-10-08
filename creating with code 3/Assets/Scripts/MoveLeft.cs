using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 3f;
    public PlayerController playerControllerScript;

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
        else
        {
            transform.Translate(0,0,0);
        }
    } 

   
}
