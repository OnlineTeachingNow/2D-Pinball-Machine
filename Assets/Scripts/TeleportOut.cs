using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOut : MonoBehaviour
{
    float _velocityIncrease = 30f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball")
        {
            other.GetComponent<TrailRenderer>().time = 0.3f;
            float _xForce = Random.Range(-1, 1);
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(_xForce, 1)*_velocityIncrease;
        }
    }
}
