using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAuto : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(AutoSetActive());
    }
    IEnumerator AutoSetActive()
    {
        yield return new WaitForSeconds(gameObject.GetComponent<ParticleSystem>().duration);
        gameObject.SetActive(false);
    }
}

