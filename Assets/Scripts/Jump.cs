using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody susbody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 forceVector = Vector3.up * jumpForce;
            susbody.AddForce(forceVector);
            print("Down");
        }
        else if (Input.GetButton("Jump"))
        {
            print("Hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            print("Up");
        }
    }
}
