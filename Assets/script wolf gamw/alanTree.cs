﻿using UnityEngine;
using System.Collections;

public class alanTree : MonoBehaviour {

    public Vector3 spawnPoint;

    
     private Transform camPos;
    private int ranXPos = Random.Range(-80, 80);


    // Use this for initialization
    void Start () {



        transform.position = new Vector3 (ranXPos, spawnPoint.y, spawnPoint.z);
        camPos = GameObject.Find("Main Camera").GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {

        transform.position += Vector3.back;
	
        if (transform.position.z < camPos.position.z)
        {

            Destroy(gameObject);
        }
	}
}
