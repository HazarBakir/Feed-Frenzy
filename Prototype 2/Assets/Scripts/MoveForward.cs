using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{


    public float speed = 40.0f;

    void LateUpdate()
    {
        //Move the object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
