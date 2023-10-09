using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotate the GameObject (cube) around its Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}

