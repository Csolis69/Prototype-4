﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationSpeed;

    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}