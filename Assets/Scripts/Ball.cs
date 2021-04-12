using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    AudioSource _audioSource;
    BallStopper _ballStopper;
    PolygonCollider2D _ballStopCollider;
    Rigidbody2D _ballRigidBody;
    Camera _mainCamera;
    

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _mainCamera = FindObjectOfType<Camera>();
        _ballRigidBody = this.GetComponent<Rigidbody2D>();
        _ballStopper = FindObjectOfType<BallStopper>();
        _ballStopCollider = _ballStopper.GetComponent<PolygonCollider2D>();
    }
    private void Update()
    {
        if (_ballRigidBody.velocity.magnitude <= 0.8 && Input.GetKeyDown(KeyCode.Space) && _ballStopCollider.isTrigger)
        {
            _audioSource.Play();
            _ballRigidBody.AddForce(new Vector2(1f, Random.Range(300f, 600f)));
        }
    }
}
