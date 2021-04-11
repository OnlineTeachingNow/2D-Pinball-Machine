using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleBumpers : MonoBehaviour
{
    float _velocityIncreaseFactor = 200f;
    Vector2 _velocityVector;
    [SerializeField] bool _isRightSide;
    
    private void Start()
    {
        if (_isRightSide)
        {
            _velocityVector = new Vector2(-1f, 1f);
        }
        else
        {
            _velocityVector = new Vector2(1f, 1f);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "The Almighty Ball")
        {
            Debug.Log("in collision triangle bumper");
            Rigidbody2D _ball = other.GetComponent<Rigidbody2D>();
           _ball.AddForce(_velocityVector * _velocityIncreaseFactor);            
        }        
    }
}
