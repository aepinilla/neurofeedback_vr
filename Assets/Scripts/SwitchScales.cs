using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchScales : MonoBehaviour
{
    public GameObject submitButton;
    public GameObject nextScaleButton;
    public GameObject [] defaultToggles;
    public GameObject[] scales;
    private GameObject currentScale;
    private GameObject nextScale;
    public int scalesIndex = 0;

    void Start()
    {
        submitButton.SetActive(false);
        nextScaleButton.SetActive(false);
        scales[1].SetActive(false);
        scales[2].SetActive(false);
    }

    void Update()
    {
        
        Toggle dt = defaultToggles[scalesIndex].GetComponent<Toggle>();
        dt.onValueChanged.AddListener(delegate {
            ToggleValueChanged(dt);
        });
    }

    void ToggleValueChanged(Toggle change)
    {
        if(scalesIndex < 2)
        {
            nextScaleButton.SetActive(true);
            currentScale = scales[scalesIndex];
            nextScale = scales[scalesIndex + 1];
        }

        else
        {
            submitButton.SetActive(true);
        }
    }

    public void NextScale()
    {
        scalesIndex += 1;
        
        currentScale.SetActive(false);
        nextScale.SetActive(true);
        nextScaleButton.SetActive(false);    
    }

}
