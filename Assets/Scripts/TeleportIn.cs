using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportIn : MonoBehaviour
{
    TeleportOut _teleportOut;
    // Start is called before the first frame update
    void Start()
    {
        _teleportOut = FindObjectOfType<TeleportOut>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "The Almighty Ball")
        {
            other.GetComponent<TrailRenderer>().time = 0f;
            other.transform.position = _teleportOut.transform.position;
        }
    }

}
