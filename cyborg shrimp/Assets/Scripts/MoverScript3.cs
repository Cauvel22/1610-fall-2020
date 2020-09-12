using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript3 : MonoBehaviour
{
    public float speed = 4f, x, y, z;
    public float health = 5;
    public int score = 0;
    public int ammo = 0;
    private void Update()
    {
        //balanced speed but reversed controls
        x = -speed * Time.deltaTime * Input.GetAxis("Horizontal");
        y = -speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(x,y,z);
        //maybe once we learn how to fire ammo give this player a special shooting?
    }
}
