using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingPropeller : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 160);
    }
}
