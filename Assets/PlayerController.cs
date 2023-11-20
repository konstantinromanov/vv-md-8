using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[Header("References")]
    //public Rigidbody rb;
    //public Transform head;
    //public Camera camera;

    //[Header("Configurations")]
    //public float walkSpeed;
    //public float runSpeed;

    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 2f);

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    //private void FixedUpdate()
    //{
    //    //Vector3 newVelocity = Vector3.up * rb.velocity.y;
    //    //float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
    //    //newVelocity.x = Input.GetAxis("Horizontal") * speed;
    //    //newVelocity.z = Input.GetAxis("Vertical") * speed;
    //    //rb.velocity = newVelocity;
    //}

    //private void LateUpdate()
    //{
    //    //Vector3 e = head.eulerAngles;
    //    //e.x -= Input.GetAxis("Mouse Y") * 2f;
    //    //e.x = Mathf.Clamp(e.x, -85f, 85f);
    //    //head.eulerAngles = e;
    //}

    //private static float RestrictAngle(float angle, float angleMin, float angleMax)
    //{
    //    if (angle > angleMax)
    //    {
    //        return angleMax;
    //    }

    //    if(angle < angleMin)
    //    {
    //        return angleMin;
    //    }

    //    return angle;
    //}
}
