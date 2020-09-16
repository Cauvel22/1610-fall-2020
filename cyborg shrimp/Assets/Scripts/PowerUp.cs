using System;
using UnityEditor;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int score;
    public Vector3 RotationVector3;
    public float speed = 10f;
    private void OnTriggerEnter(Collider other)
    {
       score++;
       print(score);
    }

    private void Update()
    {
        RotationVector3.y = speed * Time.deltaTime;
        transform.Rotate(RotationVector3);
    }
}