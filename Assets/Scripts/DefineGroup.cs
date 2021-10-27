// Defines the group (experimental or control) assigned to the participant. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefineGroup : MonoBehaviour
{
    private string activeScene;

    void Start()
    {
        activeScene = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        if (activeScene == "ControlGroup")
        {
            PlayerPrefs.SetString("group", "control");
        }

        if (activeScene == "ExperimentalGroup")
        {
            PlayerPrefs.SetString("group", "experimental");
        }
    }
}
