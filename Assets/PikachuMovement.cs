using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuMovement : MonoBehaviour
{
    public float speed = 3;
    public int frameCounter = 0;
    public bool moveForward = true;
    public int framesToMoveInOneDirection = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;

        if (frameCounter > framesToMoveInOneDirection)
        {
            frameCounter = 0;
            moveForward = !moveForward;
        }

        Vector3 moveDirection = moveForward ? Vector3.forward : Vector3.back;

        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
