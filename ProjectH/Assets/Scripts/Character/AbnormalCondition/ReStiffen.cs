using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReStiffen 
{
    [HideInInspector]
    public bool reStiffen;
    private float reStiffenTime;
    private float curReStiffenTime;

    public void ReStiffenCheck()
    {
        if (reStiffen)
        {
            if (curReStiffenTime < reStiffenTime)
            {
                curReStiffenTime += Time.deltaTime;
            }
            else
            {
                reStiffen = false;
                curReStiffenTime = 0;
            }
        }
    }

    public void SetReStiffenTime(float a_reStiffenTime)
    {
        reStiffen = true;
        reStiffenTime = a_reStiffenTime;
    }
}
