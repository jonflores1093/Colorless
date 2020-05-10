﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(-10, -1, 0);
    }
}

