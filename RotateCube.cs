using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 50f; // Serialize the field for inspection in the Unity Editor

    private void Update()
    {
        // Rotate the GameObject (cube) around its Y-axis
        RotateCube();
    }

    private void RotateCube()
    {
        // Rotate the cube around its Y-axis with a smooth rotation
        float rotationAmount = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotationAmount);
    }
}

