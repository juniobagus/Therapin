﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;

    private CharacterController cc;

    //Coins Collect
    public int count;
    public Text cText;

    //falling effect
    public float fallSpeed = 8.0f;
    public float spinSpeed = 250.0f;

    // Use this for initialization
    void Start()
    {
        //Coins init
        count = 13;
        Counter();

        //Walk - Find the CharacterController component
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Look down to walk
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }

        if(transform.position.y < 1.5)
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
            transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
            moveForward = true;
        }

        if(transform.position.y < -15)
        {
            SceneManager.LoadScene("MainScene");
        }


    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CoinsTag"))
        {
            count = count - 1;
            Counter();
            Destroy(other.gameObject);
        }

        if(count == 0 )
        {
            cText.text = "Cari Trophy untuk menyelesaikan";
        }

        if (count == 0 && other.gameObject.CompareTag("TrophyTag"))
        {
            SceneManager.LoadScene("MainScene2");
        }
    }

    public void Counter()
    {
        cText.text = "Koin Tersisa: " + count.ToString();
    }
}
