﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

[System.Serializable]
public class AbnormalCondition
{
    public AbnormalCondition()
    {

    }
    public AbnormalCondition(AbnormalConditionState index)
    {
        condition = index;
    }
    public bool conditionActivate;
    public AbnormalConditionState condition { get; private set; }
    public float duration { get; private set; }
    public float maxResist { get; private set; }
    public float curResist;
    
    #region Set
    
    //최대 저항값
    public void SetMaxResist(float resist)
    {
        maxResist = resist;
    }
    //상태이상이 들어 올때 지속시간값
    public void Setduration(float durationTime)
    {
        duration = durationTime;
    }
    #endregion

    //상태이상 켬
    public IEnumerator ActiveCondition()
    {
        conditionActivate = true;
        yield return new WaitForSeconds(duration);
        conditionActivate = false;
    }   
}
