using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    BallStopper _ballStopper;
    PolygonCollider2D _ballStopCollider;
    Rigidbody2D _ballRigidBody;

    private void Start()
    {
        _ballRigidBody = this.GetComponent<Rigidbody2D>();
        _ballStopper = FindObjectOfType<BallStopper>();
        _ballStopCollider = _ballStopper.GetComponent<PolygonCollider2D>();
    }
    private void Update()
    {
        if (_ballRigidBody.velocity.magnitude <= 0.8 && Input.GetKeyDown(KeyCode.Space) && _ballStopCollider.isTrigger)
        {
            _ballRigidBody.AddForce(new Vector2(1f, Random.Range(300f, 600f)));
        }
    }
}
