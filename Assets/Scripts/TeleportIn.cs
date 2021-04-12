using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportIn : MonoBehaviour
{
    TeleportOut _teleportOut;
    ScoreBoard _scoreBoard;
    int _teleportValue = 20;

    void Start()
    {
        _teleportOut = FindObjectOfType<TeleportOut>();
        _scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball")
        {
            _scoreBoard.IncreaseScore(_teleportValue);
            other.GetComponent<TrailRenderer>().time = 0f;
            other.transform.position = _teleportOut.transform.position;
        }
    }

}
