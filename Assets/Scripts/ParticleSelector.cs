using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSelector : MonoBehaviour
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
        if(stimuliContainer.name == "ExcitingContainer")
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

            //Debug.Log("Exciting");
        }


        if (stimuliContainer.name == "RelaxingContainer")
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

            //debug.log("calming");
        }

        if (stimuliContainer.name == "DepressingContainer")
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

            //debug.log("depressing");
        }

        if (stimuliContainer.name == "StressingContainer")
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

            //debug.log("stressing");
        }

        if (stimuliContainer.name == "NeutralContainer")
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

            //debug.log("stressing");
        }

    }
}
