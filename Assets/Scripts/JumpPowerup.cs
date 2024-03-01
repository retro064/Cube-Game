using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{
    public float hoverSpeed = 0.25f;
    public float yPosMin = 1.0f;
    public float yPosMax = 1.5f;

    void Update()
    {
        transform.Translate(0, hoverSpeed * Time.deltaTime, 0);
        if (transform.position.y >= yPosMax)
        {
            hoverSpeed *= -1;
        } else if (transform.position.y < yPosMin)
        {
            hoverSpeed *= -1;
        }
    }
}
