using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAuto : MonoBehaviour
{
    public float duration;
    private float curDurationTime;
    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeInHierarchy==true)
        {
            if(curDurationTime<duration)
            {
                curDurationTime += Time.deltaTime;
            }
            else
            {
                curDurationTime = 0;
                gameObject.SetActive(false);
            }
        }
    }
}

