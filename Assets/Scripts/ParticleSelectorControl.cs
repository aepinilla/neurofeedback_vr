using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSelectorControl : MonoBehaviour
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

    public GameObject stimuliContainer;
    private string trainingStimuli;

    void Start()
    {
        cam = oculusCamera.GetComponent<Camera>();
    }


    void Update()
    {
        if (stimuliContainer.name == "ExcitingContainer")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.white;

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

            //Debug.Log("Exciting");
        }


        if (stimuliContainer.name == "RelaxingContainer")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.white;

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

            //debug.log("calming");
        }

        if (stimuliContainer.name == "DepressingContainer")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.white;

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

            //debug.log("depressing");
        }

        if (stimuliContainer.name == "StressingContainer")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.white;

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

            //debug.log("stressing");
        }

        if (stimuliContainer.name == "NeutralContainer")
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.white;

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

            //debug.log("stressing");
        }

    }
}
