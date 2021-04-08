using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleScript : MonoBehaviour
{
    [SerializeField] [Range(0f, 1f)] float _timeScale;

    private void Update()
    {
        Time.timeScale = _timeScale;
    }
}
