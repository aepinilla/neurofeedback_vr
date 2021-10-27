// Controls the sequence of the stimuli in the second experimental trial.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomTrialsController2 : MonoBehaviour
{
    public GameObject oculusCamera;
    private Camera cam;

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

    public GameObject TrialText;
    public GameObject GameTrialObject;

    private string activeParticles;

    private GameObject SAMCalib;
    private GameObject activeStimuli;
    public GameObject GazePointer;
    private GameObject stimuli;
    private string activeTrial;

    private string activeObject;
    private string previousActiveObject = "null";

    private float timer = 0.0f;
    private float waitTime = 1.0f;

    private string participant;
    private string group;
    private string timestamp;
    private string stateLog;


    void Start()
    {
        cam = oculusCamera.GetComponent<Camera>();
    }

    public void Update()
    {
        activeTrial = GameTrialObject.name;
        activeObject = PlayerPrefs.GetString("ActiveObject");

        if (activeObject != previousActiveObject)
        {
            Invoke("LoadSecondStimuli", 2.0F);
        }

        previousActiveObject = activeObject;

        participant = PlayerPrefs.GetString("participant");
        activeParticles = PlayerPrefs.GetString("SecondTrial");
        group = PlayerPrefs.GetString("group");
        timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd,HH.mm.ss");
        stateLog = participant + "," + group + "," + activeParticles;

        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            System.IO.File.WriteAllText(@"States\" + timestamp + ".csv", stateLog);
            timer = timer - waitTime;
        }
    }

    public void LoadSecondStimuli()
    {
        GazePointer.SetActive(false);
        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = true;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 2.0f, -10.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = true;

        TrialText.SetActive(false);

        activeParticles = PlayerPrefs.GetString("SecondTrial");
        activeStimuli = GameTrialObject.transform.Find(activeParticles).gameObject;
        activeStimuli.SetActive(true);

    }
}