using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SubmitAnswers : MonoBehaviour
{
    private float currentSceneIndex;
    private string nextSceneName;

    void Start()
    {
        currentSceneIndex = PlayerPrefs.GetFloat("CurrentSceneIndex");
        SelectNextScene();
    }

    void SelectNextScene()
    {
        switch (currentSceneIndex)
        {
            case 0:
                nextSceneName = PlayerPrefs.GetString("FirstScene");
                break;
            case 1:
                nextSceneName = PlayerPrefs.GetString("SecondScene");
                break;
            case 2:
                nextSceneName = PlayerPrefs.GetString("ThirdScene");
                break;
            case 3:
                nextSceneName = PlayerPrefs.GetString("FourthScene");
                break;
            case 4:
                nextSceneName = PlayerPrefs.GetString("FifthScene");
                break;
            case 5:
                nextSceneName = "End";
                break;
        }
    }

    public void backToExp()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void backToPractice()
    {
        SceneManager.LoadScene("ReadyScreen");
    }

    
}
