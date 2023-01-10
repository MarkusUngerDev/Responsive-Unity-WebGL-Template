using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float rotationSpeed = 1f;

    private void Update()
    {
        var addRotationSpeed = rotationSpeed * Time.deltaTime;
        transform.Rotate(addRotationSpeed, addRotationSpeed, addRotationSpeed);
    }
}