using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTimer4 : MonoBehaviour
{
    private float levelTime;
    private float levelDuration = 60.0F;

    void Update()
    {
        levelTime += Time.deltaTime;

        if (levelTime > levelDuration)
        {
            levelTime = 0.0F;
            GameObject.Find("ToggleLayer").GetComponent<ToggleLayer>().LoadSAM4();
        }

    }
}
