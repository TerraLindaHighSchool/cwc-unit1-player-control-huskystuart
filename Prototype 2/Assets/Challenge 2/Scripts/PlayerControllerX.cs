﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float startTime = Time.time;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - startTime > 3)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                startTime = Time.time;
            }
        }
    }
}
