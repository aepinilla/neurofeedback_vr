using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineState : MonoBehaviour
{
    public static string currentValence;
    public static string currentArousal;

    public static string currentState;

    private float stateIndex = 0.0F;


    void Update()
    {
        currentValence = ReceiveValenceLabels.ValenceType;
        currentArousal = ReceiveArousalLabels.ArousalType;

        // Change detected affective state with the Oculus Controller. Use for testing.
        //if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        //{
        //    if (stateIndex < 4)
        //    {
        //        stateIndex += 1;
        //    }

        //    else
        //    {
        //        stateIndex = 0.0F;
        //    }
        //}

        //switch (stateIndex)
        //{
        //    case 0:
        //        currentState = null;
        //        break;
        //    case 1:
        //        currentState = "HVHA";
        //        break;
        //    case 2:
        //        currentState = "HVLA";
        //        break;
        //    case 3:
        //        currentState = "LVLA";
        //        break;
        //    case 4:
        //        currentState = "LVHA";
        //        break;
        //}


        if (currentValence == "HV" && currentArousal == "HA")
        {
            currentState = "HVHA";
        }
        else if (currentValence == "HV" && currentArousal == "LA")
        {
            currentState = "HVLA";
        }

        else if (currentValence == "LV" && currentArousal == "LA")
        {
            currentState = "LVLA";
        }

        else if (currentValence == "LV" && currentArousal == "HA")
        {
            currentState = "LVHA";
        }

        else
        {
            currentState = "neutral";
        }

    }
}
