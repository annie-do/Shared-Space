﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public Vector3 rotationAmount;
    public float speed;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAmount * speed * Time.deltaTime, angle);
    }
}
