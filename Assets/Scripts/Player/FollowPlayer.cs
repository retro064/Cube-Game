using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Vector3 reverseOffset = new Vector3(0, -1.6f, -5.5f);
    public static bool reverse = false;
    public float smoothTime = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
