using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBateria : MonoBehaviour
{
    public float speed = 2.0f;
    private float maxX = 8f;
    private float minX = -8f;
    private Vector2 direction = Vector2.left;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x >= maxX)
        {
            direction = Vector2.left;
        }
        else if (transform.position.x <= minX)
        {
            direction = Vector2.right;
        }

    }
}
