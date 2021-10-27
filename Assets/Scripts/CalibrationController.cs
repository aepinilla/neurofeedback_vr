using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CalibrationController : MonoBehaviour
{
    public GameObject oculusCamera;
    private Camera cam;

    public GameObject RecallObject;

    private GameObject RecallText;
    public GameObject Stimuli;
    private GameObject SAMCalib;
    public GameObject GazePointer;

    public GameObject NeutralParticles;
    public GameObject ExcitingParticles;
    public GameObject CalmingParticles;
    public GameObject DepressingParticles;
    public GameObject StressingParticles;

    public static bool isStimuliActivated;


    void Start()
    {
        Invoke("LoadStimuli", 5.0F);
        Invoke("LoadSamCalib", 25.0F);

        cam = oculusCamera.GetComponent<Camera>();
    }

    public void LoadStimuli()
    {
        RecallText = RecallObject.transform.Find("RecallText").gameObject;

        GazePointer.SetActive(false);
        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = true;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 2.0f, -10.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = true;

        RecallText.SetActive(false);
        Stimuli.SetActive(true);

        isStimuliActivated = true;

    }

    public void LoadSamCalib()
    {
        SAMCalib = RecallObject.transform.Find("SAMCalib").gameObject;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.white;

        GazePointer.SetActive(true);
        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 2.0f, -10.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        NeutralParticles.SetActive(false);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);

        Stimuli.SetActive(false);
        SAMCalib.SetActive(true);

        isStimuliActivated = false;

    }
}