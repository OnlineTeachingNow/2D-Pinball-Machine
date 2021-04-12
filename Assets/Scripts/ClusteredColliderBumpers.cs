using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusteredColliderBumpers : MonoBehaviour
{
    float _velocityIncreaseFactor = -10f;
    ScoreBoard _scoreBoard;
    int _thisBumperValue = 5;
    [SerializeField] AudioClip[] _roundSounds;
    AudioSource _audioSource;
    private void Start()
    {
        _audioSource = this.GetComponent<AudioSource>();
        _scoreBoard = FindObjectOfType<ScoreBoard>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        var _randomNumber = Random.Range(0, 4);
        _audioSource.clip = _roundSounds[_randomNumber];
        _audioSource.Play();
        _scoreBoard.IncreaseScore(_thisBumperValue);
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
