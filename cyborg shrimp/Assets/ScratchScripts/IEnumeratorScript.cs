using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IEnumeratorScript : MonoBehaviour
{
    private Rigidbody _rigid;
    public TextMeshPro countDownText;
    public float counter = 4;
    public Vector3 forces;

    private IEnumerator Start()
    {
        _rigid = GetComponent<Rigidbody>();

        while (counter > 0)
        {
            yield return new WaitForSeconds(3);
            counter--;
            countDownText.text = "" + counter;
            

        }

        while (counter == 0)
        {
            countDownText.text = "GO!";
            yield return new WaitForSeconds(1);
            Jump();
            counter--;
            
        }
    }

    void Jump()
    {
        countDownText.gameObject.SetActive(false);
        _rigid.AddForce(forces);
    }
}
