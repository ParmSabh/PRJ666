﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    // Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
        //player movement
        //transform.Translate(Vector2.right * Input.GetAxis("Horizontal") *speed *  Time.deltaTime);
        //transform.Translate(Vector2.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
    }
    
}
