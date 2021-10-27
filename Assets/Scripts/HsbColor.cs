using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HsbColor : MonoBehaviour
{
    public float Hue;
    public float Saturation;
    public float Brightness;

    public Color currentColor;

    //public Slider SliderHue, SliderSaturation, SliderBrightness;
    Renderer Renderer;

    void Start()
    {
        Renderer = GetComponent<Renderer>();

        //        SliderHue.maxValue = 1;
        //        SliderSaturation.maxValue = 1;
        //        SliderBrightness.maxValue = 1;

        //        SliderHue.minValue = 0;
        //        SliderSaturation.minValue = 0;
        //        SliderBrightness.minValue = 0;
        Hue = 0;
        Saturation = 1;
        Brightness = 1;
    }

    void Update()
    {
        //Renderer.material.color = Color.HSVToRGB(Hue, Saturation, Brightness);
        //currentColor = Color.HSVToRGB(Hue, Saturation, Brightness);

        Renderer.material.color = new Color(0.5f, 0.5f, 0.01f, 0.9f);
        currentColor = new Color(0.5f, 0.5f, 0.01f, 0.9f);
    }
}