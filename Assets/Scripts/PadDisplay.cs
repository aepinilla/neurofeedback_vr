﻿// Controls the pad display used to enter the code of the participant.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PadDisplay : MonoBehaviour
{
    [SerializeField]
    private Sprite[] digits;

    [SerializeField]
    private Image[] characters;

    private string codeSequence;

    void Start()
    {
        codeSequence = "";

        for (int i = 0; i <= characters.Length -1; i++)
        {
            characters[i].sprite = digits[10];
        }

        PushPad.ButtonPressed += AddDigitToCodeSequence;
    }

    public void SubmitCode()
    {
        PlayerPrefs.SetString("participant", codeSequence);
    }

    private void AddDigitToCodeSequence(string digitEntered)
    {
        if (codeSequence.Length < 8)
        {
            switch (digitEntered)
            {
                case "Zero":
                    codeSequence += "0";
                    DisplayCodeSequence(0);
                    break;
                case "One":
                    codeSequence += "1";
                    DisplayCodeSequence(1);
                    break;
                case "Two":
                    codeSequence += "2";
                    DisplayCodeSequence(2);
                    break;
                case "Three":
                    codeSequence += "3";
                    DisplayCodeSequence(3);
                    break;
                case "Four":
                    codeSequence += "4";
                    DisplayCodeSequence(4);
                    break;
                case "Five":
                    codeSequence += "5";
                    DisplayCodeSequence(5);
                    break;
                case "Six":
                    codeSequence += "6";
                    DisplayCodeSequence(6);
                    break;
                case "Seven":
                    codeSequence += "7";
                    DisplayCodeSequence(7);
                    break;
                case "Eight":
                    codeSequence += "8";
                    DisplayCodeSequence(8);
                    break;
                case "Nine":
                    codeSequence += "9";
                    DisplayCodeSequence(9);
                    break;
            }
        }

        switch (digitEntered)
        {
            case "Clear":
                ResetDisplay();
                break;
            case "Delete":
                if (codeSequence.Length > 0)
                {
                    
                }
                break;
        }
    }

    private void DisplayCodeSequence(int digitJustEntered)
    {
        switch (codeSequence.Length)
        {
            case 1:
                characters[0].sprite = digits[digitJustEntered];
                characters[1].sprite = digits[10];
                characters[2].sprite = digits[10];
                characters[3].sprite = digits[10];
                characters[4].sprite = digits[10];
                characters[5].sprite = digits[10];
                characters[6].sprite = digits[10];
                characters[7].sprite = digits[10];
                break;
            case 2:
                characters[0].sprite = characters[0].sprite;
                characters[1].sprite = digits[digitJustEntered];
                characters[2].sprite = digits[10];
                characters[3].sprite = digits[10];
                characters[4].sprite = digits[10];
                characters[5].sprite = digits[10];
                characters[6].sprite = digits[10];
                characters[7].sprite = digits[10];
                break;
             case 3:
                characters[0].sprite = characters[0].sprite;
                characters[1].sprite = characters[1].sprite;
                characters[2].sprite = digits[digitJustEntered];
                characters[3].sprite = digits[10];
                characters[4].sprite = digits[10];
                characters[5].sprite = digits[10];
                characters[6].sprite = digits[10];
                characters[7].sprite = digits[10];
                break;
             case 4:
                characters[0].sprite = characters[0].sprite;
                characters[1].sprite = characters[1].sprite;
                characters[2].sprite = characters[2].sprite;
                characters[3].sprite = digits[digitJustEntered];
                characters[4].sprite = digits[10];
                characters[5].sprite = digits[10];
                characters[6].sprite = digits[10];
                characters[7].sprite = digits[10];
                break;
            case 5:
                characters[0].sprite = characters[0].sprite;
                characters[1].sprite = characters[1].sprite;
                characters[2].sprite = characters[2].sprite;
                characters[3].sprite = characters[3].sprite;
                characters[4].sprite = digits[digitJustEntered];
                characters[5].sprite = digits[10];
                characters[6].sprite = digits[10];
                characters[7].sprite = digits[10];
                break;
            case 6:
                characters[0].sprite = characters[0].sprite;
                characters[1].sprite = characters[1].sprite;
                characters[2].sprite = characters[2].sprite;
                characters[3].sprite = characters[3].sprite;
                characters[4].sprite = characters[4].sprite;
                characters[5].sprite = digits[digitJustEntered];
                characters[6].sprite = digits[10];
                characters[7].sprite = digits[10];
                break;
            case 7:
                characters[0].sprite = characters[0].sprite;
                characters[1].sprite = characters[1].sprite;
                characters[2].sprite = characters[2].sprite;
                characters[3].sprite = characters[3].sprite;
                characters[4].sprite = characters[4].sprite;
                characters[5].sprite = characters[5].sprite;
                characters[6].sprite = digits[digitJustEntered];
                characters[7].sprite = digits[10];
                break;
            case 8:
                characters[0].sprite = characters[0].sprite;
                characters[1].sprite = characters[1].sprite;
                characters[2].sprite = characters[2].sprite;
                characters[3].sprite = characters[3].sprite;
                characters[4].sprite = characters[4].sprite;
                characters[5].sprite = characters[5].sprite;
                characters[6].sprite = characters[6].sprite;
                characters[7].sprite = digits[digitJustEntered];
                break;
        }
    }

    private void ResetDisplay()
    {
        for (int i = 0; i <= characters.Length -1; i++)
        {
            characters[i].sprite = digits[10];
        }

        codeSequence = "";
    }

    private void OnDestroy()
    {
        PushPad.ButtonPressed -= AddDigitToCodeSequence;
    }
}
