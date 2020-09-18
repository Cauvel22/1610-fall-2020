using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    public int score;
    public Vector3 RotationVector3;
    public float speed = 10f;
    public UnityEvent powerUpEvent
    private void OnTriggerEnter(Collider other)
    {
       score++;
       print(score);
    }

    private void Update()
    {
        RotationVector3.y = speed * Time.deltaTime;
        transform.Rotate(RotationVector3);
        //UnityEvent.invoke;
    }
}