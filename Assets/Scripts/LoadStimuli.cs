using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStimuli : MonoBehaviour
{
    public GameObject oculusCamera;
    private Camera cam;

    public GameObject TrialText;

    public GameObject Feedback;
    public GameObject Sky;
    public GameObject Terrains;
    public GameObject StateChanger;
    public GameObject GameTimer;


    void Start()
    {
        cam = oculusCamera.GetComponent<Camera>();
        Invoke("LoadTrialStimuli", 3.0F);
    }


    public void LoadTrialStimuli()
    {
        TrialText.SetActive(false);

        Feedback.SetActive(true);
        Sky.SetActive(true);
        Terrains.SetActive(true);
        StateChanger.SetActive(true);
        GameTimer.SetActive(true);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = true;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 2.0f, -10.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = true;

        
    }
}