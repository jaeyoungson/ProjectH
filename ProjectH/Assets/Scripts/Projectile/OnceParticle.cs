using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceParticle : MonoBehaviour
{
    private void Update()
    {
        if(!gameObject.GetComponent<ParticleSystem>().isPlaying)
        {
            gameObject.SetActive(false);
        }
    }
}
