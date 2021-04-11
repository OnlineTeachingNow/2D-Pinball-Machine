using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject _ballStopper;
    [SerializeField] GameObject _launchZone;

    public void PlayerLoses()
    {
        _ballStopper.GetComponent<PolygonCollider2D>().isTrigger = true;
        this.transform.position = _launchZone.transform.position;
        this.GetComponent<TrailRenderer>().time = 0.3f;
    }
}
