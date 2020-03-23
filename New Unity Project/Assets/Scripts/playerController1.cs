using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController1 : MonoBehaviour
{
    public float movSpeed = 5.0f;
    public float mouseSensitivity = 1.0f;

    float rotUpDown = 0;
    public float upDownLimit = 60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotations

        // X

        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);

        // Y

        rotUpDown -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotUpDown = Mathf.Clamp(rotUpDown, -upDownLimit, upDownLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(rotUpDown, 0, 0);

        // Movements

        float forwardSpeed = Input.GetAxis("Vertical") * movSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movSpeed;

        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);

        speed = transform.rotation * speed;

        CharacterController cc = GetComponent<CharacterController>();

        cc.SimpleMove( speed );
    }
}
