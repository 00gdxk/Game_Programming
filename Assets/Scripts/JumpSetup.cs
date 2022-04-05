// credit: https://www.youtube.com/watch?v=D46vCnT7baY
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class JumpSetup : MonoBehaviour
{
    
    private Rigidbody rb;
    private bool jumpping = false;
    public float jumpHeight = 8.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpHeight;
            jumpping = true;
        }

        else if (jumpping && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpHeight;
            jumpping = false;
        }
    }

    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.0f);
    }
}
