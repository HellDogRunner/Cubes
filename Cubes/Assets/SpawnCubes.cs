using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class SpawnCubes : MonoBehaviour
{

    public float timeBtwSpawns;
    public float startTimeBtwSpawns=10000;
    public GameObject cube;
    public Vector3 SpawnPoint;

    private string Sinput;
    private string Dinput;
    private string Tinput;

    public InputField speedInput;
    public InputField DistInput;
    public InputField StartInput;

    public float disanceToCover;
    public int speed;
    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (startTimeBtwSpawns< timeBtwSpawns)
        {
            timeBtwSpawns = startTimeBtwSpawns;
        }
        if (timeBtwSpawns<=0)
        {
            cube = Instantiate(cube, SpawnPoint, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
    public void ReadStringInput()
    {
        Sinput = speedInput.text;
        Dinput = DistInput.text;
        int.TryParse(Sinput, out speed);
        float.TryParse(Dinput, out disanceToCover);
    }
    public void TimeInput()
    {
        Tinput = StartInput.text;
        float.TryParse(Tinput, out startTimeBtwSpawns);
    }
}
