using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerMovement movement;
    private Rigidbody rb;
    private Camera cam;
    private FollowPlayer follow;
    private float zRotation = 180f;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        follow = GameObject.Find("Main Camera").GetComponent<FollowPlayer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle" || collision.collider.tag == "Enemy")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            movement.Jump();
        }

        if (other.CompareTag("Gravity"))
        {
            // ***instantiate the Cam object's script***
            movement.gravity *= -1;
            movement.jumpForce *= -1;
            cam.transform.rotation = Quaternion.Euler(0, 0, zRotation);
            cam.transform.position = follow.reverseOffset;
            if (follow.offset.y == 1)
            {
                follow.offset.y = -1f;
            } else if (follow.offset.y == -1)
            {
                follow.offset.y = 1f;
            }

            if (zRotation >= 175)
            {
                zRotation = 0;
                FollowPlayer.reverse = false;
            }
        }
    }
}
