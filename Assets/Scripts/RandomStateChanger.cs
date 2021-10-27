using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStateChanger : MonoBehaviour
{
    
    public GameObject ExcitingContainer;
    public GameObject DepressingContainer;
    public GameObject StressingContainer;
    public GameObject CalmingContainer;
    public GameObject NeutralContainer;

    public GameObject NeutralParticles;
    public GameObject ExcitingParticles;
    public GameObject CalmingParticles;
    public GameObject DepressingParticles;
    public GameObject StressingParticles;

    private string affectiveState;
    private float sceneIndex;
    public static string currentScene;


    private float timer = 0.0f;
    private float waitTime = 1.0f;

    private string participant;
    private string group;
    private string timestamp;
    private string stateLog;


    void Start()
    {
        participant = PlayerPrefs.GetString("participant");
        group = PlayerPrefs.GetString("group");
    }


    void Update()
    {
        sceneIndex = PlayerPrefs.GetFloat("CurrentSceneIndex");

        switch(sceneIndex)
        {
            case 1:
                currentScene = PlayerPrefs.GetString("FirstScene");
                break;
            case 2:
                currentScene = PlayerPrefs.GetString("SecondScene");
                break;
            case 3:
                currentScene = PlayerPrefs.GetString("ThirdScene");
                break;
            case 4:
                currentScene = PlayerPrefs.GetString("FourthScene");
                break;
            case 5:
                currentScene = PlayerPrefs.GetString("FifthScene");
                break;
        }


        timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd,HH.mm.ss");
        stateLog = participant + "," + group + "," + currentScene;

        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            System.IO.File.WriteAllText(@"States\" + timestamp + ".csv", stateLog);
            timer = timer - waitTime;
        }

        //Debug.Log("Current state is " + affectiveState);

    }
}
