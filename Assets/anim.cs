﻿using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //set the trigger when you press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("rotate");
        }

    }


    public void rotate()
    {
        GetComponent<Animator>().SetTrigger("rotate");
    }

    public void run()
    {
        GetComponent<Animator>().SetTrigger("run");
    }

    public void walk()
    {
        GetComponent<Animator>().SetTrigger("walk");
    }

    public void creep()
    {
        GetComponent<Animator>().SetTrigger("creep");
    }
    public void stop()
    {
        GetComponent<Animator>().SetTrigger("stop");
    }


}