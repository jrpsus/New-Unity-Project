using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 0.2f;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 temp = this.transform.position;
        temp.x += speed * Time.deltaTime;
        this.transform.position = temp;
    }
}
