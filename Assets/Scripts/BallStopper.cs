using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStopper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "The Almighty Ball")
        {
            this.GetComponent<PolygonCollider2D>().isTrigger = false;
        }
    }
}
