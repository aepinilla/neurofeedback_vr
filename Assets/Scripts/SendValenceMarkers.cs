using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LSL;
using UnityEngine.SceneManagement;


public class SendValenceMarkers : MonoBehaviour
{
    private static liblsl.StreamOutlet outlet;
    public string StreamName = "Unity.MarkersValenceStream";
    public string StreamType = "Unity.StreamType";
    public string StreamId = "MyStreamID-UnityValence";
    private string[] marker;
    private string activeObject;
    private string previousActiveObject = "null";

    private int i = 0;

    private float timer = 0.0f;
    private float waitTime = 1.0f;


    void Start()
    {
        liblsl.StreamInfo streamInfo = new liblsl.StreamInfo(StreamName, StreamType, 1, liblsl.IRREGULAR_RATE, liblsl.channel_format_t.cf_string);
        liblsl.XMLElement chans = streamInfo.desc().append_child("channels");
        chans.append_child("channel").append_child_value("label", "Marker");
        outlet = new liblsl.StreamOutlet(streamInfo);
        marker = new string[1];
    }


    void Update()
    {

        if (i < 27)
        {
            marker[0] = PlayerPrefs.GetString("MarkerValence");
            activeObject = PlayerPrefs.GetString("ActiveObject");

            if (activeObject != previousActiveObject)
            {
                outlet.push_sample(marker);
                i++;
            }

            previousActiveObject = activeObject;

            if (marker[0] == "lv" || marker[0] == "hv")
            {
                if (CalibrationController.isStimuliActivated == true)
                {
                    timer += Time.deltaTime;
                    if (timer > waitTime)
                    {
                        //Debug.Log(marker[0]);
                        outlet.push_sample(marker);
                        timer = timer - waitTime;
                    }
                }      
            }
        }

        if (i >= 27)
        {
            marker[0] = "unknown";

            timer += Time.deltaTime;
            if (timer > waitTime)
            {
                outlet.push_sample(marker);
                timer = timer - waitTime;
            }
        }
    }
}