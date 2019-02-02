using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour
{
    [HideInInspector]
    public bool combo { get; private set; }
    private float curTime;
    private float skillComboTime;

    private void Update()
    {
        if(curTime<skillComboTime)
        {
            curTime += Time.deltaTime;
            combo = true;
        }
        else
        {
            combo = false;
        }
    }


    public void SetSkillComboTime(float time)
    {
        curTime = 0;
        skillComboTime = time;
    }
}
