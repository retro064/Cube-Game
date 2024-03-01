using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerMovement : MonoBehaviour
{
    public float forwardForce = 7500.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.Translate(0, 0, speed * Time.deltaTime);
        rb.AddForce(Vector3.back * forwardForce * Time.deltaTime);
    }
}
