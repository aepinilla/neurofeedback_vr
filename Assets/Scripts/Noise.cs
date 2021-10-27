using UnityEngine;
using System.Collections;

public class Noise : MonoBehaviour
{
    void Update()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var no = ps.noise;

        if (1.0f == OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger)) {
            no.strength = 1.0f;
        }

        else { 
            no.strength = 50.0f;
        }
    }
}