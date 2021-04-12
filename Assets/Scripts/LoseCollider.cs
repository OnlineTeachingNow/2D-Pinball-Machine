using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] GameObject _launchZone;
    [SerializeField] Ball _ball;
    BallStopper _ballStopper;
    ScoreBoard _scoreBoard;
    AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _scoreBoard = FindObjectOfType<ScoreBoard>();
        _ballStopper = FindObjectOfType<BallStopper>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball")
        {
            _audioSource.Play();
            _ballStopper.ToggleIsTrigger(true);
            _scoreBoard.DecreaseLives();
            Destroy(other.gameObject);
            Instantiate(_ball, _launchZone.transform.position, Quaternion.identity);
        }
    }
}
