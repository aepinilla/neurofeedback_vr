// This script generates a random order in which the stimuli is displayed.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStateSelector : MonoBehaviour
{

    private List<string> order = new List<string> { "ExcitingContainer", "DepressingContainer", "StressingContainer", "RelaxingContainer", "NeutralContainer" };

    void Start()
    {
        for (int i = 0; i < order.Count; i++)
        {
            string temp = order[i];
            int randomIndex = Random.Range(i, order.Count);
            order[i] = order[randomIndex];
            order[randomIndex] = temp;
        }

        PlayerPrefs.SetString("FirstTrial", order[0]);

        PlayerPrefs.SetString("SecondTrial", order[1]);

        PlayerPrefs.SetString("ThirdTrial", order[2]);

        PlayerPrefs.SetString("FourthTrial", order[3]);

        PlayerPrefs.SetString("FifthTrial", order[4]);

    }
    
}
