// Creates a color trail in the exciting particles system.

using UnityEngine;
using System.Collections;

public class ColorTrail : MonoBehaviour
{
    private ParticleSystem ps;
    private Gradient gradient = new Gradient();
    public bool swapColors = true;

    private HsbColor hsbColor;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        hsbColor = GetComponent<HsbColor>();

        var trails = ps.trails;
        var psr = GetComponent<ParticleSystemRenderer>();
    }

    void Update()
    {
        var trails = ps.trails;

        gradient.SetKeys(
                new GradientColorKey[] { new GradientColorKey(hsbColor.currentColor, 0.0f), new GradientColorKey(hsbColor.currentColor, 0.4f) },
                new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 1.0f) }
            );
        
        trails.colorOverTrail = gradient;
    }
}