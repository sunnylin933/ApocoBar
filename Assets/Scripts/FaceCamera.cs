using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    
    Transform lookTarget;
    void Start()
    {
        lookTarget = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(lookTarget);
    }
}
