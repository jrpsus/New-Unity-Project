using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot2D : MonoBehaviour
{
    public float SlingshotForce;
    public Rigidbody2D rb;
    Vector3 startMousePos;
    bool draggingBallZ = false;

    Vector3 mouseVector;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && draggingBallZ)
        {
            mouseVector = Input.mousePosition - startMousePos;
            rb.AddForce(-mouseVector * SlingshotForce);
            draggingBallZ = false;
        }
    }

    private void OnMouseDown()
    {
        startMousePos = Input.mousePosition;
        draggingBallZ = true;
    }
}
