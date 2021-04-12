using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStopper : MonoBehaviour
{
    PolygonCollider2D _thisCollider;

    private void Start()
    {
        _thisCollider = GetComponent<PolygonCollider2D>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball" && _thisCollider.isTrigger)
        {
            StartCoroutine(ChangingTriggerAfterBallCollision());
        }
    }

    private IEnumerator ChangingTriggerAfterBallCollision()
    {
        yield return new WaitForSeconds(0.15f);
        _thisCollider.isTrigger = false;
    }

    public void ToggleIsTrigger(bool isTrigger)
    {
        this.GetComponent<PolygonCollider2D>().isTrigger = isTrigger;
    }
}
