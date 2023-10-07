using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseLook : MonoBehaviour
{
    public float mouseSensitivity = 2.0f;
    private float rotationX = 0.0f;
    

    void Update()
    {
        float mouseX = Input.GetAxis("MouseX") * mouseSensitivity;
        float mouseY = Input.GetAxis("MouseY") * mouseSensitivity;


        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(rotationX, 0.0f, 0.0f);
        transform.parent.Rotate(Vector3.up * mouseX);
    }

}
