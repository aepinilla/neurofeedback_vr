using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LSL;
using UnityEngine.SceneManagement;


public class SendMarkersTest : MonoBehaviour
{
    private static liblsl.StreamOutlet outlet;
    public string StreamName = "Unity.MarkersValenceStream";
    public string StreamType = "Unity.StreamType";
    public string StreamId = "MyStreamID-Unity1234";
    private string[] marker;

    private int i;
    private string markerString;

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

        switch (i)
        {
            case 0:
                markerString = "null";
                break;
            case 1:
                markerString = "calib-begin";
                break;

            case 2:
                markerString = "hv";
                break;

            case 3:
                markerString = "hv";
                break;

            case 4:
                markerString = "hv";
                break;

            case 5:
                markerString = "hv";
                break;

            case 6:
                markerString = "hv";
                break;

            case 7:
                markerString = "lv";
                break;

            case 8:
                markerString = "lv";
                break;

            case 9:
                markerString = "lv";
                break;

            case 10:
                markerString = "lv";
                break;

            case 11:
                markerString = "lv";
                break;

            case 12:
                markerString = "calib-end";
                break;

            case 13:
                markerString = "calib-arousal-begin";
                break;

            case 14:
                markerString = "ha";
                break;

            case 15:
                markerString = "ha";
                break;

            case 16:
                markerString = "ha";
                break;

            case 17:
                markerString = "ha";
                break;

            case 18:
                markerString = "ha";
                break;

            case 19:
                markerString = "la";
                break;

            case 20:
                markerString = "la";
                break;

            case 21:
                markerString = "la";
                break;

            case 22:
                markerString = "la";
                break;

            case 23:
                markerString = "la";
                break;

            case 24:
                markerString = "calib-arousal-end";
                break;

        }

        if (i >= 25)
        {
            markerString = "unknown";
        }

        marker[0] = markerString;

        if (i < 25)
        {

            if (Input.GetKeyDown("space"))
            {
                if (marker[0] == "lv" || marker[0] == "hv" || marker[0] == "la" || marker[0] == "ha")
                {
                    timer += Time.deltaTime;
                    if (timer > waitTime)
                    {
                        outlet.push_sample(marker);
                        timer = timer - waitTime;
                    }
                }

                else
                {
                    outlet.push_sample(marker);
                    //Debug.Log(activeObject);
                }

                i++;
            }
        }

        if (i >= 25)
        {
            timer += Time.deltaTime;
            if (timer > waitTime)
            {
                outlet.push_sample(marker);
                timer = timer - waitTime;
            }
        }
    }
}
