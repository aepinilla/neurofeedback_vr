using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameIterations : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetFloat("GameIteration", 0.0f);
    }
}
