using UnityEngine;

public class GradientColor : MonoBehaviour
{
    Gradient gradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKey;

    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var main = ps.main;

        gradient = new Gradient();

        // Populate the color keys at the relative time 0 and 1 (0 and 100%)
        colorKey = new GradientColorKey[8];
        colorKey[0].color = new Color(1.0f, 0.23f, 0.23f, 1.0f);
        colorKey[0].time = 0.0f;
        colorKey[1].color = new Color(1.0f, 0.84f, 0.27f, 1.0f);
        colorKey[1].time = 0.15f;
        colorKey[2].color = new Color(0.74f, 1.0f, 0.32f, 1.0f);
        colorKey[2].time = 0.31f;
        colorKey[3].color = new Color(0.37f, 1.0f, 0.73f, 1.0f);
        colorKey[3].time = 0.45f;
        colorKey[4].color = new Color(0.07f, 0.62f, 1.0f, 1.0f);
        colorKey[4].time = 0.60f;
        colorKey[5].color = new Color(0.55f, 0.35f, 1.0f, 1.0f);
        colorKey[5].time = 0.72f;
        colorKey[6].color = new Color(1.0f, 0.22f, 0.82f, 1.0f);
        colorKey[6].time = 0.88f;
        colorKey[7].color = new Color(1.0f, 0.29f, 0.24f, 1.0f);
        colorKey[7].time = 1.0f;

        // Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
        alphaKey = new GradientAlphaKey[8];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 1.0f;
        alphaKey[1].time = 0.0f;
        alphaKey[2].alpha = 1.0f;
        alphaKey[2].time = 0.0f;
        alphaKey[3].alpha = 1.0f;
        alphaKey[3].time = 0.0f;
        alphaKey[4].alpha = 1.0f;
        alphaKey[4].time = 0.0f;
        alphaKey[5].alpha = 1.0f;
        alphaKey[5].time = 0.0f;
        alphaKey[6].alpha = 1.0f;
        alphaKey[6].time = 0.0f;
        alphaKey[7].alpha = 1.0f;
        alphaKey[7].time = 0.0f;

        gradient.SetKeys(colorKey, alphaKey);

        main.startColor = gradient;
    }
}