using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PropellerSpin : MonoBehaviour


{
    public float speed;
    public Vector3 rotationDirection;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward *3f);
    }
}
