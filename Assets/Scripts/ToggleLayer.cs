// Controls the GameObject displayed in the scene.
// It is not possible to switch scenes because the LSL stream is lost once the scene changes.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleLayer : MonoBehaviour
{
    public GameObject Intro;
    public GameObject IntroTwo;
    public GameObject CodeSelector;
    public GameObject SAMInstructions;
    public GameObject Practice;
    public GameObject SAMPractice;
    public GameObject StartExp;
    public GameObject Game1;
    public GameObject SAM1;
    public GameObject Game2;
    public GameObject SAM2;
    public GameObject Game3;
    public GameObject SAM3;
    public GameObject Game4;
    public GameObject SAM4;
    public GameObject Game5;
    public GameObject SAM5;
    public GameObject End;

    public GameObject GazePointer;
    public GameObject oculusCamera;
    private Camera cam;
    public Vector3 myCamPos = Vector3.zero;

    public GameObject NeutralParticles;
    public GameObject ExcitingParticles;
    public GameObject CalmingParticles;
    public GameObject DepressingParticles;
    public GameObject StressingParticles;
    
    // Define markers
    private string markerIntro =                "intro";
    private string markerIntroTwo =             "intro-two";
    private string markerCodeSelector =         "code-selector";
    private string markerSAMInstructions =      "sam-instructions";
    private string markerPractice =             "practice";
    private string markerSAMPractice =          "sam-practice";
    private string markerStartExp =             "start-exp";
    private string markerGame1 =                "game-1";
    private string markerSAM1 =                 "game-sam-1";
    private string markerGame2 =                "game-2";
    private string markerSAM2 =                 "game-sam-2";
    private string markerGame3 =                "game-3";
    private string markerSAM3 =                 "game-sam-3";
    private string markerGame4 =                "game-4";
    private string markerSAM4 =                 "game-sam-4";
    private string markerGame5 =                "game-5";
    private string markerSAM5 =                 "game-sam-5";
    private string markerEnd =                  "end";


    public void Start()
    {
        cam = oculusCamera.GetComponent<Camera>();
        PlayerPrefs.SetString("Marker", markerIntro);
        PlayerPrefs.SetString("ActiveObject", "Intro");
    }

    public void LoadIntroTwo()
    {
        Intro.SetActive(false);
        IntroTwo.SetActive(true);
        PlayerPrefs.SetString("Marker", markerIntroTwo);
        PlayerPrefs.SetString("ActiveObject", "IntroTwo");
    }

    public void LoadCodeSelector()
    {
        IntroTwo.SetActive(false);
        CodeSelector.SetActive(true);
        PlayerPrefs.SetString("Marker", markerCodeSelector);
        PlayerPrefs.SetString("ActiveObject", "CodeSelector");
    }

    public void LoadSAMInstructions()
    {
        CodeSelector.SetActive(false);
        SAMInstructions.SetActive(true);
        PlayerPrefs.SetString("Marker", markerSAMInstructions);
        PlayerPrefs.SetString("ActiveObject", "SAMInstructions");
    }

    public void LoadPractice()
    {
        SAMInstructions.SetActive(false);
        Practice.SetActive(true);
        PlayerPrefs.SetString("Marker", markerSAMInstructions);
        PlayerPrefs.SetString("ActiveObject", "Practice");
    }

    public void LoadSAMPractice()
    {
        Practice.SetActive(false);
        SAMPractice.SetActive(true);
        GazePointer.SetActive(true);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(255, 255, 255);

        NeutralParticles.SetActive(true);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);
        PlayerPrefs.SetString("Marker", markerSAMPractice);
        PlayerPrefs.SetString("ActiveObject", "SAMPractice");
    }

    public void LoadStartExp()
    {
        SAMPractice.SetActive(false);
        StartExp.SetActive(true);
        PlayerPrefs.SetString("Marker", markerSAMInstructions);
        PlayerPrefs.SetString("ActiveObject", "SAMInstructions");
    }

    public void LoadGame1()
    {
        StartExp.SetActive(false);
        Game1.SetActive(true);
        GazePointer.SetActive(false);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        PlayerPrefs.SetString("Marker", markerGame1);
        PlayerPrefs.SetString("ActiveObject", "Game1");
    }

    public void LoadSAM1()
    {
        Game1.SetActive(false);
        SAM1.SetActive(true);
        GazePointer.SetActive(true);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(255, 255, 255);

        NeutralParticles.SetActive(true);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);
        PlayerPrefs.SetString("Marker", markerSAM1);
        PlayerPrefs.SetString("ActiveObject", "SAM1");
    }

    public void LoadGame2()
    {
        SAM1.SetActive(false);
        Game2.SetActive(true);
        GazePointer.SetActive(false);
        PlayerPrefs.SetString("Marker", markerGame2);
        PlayerPrefs.SetString("ActiveObject", "Game2");
    }

    public void LoadSAM2()
    {
        Game2.SetActive(false);
        SAM2.SetActive(true);
        GazePointer.SetActive(true);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(255, 255, 255);

        NeutralParticles.SetActive(true);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);
        PlayerPrefs.SetString("Marker", markerSAM2);
        PlayerPrefs.SetString("ActiveObject", "SAM2");
    }

    public void LoadGame3()
    {
        SAM2.SetActive(false);
        Game3.SetActive(true);
        GazePointer.SetActive(false);
        PlayerPrefs.SetString("Marker", markerGame3);
        PlayerPrefs.SetString("ActiveObject", "Game3");
    }

    public void LoadSAM3()
    {
        Game3.SetActive(false);
        SAM3.SetActive(true);
        GazePointer.SetActive(true);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(255, 255, 255);

        NeutralParticles.SetActive(false);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);
        PlayerPrefs.SetString("Marker", markerSAM3);
        PlayerPrefs.SetString("ActiveObject", "SAM3");
    }

    public void LoadGame4()
    {
        SAM3.SetActive(false);
        Game4.SetActive(true);
        GazePointer.SetActive(false);
        PlayerPrefs.SetString("Marker", markerGame4);
        PlayerPrefs.SetString("ActiveObject", "Game4");
    }

    public void LoadSAM4()
    {
        Game4.SetActive(false);
        SAM4.SetActive(true);
        GazePointer.SetActive(true);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(255, 255, 255);

        NeutralParticles.SetActive(false);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);
        PlayerPrefs.SetString("Marker", markerSAM4);
        PlayerPrefs.SetString("ActiveObject", "SAM4");
    }

    public void LoadGame5()
    {
        SAM4.SetActive(false);
        Game5.SetActive(true);
        GazePointer.SetActive(false);
        PlayerPrefs.SetString("Marker", markerGame5);
        PlayerPrefs.SetString("ActiveObject", "Game5");
    }

    public void LoadSAM5()
    {
        Game5.SetActive(false);
        SAM5.SetActive(true);
        GazePointer.SetActive(true);

        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().EnableRotation = false;

        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(255, 255, 255);

        NeutralParticles.SetActive(false);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);
        PlayerPrefs.SetString("Marker", markerSAM5);
        PlayerPrefs.SetString("ActiveObject", "SAM5");
    }

    public void LoadEnd()
    {
        SAM5.SetActive(false);
        End.SetActive(true);
        GameObject.Find("OVRPlayerController").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("OVRPlayerController").transform.position = new Vector3(10.0f, 1.0f, -10.0f);
        GameObject.Find("OVRPlayerController").transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);

        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(255, 255, 255);

        NeutralParticles.SetActive(false);
        ExcitingParticles.SetActive(false);
        CalmingParticles.SetActive(false);
        DepressingParticles.SetActive(false);
        StressingParticles.SetActive(false);
        PlayerPrefs.SetString("Marker", markerEnd);
        PlayerPrefs.SetString("ActiveObject", "End");
    }

}