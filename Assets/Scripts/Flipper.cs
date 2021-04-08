// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    HingeJoint2D joint;
    Transform _flipperScale;

    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
        _flipperScale = GetComponent<Transform>();
    }

    // push space to turn the motor on
    // release space to turn the motor off
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && _flipperScale.localScale.x == -1)
        {
            joint.useMotor = true;
        }
        else if (Input.GetKey(KeyCode.D) && _flipperScale.localScale.x == 1)
        {
            joint.useMotor = true;
        }
        else
        {
            joint.useMotor = false;
        }
    }
}
