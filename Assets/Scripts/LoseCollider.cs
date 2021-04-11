using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    Ball _ball;
    private void Start()
    {
        _ball = FindObjectOfType<Ball>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<TrailRenderer>().time = 0f;
        _ball.PlayerLoses();
    }
}
