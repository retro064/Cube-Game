using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZaggerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float forwardForce = 6000.0f;
    public float sidewaysForce = 5.0f;
    public float xDistance = 6;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector3.back * forwardForce * Time.deltaTime);

        // rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        transform.Translate(sidewaysForce * Time.deltaTime, 0, 0);
        if (transform.position.x >= xDistance)
        {
            // Debug.Log("Right");
            sidewaysForce *= -1;
        }
        else if (transform.position.x <= -xDistance)
        {
            // Debug.Log("Left");
            sidewaysForce *= -1;
        }
    }
}
