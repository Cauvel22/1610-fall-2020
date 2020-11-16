
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    public float speed = 5.0f;
    public float turnSpeed;
    private float _horizontalInput;
    private float _forwardInput;

    void Update()
    {
        //player movement
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        //forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * _forwardInput);
        //player turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * _horizontalInput);
    }
}
