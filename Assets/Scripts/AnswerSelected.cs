using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerSelected : MonoBehaviour
{
    Toggle defaultToggle;
    public GameObject submitButton;

    void Start()
    {
        defaultToggle = GetComponent<Toggle>();
        defaultToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(defaultToggle);
        });

        submitButton.SetActive(false);
    }

    void ToggleValueChanged(Toggle change)
    {
        submitButton.SetActive(true);
    }

}
