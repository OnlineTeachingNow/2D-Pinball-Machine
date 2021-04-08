using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    //probably going to want to find object of type and create a permanent reference to the ball where the trail renderer can be toggled on and off. 
    //or create a script where the ball is listening for either an "out of bounds" or "teleport" event, in which case the ball will toggle off it's trail renderer.
    private void OnTriggerEnter2D(Collider2D other)
    {
        //TrailRenderer _otherTrailRenderer = other.GetComponent<TrailRenderer>();
        //_otherTrailRenderer.enabled = !_otherTrailRenderer.enabled;
        other.transform.position = new Vector2(-3.56f, 13.44f);
    }
}
