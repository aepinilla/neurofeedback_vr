using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialsController : MonoBehaviour
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

    private string activeScene;

    private GameObject SAMCalib;
    private GameObject activeStimuli;
    public GameObject GazePointer;
    private GameObject stimuli;
    private string activeTrial;


    void Start()
    {
        Invoke("LoadStimuli", 2.0F);
        cam = oculusCamera.GetComponent<Camera>();
    }

    public void Update()
    {
        activeTrial = GameTrialObject.name;
    }

    public void LoadStimuli()
    {
        GazePointer.SetActive(false);
        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = true;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 2.0f, -10.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = true;

        TrialText.SetActive(false);
        Debug.Log(activeScene);

        if (activeTrial == "Game1")
        {
            activeScene = PlayerPrefs.GetString("FirstScene");
            activeStimuli = GameTrialObject.transform.Find(activeScene).gameObject;
            activeStimuli.SetActive(true);
            //Debug.Log("Exciting");
        }

        if (activeScene == "Game2")
        {
            activeScene = PlayerPrefs.GetString("SecondScene");
            activeStimuli = GameTrialObject.transform.Find(activeScene).gameObject;
            activeStimuli.SetActive(true);
            Debug.Log(activeScene);
        }

        if (activeScene == "Game3")
        {
            activeScene = PlayerPrefs.GetString("ThirdScene");
            activeStimuli = GameTrialObject.transform.Find(activeScene).gameObject;
            activeStimuli.SetActive(true);
            //Debug.Log("Depressing");
        }

        if (activeScene == "Game4")
        {
            activeScene = PlayerPrefs.GetString("FourthScene");
            activeStimuli = GameTrialObject.transform.Find(activeScene).gameObject;
            activeStimuli.SetActive(true);
            //Debug.Log("Stressing");
        }

        if (activeScene == "Game5")
        {
            activeScene = PlayerPrefs.GetString("FifthScene");
            activeStimuli = GameTrialObject.transform.Find(activeScene).gameObject;
            activeStimuli.SetActive(true);
            //Debug.Log("Neutral");
        }

    }
}