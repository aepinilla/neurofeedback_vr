using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTimer1 : MonoBehaviour
{
    private float levelTime;
    private float levelDuration = 60.0F;

    void Update()
    {
        levelTime += Time.deltaTime;
           
        if (levelTime > levelDuration)
        {
            GameObject.Find("ToggleLayer").GetComponent<ToggleLayer>().LoadSAM1();
        }

    }
}
