using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusteredColliderBumpers : MonoBehaviour
{
    float _velocityIncreaseFactor = -10f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D _otherRigidBody = other.gameObject.GetComponent<Rigidbody2D>();
        if (_otherRigidBody.velocity.magnitude <= 50f)
        {
            _otherRigidBody.velocity = new Vector2 (_otherRigidBody.velocity.x + Random.Range(-1f, 1f), _otherRigidBody.velocity.y + Random.Range(-1f, 1f))* _velocityIncreaseFactor;
        }
        else
        {
            _otherRigidBody.velocity *= -1;
        }
    }
}
