using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class move : MonoBehaviour
{
    public Vector3 direction;
    public float distanceTravelled;
    public float disanceToCover;
    public int speed;
    public Vector3 spawnpoint;
    void Start()
    {
       GameObject camera = GameObject.Find("Camera");
        speed = camera.GetComponent<SpawnCubes>().speed;
        disanceToCover = camera.GetComponent<SpawnCubes>().disanceToCover;
        //speed = float.Parse(speedInput.text);
        //Debug.Log(speedInput.text);
    }


    void FixedUpdate()
    {
        if (disanceToCover>distanceTravelled)
        {
            transform.Translate(direction * Time.deltaTime*speed);
        }
        distanceTravelled = Vector3.Distance(spawnpoint, transform.position);
        if (distanceTravelled>= disanceToCover)
        {
            Destroy(gameObject);
        }
    }
}
