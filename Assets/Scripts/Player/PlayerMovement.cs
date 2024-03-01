using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 750f;
    public float gravity = 9.81f*5f;

    private void Update()
    {
        // Input
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -1f || rb.position.y > 35)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        // gets directory path
        /* string p1 = Application.dataPath;
        p1 = p1.Replace("/Assets", "");
        Debug.Log(p1); */
    }

    private void FixedUpdate()
    {

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(0, gravity * Time.deltaTime, 0, ForceMode.VelocityChange);
    }

    public void Jump()
    {
        rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
}
