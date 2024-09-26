using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParticle : MonoBehaviour
{
    public ParticleSystem burstParticleSystem;

    void Update()
    {
        // Check if space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the particle system
            burstParticleSystem.Play();
        }
    }
}
