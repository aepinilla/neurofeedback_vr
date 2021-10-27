// Sends markers to NeuroPype 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LSL;
using UnityEngine.SceneManagement;


public class SendMarkersRecord : MonoBehaviour
{
    private static liblsl.StreamOutlet outlet;
    public string StreamName = "Unity.MarkersStreamRecord";
    public string StreamType = "Unity.StreamType";
    public string StreamId = "MyStreamID-Unity5678";
    private string[] marker;
    private string activeObject;
    private string previousActiveObject = "null";
    

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

        marker[0] = PlayerPrefs.GetString("Marker");
        activeObject = PlayerPrefs.GetString("ActiveObject");

        if (activeObject != previousActiveObject)
        {
            outlet.push_sample(marker);
            Debug.Log(activeObject);
        }

        previousActiveObject = activeObject;
        
    }
}