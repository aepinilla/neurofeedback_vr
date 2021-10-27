using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    public GameObject oculusCamera;
    private Camera cam;

    public GameObject NeutralTerrain;
    public GameObject ExcitingTerrain;
    public GameObject CalmingTerrain;
    public GameObject DepressingTerrain;
    public GameObject StressingTerrain;

    public GameObject NeutralParticles;
    public GameObject ExcitingParticles;
    public GameObject CalmingParticles;
    public GameObject DepressingParticles;
    public GameObject StressingParticles;

    public GameObject ExcitingSky;
    public GameObject DepressingSky;

    public GameObject FeedbackStressed;
    public GameObject FeedbackCalm;
    public GameObject FeedbackSad;
    public GameObject FeedbackExcited;
    public GameObject FeedbackNeutral;

    private string affectiveState;

    private float timer = 0.0f;
    private float waitTime = 1.0f;

    private string participant;
    private string group;
    private string timestamp;
    private string stateLog;

    void Start()
    {
        cam = oculusCamera.GetComponent<Camera>();
        participant = PlayerPrefs.GetString("participant");
        group = PlayerPrefs.GetString("group");
    }


    void Update()
    {
        affectiveState = DefineState.currentState;
        //Debug.Log(affectiveState);

        if (affectiveState == "HVHA")
        {

            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.white;

            NeutralTerrain.SetActive(false);
            ExcitingTerrain.SetActive(true);
            CalmingTerrain.SetActive(false);
            DepressingTerrain.SetActive(false);
            StressingTerrain.SetActive(false);

            NeutralParticles.SetActive(false);
            ExcitingParticles.SetActive(true);
            CalmingParticles.SetActive(false);
            DepressingParticles.SetActive(false);
            StressingParticles.SetActive(false);

            ExcitingSky.SetActive(true);
            DepressingSky.SetActive(false);

            FeedbackStressed.SetActive(false);
            FeedbackCalm.SetActive(false);
            FeedbackSad.SetActive(false);
            FeedbackExcited.SetActive(true);
            FeedbackNeutral.SetActive(false);

            //Debug.Log("Exciting");
        }

        if (affectiveState == "HVLA")
        {
            cam.clearFlags = CameraClearFlags.Skybox;

            NeutralTerrain.SetActive(false);
            ExcitingTerrain.SetActive(false);
            CalmingTerrain.SetActive(true);
            DepressingTerrain.SetActive(false);
            StressingTerrain.SetActive(false);

            NeutralParticles.SetActive(false);
            ExcitingParticles.SetActive(false);
            CalmingParticles.SetActive(true);
            DepressingParticles.SetActive(false);
            StressingParticles.SetActive(false);

            ExcitingSky.SetActive(false);
            DepressingSky.SetActive(false);

            FeedbackStressed.SetActive(false);
            FeedbackCalm.SetActive(true);
            FeedbackSad.SetActive(false);
            FeedbackExcited.SetActive(false);
            FeedbackNeutral.SetActive(false);

            //Debug.Log("Calming");
        }

        if (affectiveState == "LVLA")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = new Color(29, 29, 29);

            NeutralTerrain.SetActive(false);
            ExcitingTerrain.SetActive(false);
            CalmingTerrain.SetActive(false);
            DepressingTerrain.SetActive(true);
            StressingTerrain.SetActive(false);

            NeutralParticles.SetActive(false);
            ExcitingParticles.SetActive(false);
            CalmingParticles.SetActive(false); ;
            DepressingParticles.SetActive(true);
            StressingParticles.SetActive(false);

            ExcitingSky.SetActive(false);
            DepressingSky.SetActive(true);

            FeedbackStressed.SetActive(false);
            FeedbackCalm.SetActive(false);
            FeedbackSad.SetActive(true);
            FeedbackExcited.SetActive(true);
            FeedbackNeutral.SetActive(false);

            //Debug.Log("Depressing");
        }

        if (affectiveState == "LVHA")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = new Color(0, 0, 0);

            NeutralTerrain.SetActive(false);
            ExcitingTerrain.SetActive(false);
            CalmingTerrain.SetActive(false);
            DepressingTerrain.SetActive(false);
            StressingTerrain.SetActive(true);

            NeutralParticles.SetActive(false);
            ExcitingParticles.SetActive(false);
            CalmingParticles.SetActive(false);
            DepressingParticles.SetActive(false);
            StressingParticles.SetActive(true);

            ExcitingSky.SetActive(false);
            DepressingSky.SetActive(false);

            FeedbackStressed.SetActive(true);
            FeedbackCalm.SetActive(false);
            FeedbackSad.SetActive(false);
            FeedbackExcited.SetActive(true);
            FeedbackNeutral.SetActive(false);

            //Debug.Log("Stressing");
        }

        if (affectiveState == "neutral")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = new Color(255, 255, 255);

            NeutralTerrain.SetActive(true);
            ExcitingTerrain.SetActive(false);
            CalmingTerrain.SetActive(false);
            DepressingTerrain.SetActive(false);
            StressingTerrain.SetActive(false);

            NeutralParticles.SetActive(true);
            ExcitingParticles.SetActive(false);
            CalmingParticles.SetActive(false);
            DepressingParticles.SetActive(false);
            StressingParticles.SetActive(false);

            ExcitingSky.SetActive(false);
            DepressingSky.SetActive(false);

            FeedbackStressed.SetActive(false);
            FeedbackCalm.SetActive(false);
            FeedbackSad.SetActive(false);
            FeedbackExcited.SetActive(false);
            FeedbackNeutral.SetActive(true);

            //Debug.Log("Neutral");
        }

        timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd,HH.mm.ss");
        stateLog = participant + "," + group + "," + affectiveState;

        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            System.IO.File.WriteAllText(@"States\" + timestamp + ".csv", stateLog);
            timer = timer - waitTime;
        }


        Debug.Log("Current state is " + affectiveState);

    }
}
